using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.interfaces
{
	#if DEBUG
	public
#else
	internal
#endif
	interface IResolver<T>
	{
		T instanse(byte[] buffer, int offset);
	}
}
