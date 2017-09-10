using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DynamicFormatter.Models.DynamicBuffer;

namespace DynamicFormatter.interfaces
{
	internal interface ITypeResolver
	{
		byte[] Serialize(object Entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping);

		object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping);
	}
}
