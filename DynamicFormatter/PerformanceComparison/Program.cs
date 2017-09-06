using DynamicFormatter;
using Newtonsoft.Json;
using PerformanceComparison.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using ZeroFormatter;

namespace PerformanceComparison
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine($"Please write iterationCount");
			int iterationCount = -1;
			var line = string.Empty;
			do
			{
				line = Console.ReadLine();
				try
				{
					iterationCount = Convert.ToInt32(line);
				}
				catch (Exception ex)
				{
					Console.WriteLine($"{line} incorect int value");
				}
			} while (iterationCount < 0);
			do
			{
				Console.WriteLine($"press q or e for exit");
				Console.WriteLine($"Choise entity Type:");
				Console.WriteLine($"1: BaseStruct (struct with only value types)");
				Console.WriteLine($"2: BaseClass (struct with only value types)");
				Console.WriteLine($"3: Just int");
				Console.WriteLine($"4: Class with inner class");
				Console.WriteLine($"5: CrossReference class");
				try
				{
					line = Console.ReadKey().KeyChar.ToString();
					switch (line)
					{
						case "1":
							SerializeTest<BaseStruct>(new BaseStruct()
							{
								B = 10,
								R = 88,
								G = 55
							}, iterationCount);
							break;
						case "2":
							SerializeTest<BaseClass>(new BaseClass()
							{
								B = 10,
								R = 88,
								G = 55
							}, iterationCount);
							break;
						case "3":
							SerializeTest<int>(10, iterationCount);
							break;
						case "4":
							SerializeTest<ClassWithInnerReference>(new ClassWithInnerReference()
							{
								B = int.MaxValue,
								G = 4213,
								R = 123,
								InnerClass = new BaseClass()
								{
									R = 12,
									G = 43,
									B = 12
								}
							}, iterationCount);
							break;
						case "5":
							SerializeTest<CrossReferenceClass>(new CrossReferenceClass(),iterationCount);
							break;
					}
				}
				catch (Exception ex)
				{
				}
				line = Console.ReadLine();
			} while (line != "q" || line != "e");
		}

		public static void SerializeTest<T>(T entity, int iterationCount)
		{
			long serilizationResult = 0;
			long desirilizationResult = 0;
			int objectSize = 0;

			var watch = new Stopwatch();

			#region dynamicFormatter

			var dynamicFormatter = new DynamicFormatter<T>();
			byte[] dynamicBytes = null;
			watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				dynamicBytes = dynamicFormatter.Serialize(entity);
			}
			watch.Stop();
			objectSize = dynamicBytes.Length;
			serilizationResult = watch.ElapsedMilliseconds;

			watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				dynamicFormatter.Deserialize(dynamicBytes);
			}
			watch.Stop();
			desirilizationResult = watch.ElapsedMilliseconds;
			Console.WriteLine
