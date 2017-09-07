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

			var m1 = Expression.MakeMemberAccess(Expression.Convert(p1, member.DeclaringType), member);
			var m2 = Expression.Convert(p2, member.FieldType);
			BinaryExpression body = Expression.Assign(m1, m2);
			var lambda = Expression.Lambda<Action<object, object>>(body, p1, p2);
			return lambda.Compile();
		}
	}
}