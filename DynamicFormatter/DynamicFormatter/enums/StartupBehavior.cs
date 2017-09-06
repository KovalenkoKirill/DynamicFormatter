using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.enums
{
	public enum StartupBehavior
	{
		/// <summary>
		/// initialize inner classes serializers when invoked serilization
		/// </summary>
		Default,
		/// <summary>
		/// initialize inner classes serializers when invoked constuctor
		/// </summary>
		InnerClassesOnly
	}
}
