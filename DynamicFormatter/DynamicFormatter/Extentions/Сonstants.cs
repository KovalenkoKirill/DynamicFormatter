﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Extentions
{
	internal static class Сonstants
	{
		public static readonly int PtrSize = sizeof(short);

		public static readonly byte[] nullPtrBytres = BitConverter.GetBytes(((short)-1));

	}
}
