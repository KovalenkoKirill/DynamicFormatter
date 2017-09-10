using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DynamicFormatter
{
#if DEBUG

	public static class ReflectionUtils
#else
	internal static class ReflectionUtils
#endif
	{
		public static Func<object, object> CreateInstanceFieldGetter(FieldInfo fieldInfo)
		{
			ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
			var body = Expression.Convert(
			Expression.Field(Expression.Convert(p1, fieldInfo.DeclaringType), fieldInfo),
			typeof(object));
			var lambda = Expression.Lambda<Func<object, object>>(body, p1);
			return lambda.Compile();
		}

		public static Action<object, object> CreateInstanceFieldSetter(FieldInfo member)
		{
			ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
			ParameterExpression p2 = Expression.Parameter(typeof(object), "p2");

			LabelTarget returnTarget = Expression.Label();

			var m1 = Expression.MakeMemberAccess(Expression.Convert(p1, member.DeclaringType), member);
			var m2 = Expression.Convert(p2, member.FieldType);
			var ret = Expression.Return(returnTarget, Expression.Assign(m1, m2));
			BinaryExpression body = Expression.Assign(m1, m2);
			var lambda = Expression.Lambda<Action<object, object>>(body, p1, p2);
			return lambda.Compile();
		}

	//	.Lambda #Lambda1<System.Func`3[System.Object,System.Object,System.Object]>(
 //   System.Object $p1,
	//System.Object $p2)
	//	{
 //   .Block(
	//	UnitTest.ReflectionTest + TestGeneric`2[System.Int32, System.Int32] $Struct,
	//	System.Object $ret) {
 //       $Struct = (UnitTest.ReflectionTest + TestGeneric`2[System.Int32, System.Int32])$p1;
 //       $Struct.key = (System.Int32)$p2;
 //       $ret = (System.Object)$Struct;
 //       .Return #Label1 { $ret };
 //       .Label
 //           $ret
	//	.LabelTarget #Label1:
 //   }
	//	}
		public static Func<object, object, object> CreateInstanceFieldSetterForValueType(FieldInfo member)
		{

			ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
			ParameterExpression p2 = Expression.Parameter(typeof(object), "p2");
			ParameterExpression SturctObjectParam = Expression.Variable(member.DeclaringType, "Struct");
			ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

			LabelTarget returnTarget = Expression.Label(typeof(object));


			var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, member.DeclaringType));
			var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, member);

			var m2 = Expression.Convert(p2, member.FieldType);
			var assign = Expression.Assign(makeMeberAccess, m2);
			var assingnToResult = Expression.Assign(
											retObjectParam,
											Expression.Convert(SturctObjectParam, typeof(object)));

			GotoExpression returnExpression = Expression.Return(returnTarget,
															retObjectParam, typeof(object));

			LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

			BlockExpression block = Expression.Block(
													new ParameterExpression[] { SturctObjectParam, retObjectParam },
													assignToRet,
													assign,
													assingnToResult,
													returnExpression,
													returnLabel);
			var lambda = Expression.Lambda<Func<object, object, object>>(block, p1, p2);
			return lambda.Compile();
		}
	}
}