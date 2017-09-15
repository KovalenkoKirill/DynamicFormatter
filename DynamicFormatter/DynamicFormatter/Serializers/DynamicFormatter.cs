using DynamicFormatter.Generator;
using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using static DynamicFormatter.Models.DynamicBuffer;
using static DynamicFormatter.ReflectionUtils;
using static System.Buffer;

namespace DynamicFormatter.Serializers
{
	internal class DynamicFormatter
	{
		#region Instanse

		private static Dictionary<int, DynamicFormatter> _instances = new Dictionary<int, DynamicFormatter>();

		public static DynamicFormatter Instance(Type type)
		{
			DynamicFormatter instanse;
			int hash = RuntimeHelpers.GetHashCode(type);
			if (!_instances.TryGetValue(hash, out instanse))
			{
				instanse = new DynamicFormatter(type);
				_instances.Add(hash, instanse);
			}
			return instanse;
		}

		#endregion

		#region Fields


		private TypeInfo _typeInfo;

		#endregion Fields

		#region Constructors

		private DynamicFormatter(Type type)
		{
			_typeInfo = TypeInfo.instanse(type);
		}


		#endregion Constructors

		#region Methods


		public object Deserialize(byte[] buffer)
		{
			if(buffer.Length == 0)
			{
				return null;
			}
			var referenceMaping = new Dictionary<int, object>();
			var dynamicBuffer = new DynamicBuffer(buffer);
			
			return TypeResolveFactory.ResolveDesirialize(_typeInfo.Type,
												 0,
												 dynamicBuffer,
												 referenceMaping);
		}

		public byte[] Serialize(object entity)
		{
			var referenceMaping = new Dictionary<object, BufferPtr>();
			var dynamicBuffer = new DynamicBuffer(_typeInfo.Size * 2);
			_typeInfo.Resolver.Serialize(entity, dynamicBuffer, referenceMaping);
			TypeResolveFactory.ResolveSerialize(_typeInfo.Type,
												 entity,
												 dynamicBuffer,
												 referenceMaping);
			return dynamicBuffer.Buffer;
		}

		#endregion Methods
	}
}