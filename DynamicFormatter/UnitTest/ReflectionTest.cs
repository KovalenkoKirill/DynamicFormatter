using DynamicFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using UnitTest.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace UnitTest
{
	[TestClass]
	public class ReflectionTest
	{
		[TestMethod]
		public void TestGetterAndSetter()
		{
			ArrayItem item = new ArrayItem();
			item.abc = -1;
			item.dfg = -1;
			var _memberInfo = typeof(ArrayItem).GetMembers(
						 BindingFlags.NonPublic |
						 BindingFlags.Public |
						 BindingFlags.Instance)
						 .Where(x => x.MemberType == MemberTypes.Field)
						 .Cast<FieldInfo>().ToList();

			foreach (var member in _memberInfo)
			{
				var action = ReflectionUtils.CreateInstanceFieldSetter(member);
				action.Invoke(item, 30);
			}
			Assert.AreEqual(item.abc, 30);
			Assert.AreEqual(item.dfg, 30);
			foreach (var member in _memberInfo)
			{
				var action = ReflectionUtils.CreateInstanceFieldGetter(member);
				Assert.AreEqual(action.DynamicInvoke(item), 30);
			}
		}

		struct TestGeneric<T,U>
		{
			public T key;
			public U Val;
		}

		[TestMethod]
		public void TestSetterGenericStruct()
		{
			TestGeneric<int, int> testGeneric = new TestGeneric<int, int>();
			testGeneric.key = 10;
			testGeneric.Val = 50;

			var genericMembers = testGeneric.GetType().GetMembers(
			BindingFlags.NonPublic |
			BindingFlags.Public |
			BindingFlags.Instance)
			.Where(x => x.MemberType == MemberTypes.Field)
			.Cast<FieldInfo>().ToList();


			foreach (var member in genericMembers)
			{
				var action = ReflectionUtils.CreateInstanceFieldSetterForValueType(member);
				testGeneric = (TestGeneric<int,int>)action.Invoke(testGeneric, 90);
			}

			Assert.AreEqual(testGeneric.key, 90);
			Assert.AreEqual(testGeneric.Val, 90);

		}
		[TestMethod]
		public void TestSpeedCast()
		{
			var watch = Stopwatch.StartNew();
			for (int i = 0; i < 1000000; i++)
			{
				var result = SafeCast(i);
			}
			watch.Stop();
			Debug.WriteLine($"SafeCast {watch.ElapsedMilliseconds}");

			watch = Stopwatch.StartNew();
			for (int i = 0; i < 1000000; i++)
			{
				var result = UnsafeCast(i);
			}
			watch.Stop();
			Debug.WriteLine($"UnsafeCast {watch.ElapsedMilliseconds}");
		}

		[TestMethod]
		public void NullableReflection()
		{
			int? d = null;
		}

		public byte[] SafeCast(object entity)
		{
			return BitConverter.GetBytes((int)Convert.ChangeType(entity, typeof(int)));
		}

		public unsafe byte[] UnsafeCast(object entity)
		{
			int val = (int)entity;
			int* ptr = &val;
			int size = sizeof(int); ;
			byte[] buffer = new byte[size];
			fixed (byte* dest = buffer)
			{
				Buffer.MemoryCopy(ptr, dest, size, size);
			}
			return buffer;
		}
	}
}