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
using System.Threading.Tasks;
using UnitTest.Models;

namespace UnitTest
{
	[TestClass]
	public class DynamicClassesGenerator
	{
		[TestMethod]
		public void ClassGeneratorGenerate()
		{
			var typeInfo = TypeInfo.instanse(typeof(JustSimpleClass));
			var template = new ReferenceTypeTemplate(typeInfo);
			var text = template.TransformText();
			var assembly = DynamicAssembly.Assembly;

			var typeBuilder = assembly.moduleBuilder.DefineType("dsdfs", System.Reflection.TypeAttributes.Class);

			Func<byte[], int, object> result = null;

			CSharpCodeProvider codeProvider = new CSharpCodeProvider();
			CompilerParameters parameters = new CompilerParameters();
			parameters.GenerateInMemory = true;
			parameters.ReferencedAssemblies.Add("UnitTest.dll");
			parameters.ReferencedAssemblies.Add("DynamicFormatter.dll");
			parameters.OutputAssembly = "DynamicFormatter.Dynamic";
			CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, text);
			object obj = results.CompiledAssembly.CreateInstance("DynamicFormatter.Dynamic.JustSimpleClass");
			var method = obj.GetType().GetMethod("instanse");
			result = (Func<byte[], int, object>)Delegate.CreateDelegate(typeof(Func<byte[], int, object>), obj, method);

			DynamicFormatter<JustSimpleClass> formatter = new DynamicFormatter<JustSimpleClass>();
			var bytes = formatter.Serialize(new JustSimpleClass() { });

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < 1000000; i++)
			{
				JustSimpleClass resultEntity = (JustSimpleClass)result.Invoke(bytes, 0);
			}

			watch.Stop();
			var watc2 = Stopwatch.StartNew();
			for (int i = 0; i < 1000000; i++)
			{
				JustSimpleClass resultEntity = (JustSimpleClass)formatter.Deserialize(bytes);
			}
			watc2.Stop();
		}
	}
}
