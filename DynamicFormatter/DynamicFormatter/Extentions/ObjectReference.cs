using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Extentions
{
	[StructLayoutAttribute(LayoutKind.Explicit)]
#if DEBUG
	public struct ObjectReference
#else
	internal struct ObjectReference
#endif
	{
		[FieldOffset(0)]
		object obj;

		[FieldOffset(0)]
		int ptr;

		public ObjectReference(object obj)
		{
			ptr = -1;
			this.obj = obj;
		}

		public IntPtr GetPtr
		{
			get
			{
				return new IntPtr(ptr);
			}
		}
	}
}
