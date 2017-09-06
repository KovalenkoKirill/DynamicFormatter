using DynamicFormatter.Models;
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

		private static readonly int PtrSize = sizeof(short);

		#endregion constField

		#region classFields

		private Func<object, byte[]> _Serialize;

		private Func<byte[], object> _Deserialize;

		private List<FieldInfo> _fields_;

		private List<FieldInfo> _fields
		{
			get
			{
				if(_fields_ == null)
				{
					_fields_ = _type.GetMembers(
						 BindingFlags.NonPublic |
						 BindingFlags.Public |
						 BindingFlags.Instance)
						 .Where(x => x.MemberType == MemberTypes.Field)
						 .Cast<FieldInfo>()
						 .ToList();
				}
				return _fields_;
			}
		}

		private Dictionary<int, GetterAndSetter> _accessMethods;

		private Type _type;

		internal int _size = 0;

		private bool? _isHasReference = null;

		internal bool isHasReference
		{
			get
			{
				if (_isHasReference == null)
				{
					_isHasReference = FindReferenceType();
				}
				return _isHasReference.Value;
			}
		}

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
			_type = type;

			_size = GetSize();

			if (_type.IsValueType &&
			(_type.IsPrimitive || !isHasReference))
			{
				_Serialize = (entity) =>
				{
					BitSerializer bitSerializer = BitSerializer.GetInstanse(_type);
					return bitSerializer.Serialize(entity);
				};
				_Deserialize = (buffer) =>
				{
					BitSerializer bitSerializer = BitSerializer.GetInstanse(_type);
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
			foreach (var field in _fields)
			{
				_accessMethods.Add(field.GetHashCode(),
				new GetterAndSetter()
				{
					Getter = CreateInstanceFieldGetter(field),
					Setter = CreateInstanceFieldSetter(field)
				});
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetSize()
		{
			int size = 0;
			if (_type.IsPrimitive)
			{
				return _type.SizeOfPrimitive();
			}
			else if (_type.IsArray)
			{
				return PtrSize;
			}
			foreach (var innerMember in _fields)
			{
				var innerMemberType = innerMember.FieldType;
				if (innerMemberType.IsPrimitive)
				{
					size += innerMemberType.SizeOfPrimitive();
				}
				else if (innerMemberType.IsValueType)
				{
					if (DynamicFormatter.Instance(innerMemberType).isHasReference)
					{
						size += PtrSize;
					}
					else
					{
						size += Marshal.SizeOf(innerMemberType);
					}
				}
				else
				{
					size += PtrSize;
				}
			}
			return size;
		}

		#endregion constructor

		#region Reflection Helpers

		private bool FindReferenceType()
		{
			var members = _fields;
			foreach (var member in members)
			{
				Type memberType = member.FieldType;

				if (memberType != null)
				{
					if (memberType.IsValueType && memberType.IsPrimitive)
						continue;
					if (!memberType.IsValueType)
					{
						return true;
					}
					else
					{
						if (Instance(memberType).isHasReference)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

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
			Type memberType = _type.GetElementType();
			var serializer = Instance(memberType);
			if (memberType.IsValueType)
			{
				size += serializer._size * array.Length;
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
				if (memberType.IsValueType &&
				(memberType.IsPrimitive || !Instance(memberType).isHasReference))
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
			if (!_type.IsValueType)
			{
				if (referenceMaping.ContainsKey(Entity))
				{
					return referenceMaping[Entity];
				}
			}
			if (_type.IsArray)
			{
				return ArraySerialize(Entity, buffer, referenceMaping);
			}
			int size = _size;
			byte[] current = new byte[size];
			var ptr = buffer.Alloc(size);
			referenceMaping.Add(Entity, ptr);
			int currentPadding = 0;
			foreach (var member in _fields)
			{
				Type memberType = member.FieldType;
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
				if (memberType.IsValueType &&
				(memberType.IsPrimitive || !Instance(memberType).isHasReference))
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
			var elementType = _type.GetElementType();
			Array entity = Array.CreateInstance(elementType, arrayLenght);
			var entitySerializer = Instance(elementType);

			int elementSize = elementType.IsValueType ? entitySerializer._size : PtrSize;

			bufferSize += elementSize * entity.Length;

			sizePtr = buffer.GetPtr(ptr.position, bufferSize);

			byte[] arrayBytes = sizePtr.Read();

			for (int index = 0; index < arrayLenght; index++)
			{
				int positionInByffer = sizeof(int) + (index * elementSize);

				if (elementType.IsValueType &&
				   (elementType.IsPrimitive || !Instance(elementType).isHasReference))
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
						var elementPtr = buffer.GetPtr(elementPosition, entitySerializer._size);
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
			if (_type.IsArray)
			{
				return ArrayDesirialize(ptr, buffer, referenceMaping);
			}
			object entity = FormatterServices.GetSafeUninitializedObject(_type);
			referenceMaping.Add(ptr.position, entity);

			byte[] objectBytes = ptr.Read();
			int bytesRead = 0;
			foreach (var member in _fields)
			{
				Type memberType = member.FieldType;
				if (memberType.IsValueType &&
				   (memberType.IsPrimitive || !Instance(memberType).isHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberType);
					int size = memberType.SizeOfPrimitive();
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
					var Serializer = Instance(memberType);
					var refPtr = buffer.GetPtr(refPosition, Serializer._size);
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

			var rootObject = buffer.GetPtr(0, _size);

			return ReferenceDesirialize(rootObject, buffer, referenceMaping);
		}

		#endregion Desirilization
	}
}