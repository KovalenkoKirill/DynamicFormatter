using DynamicFormatter.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Assembly
{
#if DEBUG
	public
#else
	internal
#endif
	class DynamicAssembly
	{
		public static DynamicAssembly Assembly
		{
			get
			{
				if(_assembly == null)
				{
					_assembly = new DynamicAssembly(Сonstants.Dynamic_Assembly_Name);
				}
				return _assembly;
			}
		}

		private static DynamicAssembly _assembly;

		private readonly string name;

		public readonly AssemblyBuilder assemblyBuilder;

		public readonly ModuleBuilder moduleBuilder;

		private DynamicAssembly(string name)
		{
			this.name = name;
			this.assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(name), AssemblyBuilderAccess.Run);
			this.moduleBuilder = assemblyBuilder.DefineDynamicModule(name);
		}
	}
}
