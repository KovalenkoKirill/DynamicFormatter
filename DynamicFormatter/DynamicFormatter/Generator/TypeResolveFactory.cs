using DynamicFormatter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Generator
{
	internal static class TypeResolveFactory
	{
		internal static IResolver<T> GetResolver<T>()
		{
			return null;
		}
	}
}
