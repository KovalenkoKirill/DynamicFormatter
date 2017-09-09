using DynamicFormatter.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Models;

namespace UnitTest
{
	[TestClass]
	public class StrongTypeSerialier
	{
		private const int iterationCount = 1000000;

		[TestMethod]
		public void StrongTypeFormatterDateTimeTest()
		{
			var time = DateTime.Now;
			var strongTypeFormatter = new StrongTypeFormatter();
			var buffer = strongTypeFormatter.Serialize(time);
			var resultTime = strongTypeFormatter.Deserialize(buffer);
			Assert.AreEqual(time, resultTime);
		}

		[TestMethod]
		public void StrongTypeFormatterNullableTest()
		{
			Nullable<bool> testEntity = true;
			var strongTypeFormatter = new StrongTypeFormatter();
			var buffer = strongTypeFormatter.Serialize(testEntity);
			var resultEntity = strongTypeFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity, resultEntity);
		}

		[TestMethod]
		public void StrongTypeFormatterNullableWhenNullTest()
		{
			Nullable<bool> testEntity = null;
			try
			{
				var strongTypeFormatter = new StrongTypeFormatter();
				var buffer = strongTypeFormatter.Serialize(testEntity);
				var resultEntity = strongTypeFormatter.Deserialize(buffer);
				Assert.Fail($"Serialize null value");
			}
			catch { }
		}

		[TestMethod]
		public void StrongTypeFormatterNullableStructTest()
		{
			TestStruct? testEntity = new TestStruct()
			{
				B = 50,
				G = 10,
				R = 32
			};
			var strongTypeFormatter = new StrongTypeFormatter();
			var buffer = strongTypeFormatter.Serialize(testEntity);
			var resultEntity = strongTypeFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity, resultEntity);
		}


		[TestMethod]
		public void StrongTypeFormatterDateTimeInClass()
		{
			var firstDate = DateTime.Now;
			var secondDate = DateTime.Now.AddHours(1);
			var strongTypeFormatter = new StrongTypeFormatter();

			var testEntity = new ClassWithDateTime()
			{
				FirstDate = firstDate,
				OtherDate = secondDate
			};

			var buffer = strongTypeFormatter.Serialize(testEntity);
			var resultTime = (ClassWithDateTime)strongTypeFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity.FirstDate, resultTime.FirstDate);
			Assert.AreEqual(testEntity.OtherDate, resultTime.OtherDate);
		}

		[TestMethod]
		public void StrongTypeFormatterPerformanceTest()
		{
			var strongTypeFormatter = new StrongTypeFormatter();
			var testEntity = new ClassForTest();
			var watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				var buffer = strongTypeFormatter.Serialize(testEntity);
				var testEintity = strongTypeFormatter.Deserialize(buffer);
			}
			watch.Stop();
			Debug.WriteLine($"StrongTypeFormatter result {watch.ElapsedMilliseconds} ms.");

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
		public void StrongTypeFormatterClassTest()
		{
			var strongTypeFormatter = new StrongTypeFormatter();
			var testEntity = new ClassForTest();
			var watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				var buffer = strongTypeFormatter.Serialize(testEntity);
				var testEintity = strongTypeFormatter.Deserialize(buffer);
			}
			watch.Stop();
			Debug.WriteLine($"StrongTypeFormatter result {watch.ElapsedMilliseconds} ms.");
		}

		[TestMethod]
		public void StrongTypeFormatterStringTest()
		{
			var strongTypeFormatter = new StrongTypeFormatter();
			var someString = "This is some string";
			var stringBytes = strongTypeFormatter.Serialize(someString);
			var someStringCopy = strongTypeFormatter.Deserialize(stringBytes);
			Assert.AreEqual(someString, someStringCopy);
		}

		[TestMethod]
		public void StrongTypeFormatterStringInClass()
		{
			var strongTypeFormatter = new StrongTypeFormatter();
			var testClass = new ClassWithStrings();
			var classBytes = strongTypeFormatter.Serialize(testClass);
			var testClassCopy = (ClassWithStrings)strongTypeFormatter.Deserialize(classBytes);
			Assert.AreEqual(testClass.someString, testClassCopy.someString);
			Assert.AreEqual(testClass.secondSomeString, testClassCopy.secondSomeString);
		}

		[TestMethod]
		public void StrongTypeFormatterStuctTest()
		{
			var strongTypeFormatter = new StrongTypeFormatter();
			var testEntity = new TestStruct()
			{
				B = 50,
				G = 99,
				R = 1
			};

			var testEntityBytes = strongTypeFormatter.Serialize(testEntity);
			var testEintityResult = strongTypeFormatter.Deserialize(testEntityBytes);
			Assert.AreEqual(testEntity, testEintityResult);
		}
	}
}
