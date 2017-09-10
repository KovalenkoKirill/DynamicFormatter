using DynamicFormatter.enums;
using DynamicFormatter.Extentions;
using DynamicFormatter.interfaces;
using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static DynamicFormatter.Serializers.DynamicFormatter;
using static DynamicFormatter.ReflectionUtils;
using DynamicFormatter.TypeResovers;

namespace DynamicFormatter
{
	internal class TypeInfo
	{
		#region instanse

		private static Dictionary<int, TypeInfo> typeInfoDictionary = new Dictionary<int, TypeInfo>();

		public static TypeInfo instanse(Type type)
		{
			TypeInfo typeInfo = null;
			int hashCode = RuntimeHelpers.GetHashCode(type);
			if (!typeInfoDictionary.TryGetValue(hashCode, out typeInfo))
			{
				typeInfo = new TypeInfo(type);
				typeInfoDictionary.Add(hashCode, typeInfo);
			}
			return typeInfo;
		}

		#endregion instanse

		#region StaticConstuctor

		static TypeInfo()
		{
			// hack for string
			var typeInfo = new TypeInfo(typeof(string));
			typeInfo._isArrayType = NullableBool.True;
			typeInfo._elementTypeInfo = typeof(char);
			typeInfo._resolver = new StringResolver(typeInfo);
			typeInfoDictionary.Add(RuntimeHelpers.GetHashCode(typeof(string)), typeInfo);

			// dateTime
			var dateTime = new TypeInfo(typeof(DateTime));
			dateTime._size = sizeof(long);
			typeInfoDictionary.Add(RuntimeHelpers.GetHashCode(typeof(DateTime)), dateTime);
		}

		#endregion StaticCounstuctor

		#region members

		private Dictionary<int, GetterAndSetter> _accessMethods;

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

		private bool? _isEnum;

		private ITypeResolver _resolver;

		private bool? _isAbstactClass;

		#endregion members

		#region constructor

		private TypeInfo(Type type)
		{
			this._type = type;
			if(IsPrimitive || IsEnum)
			{
				_resolver = new BaseTypeResolver(this);
			}
			else if(!isNullable 
				&& !IsArray 
				&& IsValueType
				&& !IsGeneric
				&& !IsHasReference)
			{
				_resolver = new BaseTypeResolver(this);
			}
			else if(IsArray)
			{
				_resolver = new ArrayTypeResolver(this);
			}
			else if(IsAbstactClass)
			{
				_resolver = new AbstractClassResolver(this);
			}
			else
			{
				initAccessField();
				if (isNullable)
				{
					_resolver = new NullableTypeResolver(this);
				}
				else
				{
					_resolver = new ReferenceTypeResolver(this);
				}
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void initAccessField()
		{
			_accessMethods = new Dictionary<int, GetterAndSetter>();
			foreach (var field in Fields)
			{
				if (IsValueType)
				{
					_accessMethods.Add(RuntimeHelpers.GetHashCode(field),
					new GetterAndSetter()
					{
						Getter = CreateInstanceFieldGetter(field),
						SetterForValueType = CreateInstanceFieldSetterForValueType(field)
					});
				}
				else
				{
					_accessMethods.Add(RuntimeHelpers.GetHashCode(field),
					new GetterAndSetter()
					{
						Getter = CreateInstanceFieldGetter(field),
						Setter = CreateInstanceFieldSetter(field)
					});
				}
			}
		}

		#endregion constructor

		#region Property


		public ITypeResolver Resolver
		{
			get
			{
				return _resolver;
			}
		}

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

		public bool IsAbstactClass
		{
			get
			{
				if(_isAbstactClass == null)
				{
					_isAbstactClass = _type.IsAbstract;
				}
				return (bool)_isAbstactClass;
			}
		}

		public bool IsEnum
		{
			get
			{
				if(_isEnum == null)
				{
					_isEnum = Type.IsEnum;
				}
				return (bool)_isEnum;
			}
		}

		public bool isNullable
		{
			get
			{
				if(_isNullable == null)
				{
					if(IsValueType && IsGeneric && Type.GetGenericTypeDefinition() == typeof(Nullable<>))
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

		public int SizeInBuffer
		{
			get
			{
				if(!IsValueType)
				{
					return Сonstants.PtrSize;
				}
				if (IsPrimitive
				||
				(IsValueType && !IsGeneric
				&& (!IsHasReference && !isNullable)))
				{
					return Size;
				}
				return Сonstants.PtrSize;
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

		#region FieldAccess

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal object GetValue(object entity, FieldInfo member)
		{
			return _accessMethods[RuntimeHelpers.GetHashCode(member)].Getter.Invoke(entity);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal object SetValue(object entity, object value, FieldInfo member)
		{
			if (!IsValueType)
			{
				_accessMethods[RuntimeHelpers.GetHashCode(member)].Setter.Invoke(entity, value);
				return entity;
			}
			else
			{
				return _accessMethods[RuntimeHelpers.GetHashCode(member)].SetterForValueType.Invoke(entity, value);
			}
		}

		#endregion


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetSize()
		{
			int size = 0;
			if(IsPrimitive || IsEnum)
			{
				return _type.SizeOfPrimitive();
			}
			if (IsAbstactClass)
			{
				return size = 1 + (Сonstants.PtrSize * 2);
			}
			else if (!IsHasReference 
					&& IsValueType 
					&& !isNullable
					&& !IsGeneric)
			{
				return Marshal.SizeOf(_type);
			}
			size++;
			foreach(var innerMember in _fields)
			{
				var innerMembreTypeInfo = instanse(innerMember.FieldType);
				size += innerMembreTypeInfo.SizeInBuffer;
			}
			return size;
		}

		public override int GetHashCode()
		{
			return RuntimeHelpers.GetHashCode(_type);
		}

		#endregion Method
	}
}