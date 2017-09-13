using DynamicFormatter.Extentions;
using DynamicFormatter.Generator.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Generator.Templates
{
	public partial class ReferenceTypeTemplate : ReferenceTypeTemplateBase
	{
		public TypeInfo typeInfo;

		public string className;

		public List<Type> referenceFields = new List<Type>();
#if DEBUG
		public
#else
	internal
#endif
		ReferenceTypeTemplate(TypeInfo typeInfo)
		{
			this.typeInfo = typeInfo;
			this.className = typeInfo.Type.Name;
			foreach (var fiels in typeInfo.Fields)
			{
				var fieldInfo = TypeInfo.instanse(fiels.FieldType);
				if (!fieldInfo.IsValueType && !fieldInfo.IsHasReference)
				{
					referenceFields.Add(fieldInfo.Type);
				}
			}
		}

		private bool isPrimitive(FieldInfo field)
		{
			var typeInfo = TypeInfo.instanse(field.FieldType);
			return typeInfo.IsPrimitive;
		}

		public bool isPrivate(FieldInfo field)
		{
			return field.Attributes == FieldAttributes.Private;
		}

		public bool InStackMemeber(FieldInfo field)
		{
			var typeInfo = TypeInfo.instanse(field.FieldType);
			if(typeInfo.IsValueType && !typeInfo.IsHasReference)
			{
				return true;
			}
			return false;
		}

		public int GetHash(FieldInfo field)
		{
			return RuntimeHelpers.GetHashCode(field);
		}

		/// <summary>
		/// Validate for property
		/// </summary>
		/// <param name="field"></param>
		/// <returns></returns>
		private string ValidateName(FieldInfo field)
		{
			return field.Name.Replace("<", "").Replace(">", "");
		}


		private string FieldFullName(FieldInfo field)
		{
			var typeInfo = TypeInfo.instanse(field.FieldType);
			if (typeInfo.isNullable)
			{
				var memberType = typeInfo.Type.GenericTypeArguments[0];
				return $"{memberType.FullName}?";
			}
			return field.FieldType.FullName;
		}

		private string GetTypePrefix(FieldInfo field)
		{
			var type = field.FieldType;
			if (type == typeof(bool))
			{
				return "Bool";
			}
			else if (type == typeof(char))
			{
				return "Char";
			}
			else if (type == typeof(sbyte))
			{
				return "Sbyte"; ;
			}
			else if (type == typeof(short))
			{
				return "Short";
			}
			else if (type == typeof(int) || type.IsEnum)
			{
				return "Int";
			}
			else if (type == typeof(long))
			{
				return "Long";
			}
			else if (type == typeof(byte))
			{
				return "Byte";
			}
			else if (type == typeof(ushort))
			{
				return "Ushort";
			}
			else if (type == typeof(uint))
			{
				return "Uint";
			}
			else if (type == typeof(ulong))
			{
				return "Ulong";
			}
			else if (type == typeof(float))
			{
				return "Float";
			}
			else if (type == typeof(double))
			{
				return "Double";
			}
			else if (type == typeof(decimal))
			{
				return "Decimal";
			}
			else if (type == typeof(DateTime))
			{
				return "Date";
			}
			throw new Exception($"Unknown type {type.Name}");
		}
		private string GetSizeInBuffer(FieldInfo field)
		{
			var typeInfo = TypeInfo.instanse(field.FieldType);
			return typeInfo.SizeInBuffer.ToString();
		}
	}
}
