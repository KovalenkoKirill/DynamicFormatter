﻿using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using static DynamicFormatter.Models.DynamicBuffer;
using static DynamicFormatter.ReflectionUtils;
using static System.Buffer;
using TypeInfo = DynamicFormatter.Extentions.TypeInfo;
namespace DynamicFormatter.Serializers
{
	internal class DynamicFormatter
	{
		#region static instancesBlock

		private static Dictionary<int, DynamicFormatter> _instances = new Dictionary<int, DynamicFormatter>();

		public static DynamicFormatter Instance(Type type)
		{
			DynamicFormatter instanse;
			if (!_instances.TryGetValue(type.GetHashCode(), out instanse))
			{
				instanse = new DynamicFormatter(type);
				_instances.Add(type.GetHashCode(), instanse);
			}
			return instanse;
		}

		#endregion static instancesBlock

		#region constField

		private static readonly byte[] nullPtrBytres = BitConverter.GetBytes(((short)-1));

		internal static readonly int PtrSize = sizeof(short);

		#endregion constField

		#region classFields

		private Func<object, byte[]> _Serialize;

		private Func<byte[], object> _Deserialize;

		private Dictionary<int, GetterAndSetter> _accessMethods;

		private TypeInfo _typeInfo;


		#endregion classFields

		#region serialize/Desirialize method

		public object Deserialize(byte[] buffer)
		{
			return _Deserialize(buffer);
		}

		public byte[] Serialize(object entity)
		{
			return _Serialize(entity);
		}

		#endregion serialize/Desirialize method

		#region constructor

