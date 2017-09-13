using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Extentions
{
#if DEBUG
	public
#else
	internal
#endif
	static class Сonstants
	{
		public const string Dynamic_Assembly_Name = "DynamicFormatter.Dynamic";

		public static readonly int PtrSize = sizeof(short);

		public static readonly byte[] nullPtrBytres = BitConverter.GetBytes(((short)-1));

		public static bool GenerateClass = true;
	}
}
