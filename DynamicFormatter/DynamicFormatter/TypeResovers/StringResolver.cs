using DynamicFormatter.interfaces;
using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.TypeResovers
{
	internal class StringResolver : ArrayTypeResolver, ITypeResolver
	{
		public StringResolver(TypeInfo typeInfo) : base(typeInfo)
		{
		}

		public new object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			char[] array = (char[])base.Desirialize(offset, buffer, referenceMaping);
			return new String(array);
		}
	}
}
