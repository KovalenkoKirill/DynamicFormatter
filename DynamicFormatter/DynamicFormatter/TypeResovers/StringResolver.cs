using DynamicFormatter.Extentions;
using DynamicFormatter.interfaces;
using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DynamicFormatter.Models.DynamicBuffer;

namespace DynamicFormatter.TypeResovers
{
	internal class StringResolver : ArrayTypeResolver, ITypeResolver
	{
		public StringResolver(TypeInfo typeInfo) : base(typeInfo)
		{
		}

		public new byte[] Serialize(object Entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return Сonstants.nullPtrBytres;
			}
			if (referenceMaping.ContainsKey(Entity))
			{
				var bufferPtr = referenceMaping[Entity];
				return BitConverter.GetBytes(bufferPtr.position);
			}
			byte[] ptrBytes = base.Serialize(Entity, buffer, referenceMaping);
			short ptr = BitConverter.ToInt16(ptrBytes, 0);
			int lenght = BitConverter.ToInt32(buffer.CurrentBuffer, ptr);
			referenceMaping.Add(Entity, buffer.GetPtr(ptr, lenght));
			return ptrBytes;
		}

		public new object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			char[] array = (char[])base.Desirialize(offset, buffer, referenceMaping);
			return new String(array);
		}
	}
}
