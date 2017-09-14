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
		public unsafe void ConverterTest()
		{
			byte[] buffer = new byte[4];
			int someInt = 20;
			BaseConvertor.Write32(buffer, 0, (byte*)&someInt);
			int result = BitConverter.ToInt32(buffer, 0);
			Assert.AreEqual(someInt, result);

			buffer = new byte[128];
			decimal someDecimal = 503.331M;
			BaseConvertor.Write128(buffer, 0, (byte*)&someDecimal);
			decimal resultDecimal = ToDecimal(buffer);
			//Assert.AreEqual(someDecimal, resultDecimal);

			buffer = new byte[8];
			double somedouble = 503.331;
			BaseConvertor.Write64(buffer, 0, (byte*)&somedouble);
			double resultdouble = BitConverter.ToDouble(buffer, 0);
			Assert.AreEqual(somedouble, resultdouble);

			char someChar = 'y';
			buffer = new byte[8];
			BaseConvertor.Write16(buffer, 0, (byte*)&someChar);
			char resultChar = BitConverter.ToChar(buffer, 0);
			Assert.AreEqual(someChar, resultChar);
		}

		public static decimal ToDecimal(byte[] bytes)
		{
			int[] bits = new int[4];
			bits[0] = ((bytes[0] | (bytes[1] << 8)) | (bytes[2] << 0x10)) | (bytes[3] << 0x18); //lo
			bits[1] = ((bytes[4] | (bytes[5] << 8)) | (bytes[6] << 0x10)) | (bytes[7] << 0x18); //mid
			bits[2] = ((bytes[8] | (bytes[9] << 8)) | (bytes[10] << 0x10)) | (bytes[11] << 0x18); //hi
			bits[3] = ((bytes[12] | (bytes[13] << 8)) | (bytes[14] << 0x10)) | (bytes[15] << 0x18); //flags

			return new decimal(bits);
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
			DynamicFormatter<StrongStructure> formatter = new DynamicFormatter<StrongStructure>();

			var entity = new StrongStructure();

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
