using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using static DynamicFormatter.Models.DynamicBuffer;

namespace DynamicFormatter.Serializers
{
	internal class DynamicFormatter
	{
		#region static instancesBlock

		private static Dictionary<Type, DynamicFormatter> _instances = new Dictionary<Type, DynamicFormatter>();

		public static DynamicFormatter Instance(Type type)
		{
			if (!_instances.ContainsKey(type))
			{
				_instances.Add(type, new DynamicFormatter(type));
			}
			return _instances[type];
		}

		#endregion static instancesBlock

		private static byte[] nullPtrBytres = BitConverter.GetBytes(((short)-1));

		private static int PtrSize = sizeof(short);

		private Func<object, byte[]> _Serialize;

		private Func<byte[], object> _Deserialize;

		private List<MemberInfo> _memberInfo;

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
			if (!_type.IsPrimitive)
			{
				_memberInfo = _type.GetMembers().ToList();
				_memberInfo = _type.GetMembers(
						 BindingFlags.NonPublic |
						 BindingFlags.Public |
						 BindingFlags.Instance)
						 .Where(x => x.MemberType == MemberTypes.Field).ToList();
			}

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
					return bitSerializer.Deserialize(buffer);
				};
			}
			else
			{
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
			foreach (var innerMember in _memberInfo)
			{
				var innerMemberType = GetMemberType(innerMember);
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
			var members = _memberInfo;
			foreach (var member in members)
			{
				Type memberType = GetMemberType(member);

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

		private Type GetMemberType(MemberInfo member)
		{
			Type memberType = null;
			if (member.MemberType == MemberTypes.Field)
			{
				memberType = ((FieldInfo)member).FieldType;
			}
			else if (member.MemberType == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				memberType = propertyInfo.PropertyType;
			}
			return memberType;
		}

		private object GetValue(object entity, MemberInfo member)
		{
			if (member.MemberType == MemberTypes.Field)
			{
				FieldInfo field = (FieldInfo)member;
				return field.GetValue(entity);
			}
			else if (member.MemberType == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				return propertyInfo.GetValue(entity);
			}
			return null;
		}

		private void SetValue(object entity, object value, MemberInfo member)
		{
			if (member.MemberType == MemberTypes.Field)
			{
				FieldInfo field = (FieldInfo)member;
				field.SetValue(entity, value);
			}
			else if (member.MemberType == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				propertyInfo.SetValue(entity, value);
			}
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
			Array.Copy(lenghtBytes, current, lenghtBytes.Length);
			currentPadding += lenghtBytes.Length;
			for (int i = 0; i < array.Length; i++)
			{
				object value = array.GetValue(i);
				if (value == null) //null ptr
				{
					Array.Copy(nullPtrBytres, 0, current, currentPadding, nullPtrBytres.Length);
					currentPadding += nullPtrBytres.Length;
				}
				else if (referenceMaping.ContainsKey(value))
				{
					var objectptr = referenceMaping[value];
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					Array.Copy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				if (memberType.IsValueType &&
				(memberType.IsPrimitive || !Instance(memberType).isHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberType);
					var memberBytes = BitSerializer.Serialize(value);
					Array.Copy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				else
				{
					var objectptr = Instance(memberType).ReferenceSerizlize(value, buffer, referenceMaping);
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					Array.Copy(memberBytes, 0, current, currentPadding, memberBytes.Length);
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
			foreach (var member in _memberInfo)
			{
				Type memberType = GetMemberType(member);
				object value = GetValue(Entity, member);
				if (value == null) //null ptr
				{
					Array.Copy(nullPtrBytres, 0, current, currentPadding, nullPtrBytres.Length);
					currentPadding += nullPtrBytres.Length;
				}
				else if (referenceMaping.ContainsKey(value))
				{
					var objectptr = referenceMaping[value];
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					Array.Copy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				if (memberType.IsValueType &&
				(memberType.IsPrimitive || !Instance(memberType).isHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberType);
					var memberBytes = BitSerializer.Serialize(value);
					Array.Copy(memberBytes, 0, current, currentPadding, memberBytes.Length);
					currentPadding += memberBytes.Length;
					continue;
				}
				else
				{
					var objectptr = Instance(memberType).ReferenceSerizlize(value, buffer, referenceMaping);
					var memberBytes = BitConverter.GetBytes(objectptr.position);
					Array.Copy(memberBytes, 0, current, currentPadding, memberBytes.Length);
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
					Array.Copy(arrayBytes, positionInByffer, memberBuffer, 0, elementSize);
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
			foreach (var member in _memberInfo)
			{
				Type memberType = GetMemberType(member);
				if (memberType.IsValueType &&
				   (memberType.IsPrimitive || !Instance(memberType).isHasReference))
				{
					BitSerializer BitSerializer = BitSerializer.GetInstanse(memberType);
					int size = memberType.SizeOfPrimitive();
					var currentMemberBytes = new byte[size];
					Array.Copy(objectBytes, bytesRead, currentMemberBytes, 0, size);
					bytesRead += size;
					object value = BitSerializer.Deserialize(currentMemberBytes);
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