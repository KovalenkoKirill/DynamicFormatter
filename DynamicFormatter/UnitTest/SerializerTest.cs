using DynamicFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using UnitTest.Models;

namespace UnitTest
{
	[TestClass]
	public class SerializerTest
	{
		private const int iterationCount = 1000000;

		[TestMethod]
		public void DynamicFormatterDictionary()
		{
			var entity = new Dictionary<int, int>();
			entity.Add(10, 9);
			entity.Add(50, 12);

			var DynamicFormatter = new DynamicFormatter<Dictionary<int, int>>();
			var buffer = DynamicFormatter.Serialize(entity);
			var result = DynamicFormatter.Deserialize(buffer);
			foreach(var keyValue in entity)
			{
				Assert.AreEqual(keyValue.Value, result[keyValue.Key]);
			}
		}

		[TestMethod]
		public void DynamicFormatterGenericInt()
		{
			var entity = new int[]
			{
				10,
				20,
				30
			}.ToList();

			var DynamicFormatter = new DynamicFormatter<List<int>>();
			var buffer = DynamicFormatter.Serialize(entity);
			var result = DynamicFormatter.Deserialize(buffer);
			for(int i = 0; i < entity.Count;i++)
			{
				Assert.AreEqual(result[i], entity[i]);
			}
		}

		[TestMethod]
		public void DynamicFormatterGenericClass()
		{
			var entity = new ClassWithNullable[]
			{
				new ClassWithNullable(),
				new ClassWithNullable(),
				new ClassWithNullable()
			}.ToList();

			var DynamicFormatter = new DynamicFormatter<List<ClassWithNullable>>();
			var buffer = DynamicFormatter.Serialize(entity);
			var result = DynamicFormatter.Deserialize(buffer);
			for (int i = 0; i < entity.Count; i++)
			{
				Assert.AreEqual(result[i].longNullable, entity[i].longNullable);
			}
		}

		[TestMethod]
		public void DynamicFormatterClassWithNullableTest()
		{
			var entity = new ClassWithNullable();
			entity.intNullable = 31;
			entity.longNullable = 313;
			var DynamicFormatter = new DynamicFormatter<ClassWithNullable>();
			var buffer = DynamicFormatter.Serialize(entity);
			var result = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(entity.intNullable, result.intNullable);
			Assert.AreEqual(entity.longNullable, result.longNullable);
			Assert.IsTrue(result.boolNulable == null);
		}

		[TestMethod]
		public void DynamicFormatterEnumTest()
		{
			var enumVal = TestEnum.second;
			var DynamicFormatter = new DynamicFormatter<TestEnum>();
			var buffer = DynamicFormatter.Serialize(enumVal);
			var resultTime = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(enumVal, resultTime);
		}

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
		public void DynamicFormatterNullableTest()
		{
			Nullable<bool> testEntity = true;
			var DynamicFormatter = new DynamicFormatter<bool?>();
			var buffer = DynamicFormatter.Serialize(testEntity);
			var resultEntity = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity, resultEntity);
		}

		[TestMethod]
		public void DynamicFormatterNullableWhenNullTest()
		{
			Nullable<bool> testEntity = null;
			var DynamicFormatter = new DynamicFormatter<bool?>();
			var buffer = DynamicFormatter.Serialize(testEntity);
			var resultEntity = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity, resultEntity);
		}

		[TestMethod]
		public void DynamicFormatterNullableStructTest()
		{
			TestStruct? testEntity = new TestStruct()
			{
				B = 50,
				G = 10,
				R = 32
			};
			var DynamicFormatter = new DynamicFormatter<TestStruct?>();
			var buffer = DynamicFormatter.Serialize(testEntity);
			var resultEntity = DynamicFormatter.Deserialize(buffer);
			Assert.AreEqual(testEntity, resultEntity);
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