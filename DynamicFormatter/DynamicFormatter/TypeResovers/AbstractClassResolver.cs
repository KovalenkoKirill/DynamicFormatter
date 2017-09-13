using DynamicFormatter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicFormatter.Models;
using DynamicFormatter.Extentions;
using System.Runtime.Serialization;
using static System.Buffer;
using static DynamicFormatter.Models.DynamicBuffer;
using DynamicFormatter.enums;
using DynamicFormatter.Generator;

namespace DynamicFormatter.TypeResovers
{
	internal class AbstractClassResolver : ITypeResolver
	{
		TypeInfo abstractTypeInfo;

		TypeInfo stringTypeInfo;

		public AbstractClassResolver(TypeInfo typeInfo)
		{
			this.abstractTypeInfo = typeInfo;
			stringTypeInfo = TypeInfo.instanse(typeof(string));
		}

		public object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			short position = (short)offset == 0 ?
							 (short)0 : BitConverter.ToInt16(buffer.CurrentBuffer, offset);

			if (position == -1)
			{
				return null;
			}
			object entity;
			if (referenceMaping.TryGetValue(position, out entity))
			{
				return entity;
			}


			ObjectFlag flag = (ObjectFlag)buffer.CurrentBuffer[position];

			position++;

			#region get info about class

			string typeName = (string)stringTypeInfo.Resolver.Desirialize(position, buffer, referenceMaping);

			position += (short)Сonstants.PtrSize;

			Type currentType = TypeFinder.FindType(typeName);

			TypeInfo typeInfo = TypeInfo.instanse(currentType);

			#endregion

			return TypeResolveFactory.ResolveDesirialize(currentType, position, buffer, referenceMaping);
		}

		public byte[] Serialize(object Entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return Сonstants.nullPtrBytres;
			}
			BufferPtr ptr;
			if (referenceMaping.TryGetValue(Entity, out ptr))
			{
				return BitConverter.GetBytes(ptr.position);
			}
			TypeInfo typeInfo = TypeInfo.instanse(Entity.GetType());

			ptr = buffer.Alloc(abstractTypeInfo.Size);

			byte[] objectBuffer = new byte[abstractTypeInfo.Size];

			objectBuffer[0] = (byte)ObjectFlag.AbstractClass;

			int positionInBuffer = 1;

			#region save information about type in  buffer
			string typeName = Entity.GetType().FullName;

			byte[] pointerToTypeInfo = stringTypeInfo.Resolver.Serialize(typeName, buffer, referenceMaping);

			BlockCopy(pointerToTypeInfo, 0, objectBuffer, positionInBuffer, pointerToTypeInfo.Length);

			positionInBuffer += pointerToTypeInfo.Length;

			#endregion

			// save ptr on instanse
			byte[] instansePtr = typeInfo.Resolver.Serialize(Entity, buffer, referenceMaping);

			BlockCopy(instansePtr, 0, objectBuffer, positionInBuffer, instansePtr.Length);

			ptr.Set(objectBuffer);

			return BitConverter.GetBytes(ptr.position);
		}
	}
}
