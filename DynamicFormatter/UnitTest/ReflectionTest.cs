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
#if DEBUG
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

		struct TestGeneric<T, U>
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
				testGeneric = (TestGeneric<int, int>)action.Invoke(testGeneric, 90);
			}

			Assert.AreEqual(testGeneric.key, 90);
			Assert.AreEqual(testGeneric.Val, 90);

		}

		[TestMethod]
		public void TestSetterStrongType()
		{
			JustSimpleClass simple = new JustSimpleClass(10);
			var genericMembers = simple.GetType().GetMembers(
BindingFlags.NonPublic |
BindingFlags.Public |
BindingFlags.Instance)
.Where(x => x.MemberType == MemberTypes.Field)
.Cast<FieldInfo>().ToList();
			foreach (var member in genericMembers)
			{
				if (member.FieldType == typeof(int))
				{
					var action = CreateInstanceFieldSetterForValueType(member);
					var result = action.Invoke(simple, 90);
				}
			}
		}
				

		public static Action<JustSimpleClass, int> CreateInstanceFieldSetter(FieldInfo member)
		{
			ParameterExpression p1 = Expression.Parameter(typeof(JustSimpleClass), "p1");
			ParameterExpression p2 = Expression.Parameter(typeof(int), "p2");

			var m1 = Expression.MakeMemberAccess(p1, member);
			BinaryExpression body = Expression.Assign(m1, p2);
			var lambda = Expression.Lambda<Action<JustSimpleClass, int>>(body, p1, p2);
			return lambda.Compile();
		}
		public static Func<JustSimpleClass, int, JustSimpleClass> CreateInstanceFieldSetterForValueType(FieldInfo member)
		{

			ParameterExpression p1 = Expression.Parameter(typeof(JustSimpleClass), "p1");
			ParameterExpression p2 = Expression.Parameter(typeof(int), "p2");
			ParameterExpression SturctObjectParam = Expression.Variable(member.DeclaringType, "Struct");
			ParameterExpression retObjectParam = Expression.Variable(typeof(JustSimpleClass), "ret");

			LabelTarget returnTarget = Expression.Label(typeof(JustSimpleClass));


			var assignToRet = Expression.Assign(SturctObjectParam, p1);
			var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, member);

			var assign = Expression.Assign(makeMeberAccess, p2);
			var assingnToResult = Expression.Assign(
											retObjectParam,
											(SturctObjectParam));

			GotoExpression returnExpression = Expression.Return(returnTarget,
															retObjectParam, typeof(JustSimpleClass));

			LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

			BlockExpression block = Expression.Block(
													new ParameterExpression[] { SturctObjectParam, retObjectParam },
													assignToRet,
													assign,
													assingnToResult,
													returnExpression,
													returnLabel);
			var lambda = Expression.Lambda<Func<JustSimpleClass, int, JustSimpleClass>>(block, p1, p2);
			return lambda.Compile();
		}

#endif
	}
}