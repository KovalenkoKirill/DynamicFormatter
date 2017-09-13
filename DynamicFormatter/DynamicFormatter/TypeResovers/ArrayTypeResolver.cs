using DynamicFormatter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicFormatter.Models;
using DynamicFormatter.Extentions;
using static System.Buffer;
using DynamicFormatter.enums;
using DynamicFormatter.Generator;

namespace DynamicFormatter.TypeResovers
{
	internal class ArrayTypeResolver : ITypeResolver
	{
		TypeInfo typeInfo;

		TypeInfo memberTypeInfo;

		public ArrayTypeResolver(TypeInfo typeInfo)
		{
			this.typeInfo = typeInfo;
			memberTypeInfo = TypeInfo.instanse(typeInfo.ElementTypeInfo);
		}

		public object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			short position = (short)offset == 0 ?
				 (short)0 : BaseConvertor.GetShort(buffer.CurrentBuffer, offset);

			if (position == -1)
			{
				return null;
			}

			int arrayLenght = BitConverter.ToInt32(buffer.CurrentBuffer, position);

			int padding = sizeof(int);

			var array = Array.CreateInstance(memberTypeInfo.Type, arrayLenght);

			referenceMaping.Add(offset, array);

			var elementSize = memberTypeInfo.SizeInBuffer;

			for(int i = 0; i<arrayLenght ;i++)
			{
				object innerObject = TypeResolveFactory.ResolveDesirialize(memberTypeInfo.Type,position + padding, buffer, referenceMaping);
				array.SetValue(innerObject, i);
				padding += memberTypeInfo.SizeInBuffer;
			}

			return array;

		}

		public byte[] Serialize(object entity, DynamicBuffer buffer, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
		{
			int size = sizeof(int);

			if (entity == null)
			{
				return Сonstants.nullPtrBytres;
			}

			if(referenceMaping.ContainsKey(entity))
			{
				return BitConverter.GetBytes(referenceMaping[entity].position);
			}
			
			if (typeInfo.Type == typeof(string))
			{
				entity = ((string)entity).ToArray();
			}

			Array array = entity as Array;

			var resolver = TypeInfo.instanse(typeInfo.ElementTypeInfo).Resolver;

			size += memberTypeInfo.SizeInBuffer * array.Length;

			byte[] entityBuffer = new byte[size];

			var ptr = buffer.Alloc(size);

			referenceMaping.Add(entity, ptr);


			int positionInBuffer = 0;

			byte[] lenghtBytes = BitConverter.GetBytes(array.Length);

			BlockCopy(lenghtBytes, 0, entityBuffer, 0, lenghtBytes.Length);

			positionInBuffer += lenghtBytes.Length;

			for (int i = 0; i < array.Length; i++)
			{
				object innerObject = array.GetValue(i);

				byte[] InnerObjectBytes = resolver.Serialize(innerObject, buffer, referenceMaping);

				BlockCopy(InnerObjectBytes, 0, entityBuffer, positionInBuffer, InnerObjectBytes.Length);

				positionInBuffer += InnerObjectBytes.Length;
			}

			ptr.Set(entityBuffer);

			return BitConverter.GetBytes(ptr.position);
		}
	}
}
