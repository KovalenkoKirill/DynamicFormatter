using DynamicFormatter.Assembly;
using DynamicFormatter.interfaces;
using DynamicFormatter.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DynamicFormatter.Extentions.Сonstants;

namespace DynamicFormatter.Generator
{
	public static class TypeResolveFactory
	{
		#if DEBUG
		public
		#else
		private
		#endif
		static ConcurrentDictionary<int,DynamicClassResolver> resolvers = new ConcurrentDictionary<int, DynamicClassResolver>();

		private static HashSet<int> inTask = new HashSet<int>();

		private static volatile bool started = false;

		public static object ResolveDesirialize(Type type,int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			// non dynamic class logic
			if (!GenerateClass)
			{
				var typeInfo = TypeInfo.instanse(type);
				return typeInfo.Resolver.Desirialize(offset, buffer, referenceMaping);
			}

			DynamicClassResolver resolver;
			int hash = RuntimeHelpers.GetHashCode(type);
			if (!resolvers.TryGetValue(hash, out resolver))
			{
				var typeInfo = TypeInfo.instanse(type);
					// task for generate resolver
					if (!inTask.Contains(hash) && !started)
					{
					started = true;
						Task.Factory.StartNew(() => {
						GenerateClasses(typeInfo);
					});
					}
				return typeInfo.Resolver.Desirialize(offset, buffer, referenceMaping);
			}
			return resolver.desirializeService(offset, buffer, referenceMaping);
		}

		/// <summary>
		/// Not critical perfomence thread.
		/// </summary>
		/// <param name="typeInfo"></param>
		public static void GenerateClasses(TypeInfo typeInfo)
		{
			try
			{
				inTask.Add(RuntimeHelpers.GetHashCode(typeInfo.Type));
				List<Type> treeTypes = typeInfo.GetChild();
				treeTypes.Add(typeInfo.Type);
				foreach (var child in treeTypes)
				{
					inTask.Add(RuntimeHelpers.GetHashCode(child));
				}
				var result = CompileService.Compile(treeTypes);
				foreach (var resolver in result)
				{
					resolvers.TryAdd(RuntimeHelpers.GetHashCode(resolver.type), resolver);
				}
				foreach (var child in treeTypes)
				{
					inTask.Remove(RuntimeHelpers.GetHashCode(child));
				}
			}
			finally
			{
				started = false;
			}
		}
	}
}