($"dynamicFormatter deserialize reuslt for {entity.GetType().Name} and {iterationCount} iterations");
			Console.WriteLine($"Serilization: {serilizationResult}ms");
			Console.WriteLine($"Desirilization: {desirilizationResult}ms");
			Console.WriteLine($"Total: {serilizationResult + desirilizationResult}ms");
			Console.WriteLine($"Size: {objectSize} bytes.");

			#endregion dynamicFormatter
			Console.WriteLine();
			#region json

			try
			{

				watch = Stopwatch.StartNew();

				string json = string.Empty;
				for (int i = 0; i < iterationCount; i++)
				{
					json = JsonConvert.SerializeObject(entity);
				}
				watch.Stop();
				serilizationResult = watch.ElapsedMilliseconds;
				objectSize = Encoding.Default.GetBytes(json).Length;
				watch = Stopwatch.StartNew();
				for (int i = 0; i < iterationCount; i++)
				{
					var obj = JsonConvert.DeserializeObject<T>(json);
				}
				watch.Stop();
				desirilizationResult = watch.ElapsedMilliseconds;
				Console.WriteLine
				($"JsonConvert reuslt for {entity.GetType().Name} and {iterationCount} iterations");
				Console.WriteLine($"Serilization: {serilizationResult}ms");
				Console.WriteLine($"Desirilization: {desirilizationResult}ms");
				Console.WriteLine($"Total: {serilizationResult + desirilizationResult}ms");
				Console.WriteLine($"Size: {objectSize} bytes.");
			}
			catch(Exception ex)
			{
				Console.WriteLine($"Json not supported");
			}
			#endregion json
			Console.WriteLine();
			#region Binary

			BinaryFormatter formatter = new BinaryFormatter();
			watch = Stopwatch.StartNew();
			for (int i = 0; i < iterationCount; i++)
			{
				using (var mStream = new MemoryStream())
				{
					formatter.Serialize(mStream, entity);
				}
			}
			watch.Stop();
			serilizationResult = watch.ElapsedMilliseconds;

			byte[] binaryBytes = null;
			{
				using (var mStream = new MemoryStream())
				{
					formatter.Serialize(mStream, entity);
					binaryBytes = mStream.ToArray();
				}
			}
			objectSize = binaryBytes.Length;
			watch = Stopwatch.StartNew();

			for (int i = 0; i < iterationCount; i++)
			{
				using (var mStream = new MemoryStream(binaryBytes))
				{
					object obj = formatter.Deserialize(mStream);
				}
			}
			watch.Stop();
			desirilizationResult = watch.ElapsedMilliseconds;
			Console.WriteLine
			($"BinaryFormatter reuslt for {entity.GetType().Name} and {iterationCount} iterations");
			Console.WriteLine($"Serilization: {serilizationResult}ms");
			Console.WriteLine($"Desirilization: {desirilizationResult}ms");
			Console.WriteLine($"Total: {serilizationResult + desirilizationResult}ms");
			Console.WriteLine($"Size: {objectSize} bytes.");

			#endregion Binary
			Console.WriteLine();
			#region ZeroFormatterSerializer

			try
			{

				byte[] zeroSerializeBytes = null;
				watch = Stopwatch.StartNew();
				for (int i = 0; i < iterationCount; i++)
				{
					zeroSerializeBytes = ZeroFormatterSerializer.Serialize(entity);
				}
				watch.Stop();
				objectSize = zeroSerializeBytes.Length;
				serilizationResult = watch.ElapsedMilliseconds;

				watch = Stopwatch.StartNew();
				for (int i = 0; i < iterationCount; i++)
				{
					T obj = ZeroFormatterSerializer.Deserialize<T>(zeroSerializeBytes);
				}
				watch.Stop();
				desirilizationResult = watch.ElapsedMilliseconds;
				Console.WriteLine
				($"ZeroFormatterSerializer reuslt for {entity.GetType().Name} and {iterationCount} iterations");
				Console.WriteLine($"Serilization: {serilizationResult}ms");
				Console.WriteLine($"Desirilization: {desirilizationResult}ms");
				Console.WriteLine($"Total: {serilizationResult + desirilizationResult}ms");
				Console.WriteLine($"Size: {objectSize} bytes.");

			}
			catch(Exception ex)
			{
				Console.WriteLine($"ZeroFormatter not supported this type");
			}
			#endregion ZeroFormatterSerializer
			Console.WriteLine();
			#region ProtoBuf

			try
			{

				byte[] zeroSerializeBytes = null;
				watch = Stopwatch.StartNew();
				for (int i = 0; i < iterationCount; i++)
				{
					zeroSerializeBytes = ProtoBufHelper.ProtoSerialize<T>(entity);
				}
				watch.Stop();
				serilizationResult = watch.ElapsedMilliseconds;
				objectSize = zeroSerializeBytes.Length;
				watch = Stopwatch.StartNew();
				for (int i = 0; i < iterationCount; i++)
				{
					T obj = ProtoBufHelper.ProtoDeserialize<T>(zeroSerializeBytes);
				}
				watch.Stop();
				desirilizationResult = watch.ElapsedMilliseconds;
				Console.WriteLine
				($"ProtoBuf reuslt for {entity.GetType().Name} and {iterationCount} iterations");
				Console.WriteLine($"Serilization: {serilizationResult}ms");
				Console.WriteLine($"Desirilization: {desirilizationResult}ms");
				Console.WriteLine($"Total: {serilizationResult + desirilizationResult}ms");
				Console.WriteLine($"Size: {objectSize} bytes.");

			}
			catch (Exception ex)
			{
				Console.WriteLine($"ProtoBuf not supported this type");
			}
			#endregion
		}

	}
}