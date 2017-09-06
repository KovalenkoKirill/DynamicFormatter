using DynamicFormatter.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DynamicFormatter.Serializers.DynamicFormatter;

namespace DynamicFormatter.Extentions
{
	internal class TypeInfo
	{
	#region instanse
		static Dictionary<int, TypeInfo> typeInfoDictionary = new Dictionary<int, TypeInfo>();

		public static TypeInfo instanse(Type type)
		{
			TypeInfo typeInfo = null;
			int hashCode = type.GetHashCode();
			if (!typeInfoDictionary.TryGetValue(type.GetHashCode(),out typeInfo))
			{
				typeInfo = new TypeInfo(type);
				typeInfoDictionary.Add(hashCode, typeInfo);
			}
			return typeInfo;
		}
		#endregion

		#region members

		Type _type;

		NullableBool _isPrimitiveType = NullableBool.Unknown;

		NullableBool _isValueType = NullableBool.Unknown;

		NullableBool _isArrayType = NullableBool.Unknown;

		NullableBool _isHasReference = NullableBool.Unknown;

		private List<FieldInfo> _fields;

		int _size = -1;

		#endregion

		#region constructor
		private TypeInfo(Type type) 
		{
			this._type = type;
		}
		#endregion

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

		public bool IsValueType
		{
			get
			{
				if(_isValueType == NullableBool.Unknown)
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
				if(_size < 0)
				{
					_size = GetSize();
				}
				return _size;
			}
		}

		#endregion

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
					if (!memberType.IsValueType)
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
						size += Marshal.SizeOf(innerMembreTypeInfo.Type);
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
		#endregion
	}
}
