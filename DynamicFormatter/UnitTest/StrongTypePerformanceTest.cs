using DynamicFormatter.Serializers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Helpers;
using UnitTest.Models;

namespace UnitTest
{
	/// <summary>
	/// Dynamic formatter in debug mode
	/// With optimization code it's will be better
	/// </summary>
	[TestClass]
	public class StrongTypePerformanceTest
	{
		[TestMethod]
		public void TestPerfomenceStrongType()
		{
			IStrongStructure entity = new StrongStructure();

			StrongTypeFormatter serializer = new StrongTypeFormatter();

			var watch = Stopwatch.StartNew();

			for(int i = 0; i<1000;i++)
			{
				var buffer = serializer.Serialize(entity);
				serializer.Deserialize(buffer);
			}
			watch.Stop();

			BinaryFormatter binary = new BinaryFormatter();

			var binaryWatch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				using (MemoryStream mStream = new MemoryStream())
				{
					binary.Serialize(mStream, entity);
					mStream.Position = 0;
					var obj = binary.Deserialize(mStream);
				}
			}
			binaryWatch.Stop();

			Assert.IsTrue(watch.ElapsedTicks < binaryWatch.ElapsedTicks,
						$"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nBinaryFormatter {binaryWatch.ElapsedMilliseconds} ms");
		}

		[TestMethod]
		public void TestPerfomenceStrongTypeWithJsonNet()
		{
			IStrongStructure entity = new StrongStructure();

			StrongTypeFormatter serializer = new StrongTypeFormatter();

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var buffer = serializer.Serialize(entity);
				serializer.Deserialize(buffer);
			}
			watch.Stop();

			var jsonWatch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var buffer = JsonConvert.SerializeObject(entity);
				var obj = JsonConvert.DeserializeObject(buffer);
			}
			jsonWatch.Stop();

			Assert.IsTrue(watch.ElapsedTicks < jsonWatch.ElapsedTicks,
						$"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nJsonConvert {jsonWatch.ElapsedMilliseconds} ms");
		}

		[TestMethod]
		public void TestPerfomenceStrongTypeWithProtoBuf()
		{
			IStrongStructure entity = new StrongStructure();

			StrongTypeFormatter serializer = new StrongTypeFormatter();

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var buffer = serializer.Serialize(entity);
				serializer.Deserialize(buffer);
			}
			watch.Stop();

			var protoBuf = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var buffer = ProtoBufHelper.ProtoSerialize(entity);
				var obj = ProtoBufHelper.ProtoDeserialize<StrongStructure>(buffer);
			}
			protoBuf.Stop();

			Assert.IsTrue(watch.ElapsedTicks < protoBuf.ElapsedTicks,
						$"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nprotoBuf {protoBuf.ElapsedMilliseconds} ms");
		}
	}
}
