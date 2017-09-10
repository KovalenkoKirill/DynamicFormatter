using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Extentions
{
	public static class TypeFinder
	{
		static Dictionary<int, Type> types = new Dictionary<int, Type>();

		public static Type FindType(string typeStr)
		{
			Type entityType = null;

			int hashCode = typeStr.GetHashCode();

			if (!types.TryGetValue(hashCode, out entityType))
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
			return entityType;
		}
	}
}
