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
using static DynamicFormatter.Models.DynamicBuffer;

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
			var hash = RuntimeHelpers.GetHashCode(type);
			return ResolveDesirialize(hash, offset, buffer, referenceMaping);
		}

		public static object ResolveDesirialize(int hashOfType, int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			var typeInfo = TypeInfo.instanse(hashOfType);
			// non dynamic class logic
			if (!GenerateClass)
			{
				return typeInfo.Resolver.Desirialize(offset, buffer, referenceMaping);
			}

			DynamicClassResolver resolver;
			if (!resolvers.TryGetValue(hashOfType, out resolver))
			{
				// task for generate resolver
				if (typeInfo.IsCanGenerate && !inTask.Contains(hashOfType) && !started)
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

		public static byte[] ResolveSerialize(Type type, object Entity, DynamicBuffer buff, Dictionary<object, BufferPtr> referenceMaping)
		{
			var hash = RuntimeHelpers.GetHashCode(type);
			return ResolveSerialize(hash, Entity, buff, referenceMaping);
		}

		public static byte[] ResolveSerialize(int hashType, object Entity, DynamicBuffer buff, Dictionary<object, BufferPtr> referenceMaping)
		{
			var typeInfo = TypeInfo.instanse(hashType);
			// non dynamic class logic
			if (!GenerateClass)
			{
				return typeInfo.Resolver.Serialize(Entity, buff, referenceMaping);
			}

			DynamicClassResolver resolver;
			if (!resolvers.TryGetValue(hashType, out resolver))
			{
				// task for generate resolver
				if (typeInfo.IsCanGenerate && !inTask.Contains(hashType) && !started)
				{
					started = true;
					Task.Factory.StartNew(() => {
						GenerateClasses(typeInfo);
					});
				}
				return typeInfo.Resolver.Serialize(Entity, buff, referenceMaping);
			}
			return resolver.serializeService(Entity, buff, referenceMaping);
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