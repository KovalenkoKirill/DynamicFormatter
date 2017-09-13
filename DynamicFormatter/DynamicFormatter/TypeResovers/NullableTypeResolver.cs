using DynamicFormatter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicFormatter.Models;
using System.Runtime.Serialization;
using DynamicFormatter.enums;
using DynamicFormatter.Generator;

namespace DynamicFormatter.TypeResovers
{
	internal class NullableTypeResolver : ReferenceTypeResolver, ITypeResolver
	{
		TypeInfo typeInfo;

		TypeInfo memberTypeInfo;

		public NullableTypeResolver(TypeInfo typeInfo) : base(typeInfo)
		{
			this.typeInfo = typeInfo;
			this.memberTypeInfo = TypeInfo.instanse(typeInfo.Type.GenericTypeArguments[0]);
		}

		public new object Desirialize(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			short position = (short)offset == 0 ?
							 (short)0 : BitConverter.ToInt16(buffer.CurrentBuffer, offset);

			int positionInBuffer = 0;

			ObjectFlag flag = (ObjectFlag)buffer.CurrentBuffer[offset];

			positionInBuffer++;

			bool isHasValue = BitConverter.ToBoolean(buffer.CurrentBuffer, position + positionInBuffer);

			positionInBuffer++;

			if(isHasValue)
			{
				return TypeResolveFactory.ResolveDesirialize(memberTypeInfo.Type,position + positionInBuffer, buffer, referenceMaping);
			}
			return null;

		}
	}
}
