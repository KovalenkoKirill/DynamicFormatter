using DynamicFormatter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicFormatter.Models;
using static DynamicFormatter.Models.DynamicBuffer;
using DynamicFormatter.Serializers;

namespace DynamicFormatter.TypeResovers
{
	internal class BaseTypeResolver : ITypeResolver
	{
		TypeInfo typeInfo;

		BitSerializer bitSerializer;

		public BaseTypeResolver(TypeInfo typeInfo)
		{
			this.typeInfo = typeInfo;
			this.bitSerializer = BitSerializer.GetInstanse(typeInfo.Type);
		}

		public object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			return bitSerializer.Deserialize(buffer.CurrentBuffer, offset);
		}

		public byte[] Serialize(object Entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping)
		{
			byte[] result = bitSerializer.Serialize(Entity); 
			if (buffer.CurrentPoint == 0)
			{
				buffer.Alloc(result.Count()).Set(result);
			}
			return result;
		}
	}
}
