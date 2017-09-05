using DynamicFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnitTest.Models;

namespace UnitTest
{
	[TestClass]
	public class SerializerTest
	{
		private const int iterationCount = 1000000;

		[TestMethod]
		public void DynamicFormatterTest()
		{
			var DynamicFormatter = new DynamicFormatter<ClassForTest>();
			var testEntity = new ClassForTest();
			var buffer = DynamicFormatter.Serialize(testEntity);
			var testEintity = DynamicFormatter.Deserialize(buffer);
		}

		[TestMethod]
		public void DynamicFormatterBaseTypeTest()
		{
			var DynamicFormatter = new DynamicFormatter<int>();
			var testEntity = 50;
			var watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				var buffer = DynamicFormatter.Serialize(testEntity);
				var testEintity = DynamicFormatter.Deserialize(buffer);
			}
			watch.Stop();
			Debug.WriteLine($"DynamicSerialize result {watch.ElapsedMilliseconds} ms.");

			BinaryFormatter binary = new BinaryFormatter();
			watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				using (MemoryStream mStream = new MemoryStream())
				{
					binary.Serialize(mStream, testEntity);
					mStream.Position = 0;
					var testEintity = binary.Deserialize(mStream);
				}
			}
			watch.Stop();
			Debug.WriteLine($"BinarySerializer result {watch.ElapsedMilliseconds} ms.");
		}

		[TestMethod]
		public void DynamicFormatterClassTest()
		{
			var DynamicFormatter = new DynamicFormatter<ClassForTest>();
			var testEntity = new ClassForTest();
			var watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				var buffer = DynamicFormatter.Serialize(testEntity);
				var testEintity = DynamicFormatter.Deserialize(buffer);
			}
			watch.Stop();
			Debug.WriteLine($"DynamicSerialize result {watch.ElapsedMilliseconds} ms.");
		}

		[TestMethod]
		public void DynamicFormatterStuctTest()
		{
			var DynamicFormatter = new DynamicFormatter<TestStruct>();
			var testEntity = new TestStruct()
			{
				B = 50,
				G = 99,
				R = 1
			};

			var watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				var buffer = DynamicFormatter.Serialize(testEntity);
				var testEintity = DynamicFormatter.Deserialize(buffer);
			}
			watch.Stop();
			Debug.WriteLine($"DynamicSerialize result {watch.ElapsedMilliseconds} ms.");

			BinaryFormatter binary = new BinaryFormatter();
			watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				using (MemoryStream mStream = new MemoryStream())
				{
					binary.Serialize(mStream, testEntity);
					mStream.Position = 0;
					var testEintity = binary.Deserialize(mStream);
				}
			}
			watch.Stop();
			Debug.WriteLine($"BinarySerializer result {watch.ElapsedMilliseconds} ms.");
		}
	}
}