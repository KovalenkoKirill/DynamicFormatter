using DynamicFormatter;
using DynamicFormatter.Assembly;
using DynamicFormatter.Extentions;
using DynamicFormatter.Generator;
using DynamicFormatter.Generator.Templates;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTest.Models;

namespace UnitTest
{
	[TestClass]
	public class DynamicClassesGenerator
	{
		public TestContext TestContext { get; set; }

#if DEBUG
		[TestMethod]
		public void ClassGeneratorCompile()
		{
			var result = CompileService.Compile(new List<Type>()
			{
				typeof(JustSimpleClass),
				typeof(SecondSimpleClass)
			}).ToList();

			Assert.IsTrue(result.Any());
		}

		[TestMethod]
		public void TypeResolveFactoryTest()
		{
			DynamicFormatter<JustSimpleClass> formatter = new DynamicFormatter<JustSimpleClass>();

			var entity = new JustSimpleClass(10);

			byte[] serializeResult = formatter.Serialize(entity);

			var result = formatter.Deserialize(serializeResult);

			// sleep for waiting compile result
			Thread.Sleep(1500);

			Assert.IsTrue(
				TypeResolveFactory.resolvers.ContainsKey(RuntimeHelpers.GetHashCode(typeof(JustSimpleClass))));

			Assert.IsTrue(
				TypeResolveFactory.resolvers.ContainsKey(RuntimeHelpers.GetHashCode(typeof(SecondSimpleClass))));
		}

		[TestMethod]
		public void TypeResolveFactoryPerformance()
		{
			DynamicFormatter<JustSimpleClass> formatter = new DynamicFormatter<JustSimpleClass>();

			var entity = new JustSimpleClass(10);

			byte[] serializeResult = formatter.Serialize(entity);

			var result = formatter.Deserialize(serializeResult);

			// sleep for waiting compile result
			Thread.Sleep(1500);

			Сonstants.GenerateClass = false;

			var watchStandartDesirialize = Stopwatch.StartNew();

			for(int i = 0;i<1000000;i++)
			{
				var r = formatter.Deserialize(serializeResult);
			}
			watchStandartDesirialize.Stop();

			Сonstants.GenerateClass = true;

			var watchDynamicClassesDesirialize = Stopwatch.StartNew();

			for (int i = 0; i < 1000000; i++)
			{
				var r = formatter.Deserialize(serializeResult);
			}
			watchDynamicClassesDesirialize.Stop();

			var message = $"StandartResult {watchStandartDesirialize.ElapsedMilliseconds} ms\r\nDynamicClassResult {watchDynamicClassesDesirialize.ElapsedMilliseconds} ms";

			Assert.IsTrue(watchDynamicClassesDesirialize.ElapsedTicks < watchStandartDesirialize.ElapsedTicks, message);

			TestContext.WriteLine(message);
		}

#endif
	}
}
