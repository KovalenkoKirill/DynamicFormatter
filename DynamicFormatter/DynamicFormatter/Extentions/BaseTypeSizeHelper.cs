using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DynamicFormatter
{
	internal static class BaseTypeSizeHelper
	{
		static Dictionary<Type, int> basedTypeSize = new Dictionary<Type, int>();

		static BaseTypeSizeHelper()
		{
			basedTypeSize.Add(typeof(bool), sizeof(bool));
			basedTypeSize.Add(typeof(char), sizeof(char));
			basedTypeSize.Add(typeof(sbyte), sizeof(sbyte));
			basedTypeSize.Add(typeof(short), sizeof(short));
			basedTypeSize.Add(typeof(int), sizeof(int));
			basedTypeSize.Add(typeof(byte), sizeof(byte));
			basedTypeSize.Add(typeof(ushort), sizeof(ushort));
			basedTypeSize.Add(typeof(uint), sizeof(uint));
			basedTypeSize.Add(typeof(ulong), sizeof(ulong));
			basedTypeSize.Add(typeof(float), sizeof(float));
			basedTypeSize.Add(typeof(double), sizeof(double));
			basedTypeSize.Add(typeof(decimal), sizeof(decimal));
		}

		public static int SizeOfPrimitive(this Type type)
		{
			int containsSize;
			if(basedTypeSize.TryGetValue(type,out containsSize))
			{
				return containsSize;
			}
			else
			{
				int size = Marshal.SizeOf(type);
				basedTypeSize.Add(type, size);
				return size;
			}
		}
	}
}