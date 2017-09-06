using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DynamicFormatter
{
	internal static class BaseTypeSizeHelper
	{
		static Dictionary<int, int> basedTypeSize = new Dictionary<int, int>();

		static BaseTypeSizeHelper()
		{
			basedTypeSize.Add(typeof(bool).GetHashCode(), sizeof(bool));
			basedTypeSize.Add(typeof(char).GetHashCode(), sizeof(char));
			basedTypeSize.Add(typeof(sbyte).GetHashCode(), sizeof(sbyte));
			basedTypeSize.Add(typeof(short).GetHashCode(), sizeof(short));
			basedTypeSize.Add(typeof(int).GetHashCode(), sizeof(int));
			basedTypeSize.Add(typeof(byte).GetHashCode(), sizeof(byte));
			basedTypeSize.Add(typeof(ushort).GetHashCode(), sizeof(ushort));
			basedTypeSize.Add(typeof(uint).GetHashCode(), sizeof(uint));
			basedTypeSize.Add(typeof(ulong).GetHashCode(), sizeof(ulong));
			basedTypeSize.Add(typeof(float).GetHashCode(), sizeof(float));
			basedTypeSize.Add(typeof(double).GetHashCode(), sizeof(double));
			basedTypeSize.Add(typeof(decimal).GetHashCode(), sizeof(decimal));
		}

		public static int SizeOfPrimitive(this Type type)
		{
			int containsSize;
			if(basedTypeSize.TryGetValue(type.GetHashCode(), out containsSize))
			{
				return containsSize;
			}
			else
			{
				int size = Marshal.SizeOf(type);
				basedTypeSize.Add(type.GetHashCode(), size);
				return size;
			}
		}
	}
}