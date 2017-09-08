using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DynamicFormatter.Serializers
{ 
	public class StrongTypeFormatter
	{
		Dictionary<int, Type> types = new Dictionary<int, Type>();

		public byte[] Serialize(object entity)
		{
			Type entityType = entity.GetType();

			var serializer = DynamicFormatter.Instance(entityType);
			var entityBytes = serializer.Serialize(entity);

			string typeName = $"{entityType.Assembly.FullName}:{entityType.FullName}";

			var typeNameBytes = Encoding.GetEncoding("utf-8")
										.GetBytes(entityType.FullName);

			var resultSize = typeof(int).SizeOfPrimitive() +
							 typeNameBytes.Length +
							 entityBytes.Length;
			// result buffer
			byte[] result = new byte[resultSize];
			// first mark, size of typeName value
			byte[] sizeOfTypeNameBytes = BitConverter.GetBytes(typeNameBytes.Length);

			// copy size of typeName
			Buffer.BlockCopy(sizeOfTypeNameBytes, 0, result, 0, sizeOfTypeNameBytes.Length);

			int padding = sizeOfTypeNameBytes.Length;

			// copy type name
			Buffer.BlockCopy(typeNameBytes, 0, result, padding, typeNameBytes.Length);

			padding+= typeNameBytes.Length;

			// copy entity
			Buffer.BlockCopy(entityBytes, 0, result, padding, entityBytes.Length);

			return result;
		}

		public object Deserialize(byte[] bytes)
		{
			// get size of type string bytes
			var sizeOftypeLenght = BitConverter.ToInt32(bytes, 0);
			int padding = sizeof(int);
			// buffer for type
			byte[] typeBytes = new byte[sizeOftypeLenght];

			Buffer.BlockCopy(bytes, padding, typeBytes, 0, sizeOftypeLenght);

			padding += sizeOftypeLenght;
			// get type string
			var typeStr = Encoding.GetEncoding("utf-8").GetString(typeBytes);

			// type of entity
			Type entityType = null;

			int hashCode = typeStr.GetHashCode();

			if(!types.TryGetValue(hashCode,out entityType))
			{
				foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
				{
					entityType = assembly.GetType(typeStr, false, true);
					if (entityType != null)
					{
						break;
					}
				}

				if (entityType == null)
				{
					throw new BadImageFormatException($"Type {typeStr} not found");
				}

				types.Add(typeStr.GetHashCode(), entityType);
			}

			// buffer for entity
			byte[] entiyBytes = new byte[bytes.Length - padding];

			Buffer.BlockCopy(bytes, padding, entiyBytes, 0, entiyBytes.Length);

			var instanse = DynamicFormatter.Instance(entityType);

			return instanse.Deserialize(entiyBytes);
		}

	}
}