		private DynamicFormatter(Type type)
		{
			_typeInfo = TypeInfo.instanse(type);
;
			if (_typeInfo.IsValueType &&
			(_typeInfo.IsPrimitive || !_typeInfo.IsHasReference))
			{
				_Serialize = (entity) =>
				{
					BitSerializer bitSerializer = BitSerializer.GetInstanse(_typeInfo.Type);
					return bitSerializer.Serialize(entity);
				};
				_Deserialize = (buffer) =>
				{
					BitSerializer bitSerializer = BitSerializer.GetInstanse(_typeInfo.Type);
#if USE_UNSAFE
					return bitSerializer.Deserialize(buffer,0);
#else
					return bitSerializer.Deserialize(buffer);
#endif
				};
			}
			else
			{
				initAccessField();
				_Serialize = (entity) =>
				{
					return ReferenceTypeSerialize(entity);
				};
				_Deserialize = (entityBytes) =>
				{
					return ReferenceTypeDesirialize(entityBytes);
				};
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void initAccessField()
		{
			_accessMethods = new Dictionary<int, GetterAndSetter>();
			foreach (var field in _typeInfo.Fields)
			{
				_accessMethods.Add(field.GetHashCode(),
				new GetterAndSetter()
				{
					Getter = CreateInstanceFieldGetter(field),
					Setter = CreateInstanceFieldSetter(field)
				});
			}
		}
		#endregion constructor

		#region Reflection Helpers

		private object GetValue(object entity, FieldInfo member)
		{
			return _accessMethods[member.GetHashCode()].Getter.Invoke(entity);
		}

		private void SetValue(object entity, object value, FieldInfo member)
		{
			_accessMethods[member.GetHashCode()].Setter.Invoke(entity, value);
		}

		#endregion Reflection Helpers

		#region Serilization

		private BufferPtr ArraySerialize(object entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping)
		{
			int size = sizeof(int);
			Array array = (Array)entity;
			Type memberType = _typeInfo.Type.GetElementType();
			var serializer = Instance(memberType);
			var memberTypeInfo = TypeInfo.instanse(memberType);
			if (memberType.IsValueType)
			{
				size += memberTypeInfo.Size * array.Length;
			}
			else
			{
				size += PtrSize * array.Length;
			}
			byte[] current = new byte[size];
			int currentPadding = 0;
			var ptr = buffer.Alloc(size);
			byte[] lenghtBytes = BitConverter.GetBytes(array.Length);
			BlockCopy(lenghtBytes, 0, current, 0, lenghtBytes.Length);
			currentPadding += lenghtBytes.Length;
			for (int i = 0; i < array.Length; i++)
			{
				object value = array.GetValue(i);
				if (value == null) //null ptr
				{
					BlockCopy(nullPtrBytres, 0, current, currentPadding, nullPtrBytres.Length);
					currentPadding += nullPtrBytres.Length;
				}
				else if (referenceMaping.ContainsKey(value))
				{
					var objectptr = referenceMaping[value];
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					BlockCopy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				if (memberTypeInfo.IsValueType &&
				(memberTypeInfo.IsPrimitive || !memberTypeInfo.IsHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberType);
					var memberBytes = BitSerializer.Serialize(value);
					BlockCopy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				else
				{
					var objectptr = Instance(memberType).ReferenceSerizlize(value, buffer, referenceMaping);
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					BlockCopy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
			}
			ptr.Set(current);
			return ptr;
		}

		//Serializetion For Reference type
		private BufferPtr ReferenceSerizlize(object Entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping)
		{
			if (!_typeInfo.IsValueType)
			{
				if (referenceMaping.ContainsKey(Entity))
				{
					return referenceMaping[Entity];
				}
			}
			if (_typeInfo.IsArray)
			{
				return ArraySerialize(Entity, buffer, referenceMaping);
			}
			int size = _typeInfo.Size;
			byte[] current = new byte[size];
			var ptr = buffer.Alloc(size);
			referenceMaping.Add(Entity, ptr);
			int currentPadding = 0;
			foreach (var member in _typeInfo.Fields)
			{
				var memberTypeInfo = TypeInfo.instanse(member.FieldType);
				object value = GetValue(Entity, member);
				if (value == null) //null ptr
				{
					BlockCopy(nullPtrBytres, 0, current, currentPadding, nullPtrBytres.Length);
					currentPadding += nullPtrBytres.Length;
				}
				else if (referenceMaping.ContainsKey(value))
				{
					var objectptr = referenceMaping[value];
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					BlockCopy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				if (memberTypeInfo.IsValueType &&
				(memberTypeInfo.IsPrimitive || !memberTypeInfo.IsHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberTypeInfo.Type);
					var memberBytes = BitSerializer.Serialize(value);
					BlockCopy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				else
				{
					var objectptr = Instance(memberTypeInfo.Type).ReferenceSerizlize(value, buffer, referenceMaping);
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					BlockCopy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
			}
			ptr.Set(current);
			return ptr;
		}

		private byte[] ReferenceTypeSerialize(object Entity)
		{
			var referenceMaping = new Dictionary<object, BufferPtr>();

			var buffer = new DynamicBuffer(100);
			ReferenceSerizlize(Entity, buffer, referenceMaping);
			return buffer.Buffer;
		}

		#endregion Serilization

		#region Desirilization

		private object ArrayDesirialize(BufferPtr ptr, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			var sizePtr = buffer.GetPtr(ptr.position, sizeof(int));
			int arrayLenght = BitConverter.ToInt32(sizePtr.Read(), 0);
			int bufferSize = sizeof(int);
			var elementTypeInfo = TypeInfo.instanse(_typeInfo.Type.GetElementType());
			Array entity = Array.CreateInstance(elementTypeInfo.Type, arrayLenght);
			var entitySerializer = Instance(elementTypeInfo.Type);

			int elementSize = elementTypeInfo.IsValueType ? elementTypeInfo.Size : PtrSize;

			bufferSize += elementSize * entity.Length;

			sizePtr = buffer.GetPtr(ptr.position, bufferSize);

			byte[] arrayBytes = sizePtr.Read();

			for (int index = 0; index < arrayLenght; index++)
			{
				int positionInByffer = sizeof(int) + (index * elementSize);

				if (elementTypeInfo.IsValueType &&
				   (elementTypeInfo.IsPrimitive || !elementTypeInfo.IsHasReference))
				{
					byte[] memberBuffer = new byte[elementSize];
					BlockCopy(arrayBytes, positionInByffer, memberBuffer, 0, elementSize);
					object element = entitySerializer.Deserialize(memberBuffer);
					entity.SetValue(element, index);
				}
				else
				{
					short elementPosition = BitConverter.ToInt16(arrayBytes, positionInByffer);
					object element;
					if (elementPosition == -1)
					{
						continue;
					}
					else if (referenceMaping.ContainsKey(elementPosition))
					{
						entity.SetValue(referenceMaping[elementPosition], index);
					}
					else
					{
						var elementPtr = buffer.GetPtr(elementPosition, elementTypeInfo.Size);
						element = entitySerializer.ReferenceDesirialize(elementPtr, buffer, referenceMaping);
						entity.SetValue(element, index);
					}
				}
			}

			referenceMaping.Add(ptr.position, entity);

			return entity;
		}

		private object ReferenceDesirialize(BufferPtr ptr, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			if (_typeInfo.IsArray)
			{
				return ArrayDesirialize(ptr, buffer, referenceMaping);
			}
			object entity = FormatterServices.GetSafeUninitializedObject(_typeInfo.Type);
			referenceMaping.Add(ptr.position, entity);

			byte[] objectBytes = ptr.Read();
			int bytesRead = 0;
			foreach (var member in _typeInfo.Fields)
			{
				var memberTypeInfo = TypeInfo.instanse(member.FieldType);
				if (memberTypeInfo.IsValueType &&
				   (memberTypeInfo.IsPrimitive || !memberTypeInfo.IsHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberTypeInfo.Type);
					int size = memberTypeInfo.Type.SizeOfPrimitive();
#if USE_UNSAFE
					object value = BitSerializer.Deserialize(objectBytes, bytesRead);

#else
					var currentMemberBytes = new byte[size];
					BlockCopy(objectBytes, bytesRead, currentMemberBytes, 0, size);
					object value = BitSerializer.Deserialize(currentMemberBytes);
#endif
					bytesRead += size;
					SetValue(entity, value, member);
				}
				else
				{
					short refPosition = BitConverter.ToInt16(objectBytes, bytesRead);
					if (refPosition == -1)
					{
						continue;
					}
					bytesRead += PtrSize;
					var Serializer = Instance(memberTypeInfo.Type);
					var refPtr = buffer.GetPtr(refPosition, memberTypeInfo.Size);
					object obj;
					if (referenceMaping.ContainsKey(refPtr.position))
					{
						obj = referenceMaping[refPtr.position];
					}
					else
					{
						obj = Serializer.ReferenceDesirialize(refPtr, buffer, referenceMaping);
					}
					SetValue(entity, obj, member);
				}
			}
			return entity;
		}

		private object ReferenceTypeDesirialize(byte[] entityBytes)
		{
			var referenceMaping = new Dictionary<int, object>();

			var buffer = new DynamicBuffer(entityBytes);

			var rootObject = buffer.GetPtr(0, _typeInfo.Size);

			return ReferenceDesirialize(rootObject, buffer, referenceMaping);
		}

		#endregion Desirilization
	}
}