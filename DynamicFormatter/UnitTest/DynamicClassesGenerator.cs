using DynamicFormatter;
using DynamicFormatter.Assembly;
using DynamicFormatter.Generator.Templates;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTest.Models;

namespace UnitTest
{
	[TestClass]
	public class DynamicClassesGenerator
	{
	#if DEBUG
		[TestMethod]
		public void ClassGeneratorCompile()
		{
			var result = CompileService.Compile(new List<Type>()
			{
				typeof(JustSimpleClass),
				typeof(SecondSimpleClass)
			}).ToList();

		}
		#endif
	}
}
