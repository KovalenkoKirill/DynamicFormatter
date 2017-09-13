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
	internal class ReferenceTypeResolver : ITypeResolver
	{
		TypeInfo typeInfo;


		public ReferenceTypeResolver(TypeInfo typeInfo)
		{
			this.typeInfo = typeInfo;
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
			else
			{
				entity = FormatterServices.GetSafeUninitializedObject(typeInfo.Type);
			}
			referenceMaping.Add(position, entity);

			ObjectFlag flag = (ObjectFlag)buffer.CurrentBuffer[offset];

			position++;

			foreach (var member in typeInfo.Fields)
			{
				var memberTypeInfo = TypeInfo.instanse(member.FieldType);
				object innerObject = TypeResolveFactory.ResolveDesirialize(member.FieldType, position, buffer, referenceMaping);
				entity = typeInfo.SetValue(entity, innerObject, member);
				position += (short)memberTypeInfo.SizeInBuffer;
			}
			return entity;
		}

		public byte[] Serialize(object Entity, DynamicBuffer buffer, Dictionary<object, BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return Сonstants.nullPtrBytres;
			}
			BufferPtr ptr;
			if (referenceMaping.TryGetValue(Entity,out ptr))
			{
				return BitConverter.GetBytes(ptr.position);
			}
			ptr = buffer.Alloc(typeInfo.Size);

			byte[] objectBuffer = new byte[typeInfo.Size];

			objectBuffer[0] = (byte)ObjectFlag.Normal;

			referenceMaping.Add(Entity, ptr);

			int positionInBuffer = 1;


			foreach (var member in typeInfo.Fields)
			{
				var memberTypeInfo = TypeInfo.instanse(member.FieldType);

				object innerObject = typeInfo.GetValue(Entity, member);

				byte[] InnerObjectBytes = memberTypeInfo.Resolver.Serialize(innerObject, buffer, referenceMaping);

				BlockCopy(InnerObjectBytes, 0, objectBuffer, positionInBuffer, InnerObjectBytes.Length);

				positionInBuffer += InnerObjectBytes.Length;
			}

			ptr.Set(objectBuffer);

			return BitConverter.GetBytes(ptr.position);
		}
	}
}
