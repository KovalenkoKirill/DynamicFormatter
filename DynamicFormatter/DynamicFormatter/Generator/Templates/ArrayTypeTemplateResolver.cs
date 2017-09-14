using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Generator.Templates
{
	public partial class ArrayTypeTemplate : ArrayTypeTemplateBase
	{
		public TypeInfo typeInfo;

		public TypeInfo elementInfo;

		public string className;

		public string Prefix;

#if DEBUG
		public
#else
		internal
#endif
		ArrayTypeTemplate(TypeInfo typeInfo)
		{
			this.typeInfo = typeInfo;
			this.elementInfo = TypeInfo.instanse(typeInfo.ElementTypeInfo);
			this.className = $"{elementInfo.Type.Name}ArrayResolver";
			this.Prefix = GetTypePrefix();
		}

		private bool isPrimitive()
		{
			return elementInfo.IsPrimitive ||
					elementInfo.Type == typeof(DateTime) || elementInfo.Type == typeof(Guid);
		}
		private string GetTypePrefix()
		{
			var type = elementInfo.Type;
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
			else if (type == typeof(Guid))
			{
				return "Guid";
			}
			return string.Empty;
		}
	}
}
