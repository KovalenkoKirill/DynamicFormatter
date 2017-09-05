using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.Models;
using System.Reflection;
using System.Linq;
using DynamicFormatter;

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
			
			foreach(var member in _memberInfo)
			{
				var action = ReflectionUtils.CreateInstanceFieldSetter(member);
				action.Invoke(item, (object)30);
			}
			Assert.AreEqual(item.abc, 30);
			Assert.AreEqual(item.dfg, 30);
			foreach (var member in _memberInfo)
			{
				var action = ReflectionUtils.CreateInstanceFieldGetter(member);
				Assert.AreEqual(action.DynamicInvoke(item), 30);
			}
		}
	}
}
