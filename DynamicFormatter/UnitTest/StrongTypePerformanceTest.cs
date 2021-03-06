﻿using DynamicFormatter;
using DynamicFormatter.Serializers;
using MessagePack;
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
	/// For run this test switch to Release mode.
	/// </summary>
	[TestClass]
	public class StrongTypePerformanceTest
	{
		public TestContext TestContext { get; set; }

#if DEBUG
		[TestMethod]
		public void AdebugTest()
		{
			var entity = new StrongStructure();

			var serializer = new DynamicFormatter<StrongStructure>();

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < 50; i++)
			{
				var buffer = serializer.Serialize(entity);
				var result = serializer.Deserialize(buffer);
			}
			watch.Stop();

			long ms = watch.ElapsedMilliseconds;
		}

#else

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

			var message = $"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nBinaryFormatter {binaryWatch.ElapsedMilliseconds} ms";

			Assert.IsTrue(watch.ElapsedTicks < binaryWatch.ElapsedTicks, message);
			TestContext.WriteLine(message);
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

			var message = $"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nJsonConvert {jsonWatch.ElapsedMilliseconds} ms";

			Assert.IsTrue(watch.ElapsedTicks < jsonWatch.ElapsedTicks,
						message);
			TestContext.WriteLine(message);
		}

		[TestMethod]
		public void TestPerfomenceStrongTypeWithProtoBuf()
		{
			var entity = new StrongStructure();

			var serializer = new DynamicFormatter<StrongStructure>();

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var buffer = serializer.Serialize(entity);
				serializer.Deserialize(buffer);
			}
			watch.Stop();

			long ms = watch.ElapsedMilliseconds;

			var protoBuf = Stopwatch.StartNew();

			{
				var buffer = ProtoBufHelper.ProtoSerialize(entity);
				var obj = ProtoBufHelper.ProtoDeserialize<StrongStructure>(buffer);
			}

			for (int i = 0; i < 1000; i++)
			{
				var buffer = ProtoBufHelper.ProtoSerialize(entity);
				var obj = ProtoBufHelper.ProtoDeserialize<StrongStructure>(buffer);
			}
			protoBuf.Stop();

			var message = $"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nprotoBuf {protoBuf.ElapsedMilliseconds} ms";

			Assert.IsTrue(watch.ElapsedTicks < protoBuf.ElapsedTicks,
						message);

			TestContext.WriteLine(message);
		}

		[TestMethod]
		public void TestPerfomenceStrongTypeWithMsgPack()
		{
			var entity = new StrongStructure();

			var serializer = new DynamicFormatter<StrongStructure>();

			{
				var buffer = serializer.Serialize(entity);
				var result = serializer.Deserialize(buffer);
			}

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var buffer = serializer.Serialize(entity);
				var result = serializer.Deserialize(buffer);
			}
			watch.Stop();

			long ms = watch.ElapsedMilliseconds;

			{
				var bin = MessagePackSerializer.Serialize(entity);

				// Okay to deserialize immutable obejct
				var point = MessagePackSerializer.Deserialize<StrongStructure>(bin);
			}

			var msgPackWatch = Stopwatch.StartNew();

			for (int i = 0; i < 1000; i++)
			{
				var bin = MessagePackSerializer.Serialize(entity);

				// Okay to deserialize immutable obejct
				var point = MessagePackSerializer.Deserialize<StrongStructure>(bin);
			}
			msgPackWatch.Stop();

			var message = $"StrongTypeFormatter {watch.ElapsedMilliseconds} ms\r\nMessagePackSerializer {msgPackWatch.ElapsedMilliseconds} ms";

			Assert.IsTrue(watch.ElapsedTicks < msgPackWatch.ElapsedTicks, message);

			TestContext.WriteLine(message);
		}
		#endif
	}
}
