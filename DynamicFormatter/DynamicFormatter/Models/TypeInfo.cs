using DynamicFormatter.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static DynamicFormatter.Serializers.DynamicFormatter;

namespace DynamicFormatter
{
	internal class TypeInfo
	{
		#region instanse

		private static Dictionary<int, TypeInfo> typeInfoDictionary = new Dictionary<int, TypeInfo>();

		public static TypeInfo instanse(Type type)
		{
			TypeInfo typeInfo = null;
			int hashCode = type.GetHashCode();
			if (!typeInfoDictionary.TryGetValue(type.GetHashCode(), out typeInfo))
			{
				typeInfo = new TypeInfo(type);
				typeInfoDictionary.Add(hashCode, typeInfo);
			}
			return typeInfo;
		}

		#endregion instanse

		#region StaticCounstuctor

		static TypeInfo()
		{
			var typeInfo = new TypeInfo(typeof(string));
			typeInfo._isArrayType = NullableBool.True;
			typeInfo._elementTypeInfo = typeof(char);
			typeInfoDictionary.Add(typeof(string).GetHashCode(), typeInfo);
		}

		#endregion StaticCounstuctor

		#region members

		private Type _type;

		private NullableBool _isPrimitiveType = NullableBool.Unknown;

		private NullableBool _isValueType = NullableBool.Unknown;

		private NullableBool _isArrayType = NullableBool.Unknown;

		private NullableBool _isHasReference = NullableBool.Unknown;

		private NullableBool _isGeneric = NullableBool.Unknown;

		private bool? _isNullable = null;

		private List<FieldInfo> _fields;

		private int _size = -1;

		private Type _elementTypeInfo;

		#endregion members

		#region constructor

		private TypeInfo(Type type)
		{
			this._type = type;
		}

		#endregion constructor

		#region Property

		public Type Type
		{
			get
			{
				return _type;
			}
		}

		public List<FieldInfo> Fields
		{
			get
			{
				if (_fields == null)
				{
					_fields = _type.GetMembers(
						 BindingFlags.NonPublic |
						 BindingFlags.Public |
						 BindingFlags.Instance)
						 .Where(x => x.MemberType == MemberTypes.Field)
						 .Cast<FieldInfo>()
						 .ToList();
				}
				return _fields;
			}
		}

		public bool isNullable
		{
			get
			{
				if(_isNullable == null)
				{
					if(IsValueType && IsGeneric && Type == typeof(Nullable<>))
					{
						_isNullable = true;
					}
					else
					{
						_isNullable = false;
					}
				}
				return (bool)_isNullable;
			}
		}

		public bool IsValueType
		{
			get
			{
				if (_isValueType == NullableBool.Unknown)
				{
					_isValueType = _type.IsValueType ? NullableBool.True : NullableBool.False;
				}
				return _isValueType == NullableBool.True;
			}
		}

		public bool IsArray
		{
			get
			{
				if (_isArrayType == NullableBool.Unknown)
				{
					_isArrayType = _type.IsArray ? NullableBool.True : NullableBool.False;
				}
				return _isArrayType == NullableBool.True;
			}
		}

		public bool IsPrimitive
		{
			get
			{
				if (_isPrimitiveType == NullableBool.Unknown)
				{
					_isPrimitiveType = _type.IsPrimitive ? NullableBool.True : NullableBool.False;
				}
				return _isPrimitiveType == NullableBool.True;
			}
		}

		public bool IsHasReference
		{
			get
			{
				if (_isHasReference == NullableBool.Unknown)
				{
					_isHasReference = FindReferenceType() ? NullableBool.True : NullableBool.False;
				}
				return _isHasReference == NullableBool.True;
			}
		}

		public int Size
		{
			get
			{
				if (_size < 0)
				{
					_size = GetSize();
				}
				return _size;
			}
		}

		public bool IsGeneric
		{
			get
			{
				if (_isGeneric == NullableBool.Unknown)
				{
					_isGeneric = _type.IsGenericType ? NullableBool.True : NullableBool.False;
				}
				return _isGeneric == NullableBool.True;
			}
		}

		public Type ElementTypeInfo
		{
			get
			{
				if (_elementTypeInfo == null)
				{
					_elementTypeInfo = Type.GetElementType();
				}
				return _elementTypeInfo;
			}
		}

		#endregion Property

		#region Method

		private bool FindReferenceType()
		{
			var members = Fields;
			foreach (var member in members)
			{
				Type memberType = member.FieldType;

				if (memberType != null)
				{
					var typeInfo = instanse(memberType);
					if (typeInfo.IsValueType && typeInfo.IsPrimitive)
						continue;
					if (!memberType.IsValueType || memberType.IsGenericType)
					{
						return true;
					}
					else
					{
						if (typeInfo.IsHasReference)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetSize()
		{
			int size = 0;
			if (IsPrimitive)
			{
				return _type.SizeOfPrimitive();
			}
			else if (IsArray)
			{
				return PtrSize;
			}
			foreach (var innerMember in _fields)
			{
				var innerMembreTypeInfo = instanse(innerMember.FieldType);
				if (innerMembreTypeInfo.IsPrimitive)
				{
					size += innerMembreTypeInfo.Type.SizeOfPrimitive();
				}
				else if (innerMembreTypeInfo.IsValueType)
				{
					if (innerMembreTypeInfo.IsHasReference)
					{
						size += PtrSize;
					}
					else
					{
						size += innerMembreTypeInfo.Type.SizeOfPrimitive();
					}
				}
				else
				{
					size += PtrSize;
				}
			}
			return size;
		}

		public override int GetHashCode()
		{
			return _type.GetHashCode();
		}

		#endregion Method
	}
}