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

		public unsafe new byte[] Serialize(object Entity, DynamicBuffer buf, Dictionary<object, BufferPtr> referenceMaping)
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
			int charSize = sizeof(char);
			string entity = (string)Entity;
			int size = charSize * entity.Length + sizeof(int);
			var ptr = buf.Alloc(size);
			byte[] buffer = buf.CurrentBuffer;
			int offset = ptr.position;

			int lenght = entity.Length;

			BaseConvertor.Write32(buffer, offset, (byte*)&lenght);

			offset += sizeof(int);

			fixed (char* str = entity)
			fixed(byte* bufferPtr = buffer)
			{
				int bytesToCopy = charSize * entity.Length;
				Buffer.MemoryCopy(str, bufferPtr + offset, bytesToCopy, bytesToCopy);
			}

			return BitConverter.GetBytes(ptr.position);
		}

		public unsafe new object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			fixed (byte* buf = buffer.CurrentBuffer)
			{
				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
				if (position == -1)
				{
					return null;
				}
				if (referenceMaping.ContainsKey(position))
				{
					return referenceMaping[position];
				}
				int lenght = *(int*)(buf + position);

				fixed (char* charP = new char[lenght])
				{
					int bytesForCopy = sizeof(char) * lenght;
					byte* source = (buf + position + sizeof(int));
					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
					return new String(charP);
				}
			}
		}
	}
}
