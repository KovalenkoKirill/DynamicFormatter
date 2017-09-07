using DynamicFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
		public void DynamicFormatterDateTimeTest()
		{
			var time = DateTime.Now;
			var DynamicFormatter = new DynamicFormatter<DateTime>();
			var buffer = DynamicFormatter.Serialize(time);
			var resultTime = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(time, resultTime);
		}

		[TestMethod]
		public void DynamicFormatterDateTimeInClass()
		{
			var firstDate = DateTime.Now;
			var secondDate = DateTime.Now.AddHours(1);
			var DynamicFormatter = new DynamicFormatter<ClassWithDateTime>();

			var testEntity = new ClassWithDateTime()
			{
				FirstDate = firstDate,
				OtherDate = secondDate
			};

			var buffer = DynamicFormatter.Serialize(testEntity);
			var resultTime = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity.FirstDate, resultTime.FirstDate);
			Assert.AreEqual(testEntity.OtherDate, resultTime.OtherDate);
		}

		[TestMethod]
		public void DynamicFormatterPerformanceTest()
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
		public void DynamicFormatterStringTest()
		{
			var DynamicFormatter = new DynamicFormatter<string>();
			var someString = "This is some string";
			var stringBytes = DynamicFormatter.Serialize(someString);
			var someStringCopy = DynamicFormatter.Deserialize(stringBytes);
			Assert.AreEqual(someString, someStringCopy);
		}

		[TestMethod]
		public void DynamicFormatterStringInClass()
		{
			var DynamicFormatter = new DynamicFormatter<ClassWithStrings>();
			var testClass = new ClassWithStrings();
			var classBytes = DynamicFormatter.Serialize(testClass);
			var testClassCopy = DynamicFormatter.Deserialize(classBytes);
			Assert.AreEqual(testClass.someString, testClassCopy.someString);
			Assert.AreEqual(testClass.secondSomeString, testClassCopy.secondSomeString);
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

			var testEntityBytes = DynamicFormatter.Serialize(testEntity);
			var testEintityResult = DynamicFormatter.Deserialize(testEntityBytes);
			Assert.AreEqual(testEntity, testEintityResult);
		}
	}
}