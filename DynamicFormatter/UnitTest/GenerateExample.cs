//using System;
//using DynamicFormatter.interfaces;
//using DynamicFormatter.Generator;
//using DynamicFormatter.Extentions;
//using System.Runtime.Serialization;
//using DynamicFormatter.Models;
//using System.Collections.Generic;
//using System.Reflection;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Runtime.CompilerServices;


//namespace DynamicFormatter.Dynamic
//{
//	public class c1 : IResolver<UnitTest.Models.c1>
//	{
//		public Action<UnitTest.Models.c1, System.Guid> Setter_p1k__BackingField;

//		public Func<UnitTest.Models.c1, System.Guid> Getter_p1k__BackingField;

//		public Action<UnitTest.Models.c1, System.Guid> Setter_p2k__BackingField;

//		public Func<UnitTest.Models.c1, System.Guid> Getter_p2k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p3k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p3k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.e1> Setter_p4k__BackingField;

//		public Func<UnitTest.Models.c1, UnitTest.Models.e1> Getter_p4k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.e2> Setter_p5k__BackingField;

//		public Func<UnitTest.Models.c1, UnitTest.Models.e2> Getter_p5k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p6k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p6k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p7k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p7k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p8k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p8k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p9k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p9k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p10k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p10k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p11k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p11k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.e3> Setter_p12k__BackingField;

//		public Func<UnitTest.Models.c1, UnitTest.Models.e3> Getter_p12k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p13k__BackingField;

//		public Func<UnitTest.Models.c1, System.String> Getter_p13k__BackingField;

//		public Action<UnitTest.Models.c1, System.DateTime> Setter_p14k__BackingField;

//		public Func<UnitTest.Models.c1, System.DateTime> Getter_p14k__BackingField;

//		public Action<UnitTest.Models.c1, System.Guid> Setter_p15k__BackingField;

//		public Func<UnitTest.Models.c1, System.Guid> Getter_p15k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.c2> Setter_p16k__BackingField;

//		public Func<UnitTest.Models.c1, UnitTest.Models.c2> Getter_p16k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.c3> Setter_p17k__BackingField;

//		public Func<UnitTest.Models.c1, UnitTest.Models.c3> Getter_p17k__BackingField;


//		TypeInfo typeInfo;

//		public c1()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c1));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 8261103));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.Guid>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 8261103));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23702691));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.Guid>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23702691));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 29811240));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 29811240));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 18738776));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.e1>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e1), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 18738776));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e1>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16748349));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.e2>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e2), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16748349));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e2>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57911184));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57911184));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57274684));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57274684));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16931803));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16931803));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 10860343));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 10860343));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 24267209));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 24267209));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36893500));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36893500));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45251306));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.e3>>(body, p1);
//				Getter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e3), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45251306));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e3>>(body, p1, p2);
//				Setter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 41921117));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 41921117));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 14799822));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.DateTime>>(body, p1);
//				Getter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.DateTime), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 14799822));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.DateTime>>(body, p1, p2);
//				Setter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 9462952));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.Guid>>(body, p1);
//				Getter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 9462952));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 58401797));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.c2>>(body, p1);
//				Getter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c2), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 58401797));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.c2>>(body, p1, p2);
//				Setter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 5487919));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.c3>>(body, p1);
//				Getter_p17k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c3), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 5487919));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.c3>>(body, p1, p2);
//				Setter_p17k__BackingField = lambda.Compile();
//			}


//		}


//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return BitConverter.GetBytes(((short)-1));
//			}
//			DynamicBuffer.BufferPtr ptr;
//			if (referenceMaping.TryGetValue(Entity, out ptr))
//			{
//				return BitConverter.GetBytes(ptr.position);
//			}
//			ptr = buff.Alloc(89);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			UnitTest.Models.c1 entity = (UnitTest.Models.c1)Entity;

//			{
//				System.Guid value = Getter_p1k__BackingField(entity);

//				BaseConvertor.Write128(buffer, offset, (byte*)&value);

//				offset += 16;

//			}
//			{
//				System.Guid value = Getter_p2k__BackingField(entity);

//				BaseConvertor.Write128(buffer, offset, (byte*)&value);

//				offset += 16;

//			}
//			{
//				System.String value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.e1 value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}
//			{
//				UnitTest.Models.e2 value = Getter_p5k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}
//			{
//				System.String value = Getter_p6k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p7k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p8k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p9k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p10k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p11k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.e3 value = Getter_p12k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}
//			{
//				System.String value = Getter_p13k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.DateTime value = Getter_p14k__BackingField(entity);

//				BaseConvertor.Write64(buffer, offset, (byte*)&value);

//				offset += 8;

//			}
//			{
//				System.Guid value = Getter_p15k__BackingField(entity);

//				BaseConvertor.Write128(buffer, offset, (byte*)&value);

//				offset += 16;

//			}
//			{
//				UnitTest.Models.c2 value = Getter_p16k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c3 value = Getter_p17k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}

//			return BitConverter.GetBytes(position);
//		}


//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			if (referenceMaping.ContainsKey(position))
//			{
//				return referenceMaping[position];
//			}
//			offset = position;

//			var entity = (UnitTest.Models.c1)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c1));
//			referenceMaping.Add(position, entity);
//			offset++;
//			Setter_p1k__BackingField.Invoke(entity, BaseConvertor.GetGuid(buffer, offset));
//			offset += 16;
//			Setter_p2k__BackingField.Invoke(entity, BaseConvertor.GetGuid(buffer, offset));
//			offset += 16;
//			string p3k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField);
//			offset += 2;
//			Setter_p4k__BackingField.Invoke(entity, (UnitTest.Models.e1)BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			Setter_p5k__BackingField.Invoke(entity, (UnitTest.Models.e2)BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			string p6k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p6k__BackingField.Invoke(entity, p6k__BackingField);
//			offset += 2;
//			string p7k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p7k__BackingField.Invoke(entity, p7k__BackingField);
//			offset += 2;
//			string p8k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p8k__BackingField.Invoke(entity, p8k__BackingField);
//			offset += 2;
//			string p9k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p9k__BackingField.Invoke(entity, p9k__BackingField);
//			offset += 2;
//			string p10k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p10k__BackingField.Invoke(entity, p10k__BackingField);
//			offset += 2;
//			string p11k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p11k__BackingField.Invoke(entity, p11k__BackingField);
//			offset += 2;
//			Setter_p12k__BackingField.Invoke(entity, (UnitTest.Models.e3)BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			string p13k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p13k__BackingField.Invoke(entity, p13k__BackingField);
//			offset += 2;
//			Setter_p14k__BackingField.Invoke(entity, BaseConvertor.GetDate(buffer, offset));
//			offset += 8;
//			Setter_p15k__BackingField.Invoke(entity, BaseConvertor.GetGuid(buffer, offset));
//			offset += 16;

//			UnitTest.Models.c2 p16k__BackingField_Result = (UnitTest.Models.c2)TypeResolveFactory.ResolveDesirialize(
//																typeof(UnitTest.Models.c2),
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p16k__BackingField.Invoke(entity, p16k__BackingField_Result);
//			offset += 2;

//			UnitTest.Models.c3 p17k__BackingField_Result = (UnitTest.Models.c3)TypeResolveFactory.ResolveDesirialize(
//																typeof(UnitTest.Models.c3),
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p17k__BackingField.Invoke(entity, p17k__BackingField_Result);
//			offset += 2;


//			return entity;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}
//	public class c2 : IResolver<UnitTest.Models.c2>
//	{
//		public Action<UnitTest.Models.c2, System.String> Setter_p1k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p1k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p2k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p2k__BackingField;

//		public Action<UnitTest.Models.c2, UnitTest.Models.c4> Setter_p3k__BackingField;

//		public Func<UnitTest.Models.c2, UnitTest.Models.c4> Getter_p3k__BackingField;

//		public Action<UnitTest.Models.c2, UnitTest.Models.c5> Setter_p4k__BackingField;

//		public Func<UnitTest.Models.c2, UnitTest.Models.c5> Getter_p4k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p5k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p5k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int64?> Setter_p6k__BackingField;

//		public Func<UnitTest.Models.c2, System.Int64?> Getter_p6k__BackingField;

//		public Action<UnitTest.Models.c2, System.Boolean?> Setter_p7k__BackingField;

//		public Func<UnitTest.Models.c2, System.Boolean?> Getter_p7k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p8k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p8k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p9k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p9k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p10k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p10k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p11k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p11k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p12k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p12k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p13k__BackingField;

//		public Func<UnitTest.Models.c2, System.String> Getter_p13k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int64?> Setter_p14k__BackingField;

//		public Func<UnitTest.Models.c2, System.Int64?> Getter_p14k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int32?> Setter_p15k__BackingField;

//		public Func<UnitTest.Models.c2, System.Int32?> Getter_p15k__BackingField;

//		public Action<UnitTest.Models.c2, System.Boolean?> Setter_p16k__BackingField;

//		public Func<UnitTest.Models.c2, System.Boolean?> Getter_p16k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int32?> Setter_p17k__BackingField;

//		public Func<UnitTest.Models.c2, System.Int32?> Getter_p17k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int32?> Setter_p18k__BackingField;

//		public Func<UnitTest.Models.c2, System.Int32?> Getter_p18k__BackingField;


//		TypeInfo typeInfo;

//		public c2()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c2));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53477406));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53477406));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 430818));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 430818));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 24286620));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, UnitTest.Models.c4>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c4), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 24286620));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, UnitTest.Models.c4>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 13074935));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, UnitTest.Models.c5>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c5), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 13074935));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, UnitTest.Models.c5>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 15788365));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 15788365));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 855848));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Int64?>>(body, p1);
//				Getter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int64?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 855848));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int64?>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46395329));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Boolean?>>(body, p1);
//				Getter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46395329));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Boolean?>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 26038915));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 26038915));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 13863048));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 13863048));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 21198618));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 21198618));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 6655538));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 6655538));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59656956));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59656956));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 51373647));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.String>>(body, p1);
//				Getter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 51373647));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35245880));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Int64?>>(body, p1);
//				Getter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int64?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35245880));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int64?>>(body, p1, p2);
//				Setter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 60658032));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Int32?>>(body, p1);
//				Getter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 60658032));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int32?>>(body, p1, p2);
//				Setter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44287968));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Boolean?>>(body, p1);
//				Getter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44287968));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Boolean?>>(body, p1, p2);
//				Setter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 58112803));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Int32?>>(body, p1);
//				Getter_p17k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 58112803));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int32?>>(body, p1, p2);
//				Setter_p17k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61557762));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c2, System.Int32?>>(body, p1);
//				Getter_p18k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61557762));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int32?>>(body, p1, p2);
//				Setter_p18k__BackingField = lambda.Compile();
//			}


//		}


//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return BitConverter.GetBytes(((short)-1));
//			}
//			BufferPtr ptr;
//			if (referenceMaping.TryGetValue(Entity, out ptr))
//			{
//				return BitConverter.GetBytes(ptr.position);
//			}
//			ptr = buff.Alloc(37);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			UnitTest.Models.c2 entity = (UnitTest.Models.c2)Entity;

//			{
//				System.String value = Getter_p1k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p2k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c4 value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c5 value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p5k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int64? value = Getter_p6k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Boolean? value = Getter_p7k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p8k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p9k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p10k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p11k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p12k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p13k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int64? value = Getter_p14k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32? value = Getter_p15k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Boolean? value = Getter_p16k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32? value = Getter_p17k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32? value = Getter_p18k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}

//			return BitConverter.GetBytes(position);
//		}


//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			if (referenceMaping.ContainsKey(position))
//			{
//				return referenceMaping[position];
//			}
//			offset = position;

//			var entity = (UnitTest.Models.c2)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c2));
//			referenceMaping.Add(position, entity);
//			offset++;
//			string p1k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p1k__BackingField.Invoke(entity, p1k__BackingField);
//			offset += 2;
//			string p2k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p2k__BackingField.Invoke(entity, p2k__BackingField);
//			offset += 2;

//			UnitTest.Models.c4 p3k__BackingField_Result = (UnitTest.Models.c4)TypeResolveFactory.ResolveDesirialize(
//																typeof(UnitTest.Models.c4),
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField_Result);
//			offset += 2;

//			UnitTest.Models.c5 p4k__BackingField_Result = (UnitTest.Models.c5)TypeResolveFactory.ResolveDesirialize(
//																typeof(UnitTest.Models.c5),
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 2;
//			string p5k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p5k__BackingField.Invoke(entity, p5k__BackingField);
//			offset += 2;
//			{
//				System.Int64? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetLong(buffer, ptrToNullable + 1);





//					Setter_p6k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Boolean? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetBool(buffer, ptrToNullable + 1);





//					Setter_p7k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			string p8k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p8k__BackingField.Invoke(entity, p8k__BackingField);
//			offset += 2;
//			string p9k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p9k__BackingField.Invoke(entity, p9k__BackingField);
//			offset += 2;
//			string p10k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p10k__BackingField.Invoke(entity, p10k__BackingField);
//			offset += 2;
//			string p11k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p11k__BackingField.Invoke(entity, p11k__BackingField);
//			offset += 2;
//			string p12k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p12k__BackingField.Invoke(entity, p12k__BackingField);
//			offset += 2;
//			string p13k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p13k__BackingField.Invoke(entity, p13k__BackingField);
//			offset += 2;
//			{
//				System.Int64? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetLong(buffer, ptrToNullable + 1);





//					Setter_p14k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Int32? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetInt(buffer, ptrToNullable + 1);





//					Setter_p15k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Boolean? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetBool(buffer, ptrToNullable + 1);





//					Setter_p16k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Int32? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetInt(buffer, ptrToNullable + 1);





//					Setter_p17k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Int32? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetInt(buffer, ptrToNullable + 1);





//					Setter_p18k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;


//			return entity;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}
//	public class c4 : IResolver<UnitTest.Models.c4>
//	{
//		public Action<UnitTest.Models.c4, System.Byte?> Setter_p1k__BackingField;

//		public Func<UnitTest.Models.c4, System.Byte?> Getter_p1k__BackingField;

//		public Action<UnitTest.Models.c4, System.Byte?> Setter_p2k__BackingField;

//		public Func<UnitTest.Models.c4, System.Byte?> Getter_p2k__BackingField;

//		public Action<UnitTest.Models.c4, System.Byte?> Setter_p3k__BackingField;

//		public Func<UnitTest.Models.c4, System.Byte?> Getter_p3k__BackingField;

//		public Action<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?> Setter_p4k__BackingField;

//		public Func<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?> Getter_p4k__BackingField;


//		TypeInfo typeInfo;

//		public c4()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c4));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 7393726));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, System.Byte?>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 7393726));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 3004583));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, System.Byte?>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 3004583));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62904121));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, System.Byte?>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62904121));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 66335374));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.DayOfWeek?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 66335374));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}


//		}


//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return BitConverter.GetBytes(((short)-1));
//			}
//			BufferPtr ptr;
//			if (referenceMaping.TryGetValue(Entity, out ptr))
//			{
//				return BitConverter.GetBytes(ptr.position);
//			}
//			ptr = buff.Alloc(9);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			UnitTest.Models.c4 entity = (UnitTest.Models.c4)Entity;

//			{
//				System.Byte? value = Getter_p1k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Byte? value = Getter_p2k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Byte? value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.DayOfWeek? value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}

//			return BitConverter.GetBytes(position);
//		}


//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			if (referenceMaping.ContainsKey(position))
//			{
//				return referenceMaping[position];
//			}
//			offset = position;

//			var entity = (UnitTest.Models.c4)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c4));
//			referenceMaping.Add(position, entity);
//			offset++;
//			{
//				System.Byte? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetByte(buffer, ptrToNullable + 1);





//					Setter_p1k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Byte? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetByte(buffer, ptrToNullable + 1);





//					Setter_p2k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				System.Byte? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetByte(buffer, ptrToNullable + 1);





//					Setter_p3k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			{
//				UnitTest.Models.DayOfWeek? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{
//					fieldValue = (UnitTest.Models.DayOfWeek?)TypeResolveFactory.ResolveDesirialize(
//											typeof(UnitTest.Models.DayOfWeek?),
//											offset,
//											buff,
//											referenceMaping);




//					Setter_p4k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;


//			return entity;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}
//	public class c5 : IResolver<UnitTest.Models.c5>
//	{
//		public Action<UnitTest.Models.c5, System.Int32> Setter_Yeark__BackingField;

//		public Func<UnitTest.Models.c5, System.Int32> Getter_Yeark__BackingField;

//		public Action<UnitTest.Models.c5, System.Int32> Setter_Monthk__BackingField;

//		public Func<UnitTest.Models.c5, System.Int32> Getter_Monthk__BackingField;

//		public Action<UnitTest.Models.c5, System.Int32> Setter_Dayk__BackingField;

//		public Func<UnitTest.Models.c5, System.Int32> Getter_Dayk__BackingField;


//		TypeInfo typeInfo;

//		public c5()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c5));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 7095280));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c5, System.Int32>>(body, p1);
//				Getter_Yeark__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 7095280));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Yeark__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 56315736));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c5, System.Int32>>(body, p1);
//				Getter_Monthk__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 56315736));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Monthk__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 15992306));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c5, System.Int32>>(body, p1);
//				Getter_Dayk__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 15992306));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Dayk__BackingField = lambda.Compile();
//			}


//		}


//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return BitConverter.GetBytes(((short)-1));
//			}
//			BufferPtr ptr;
//			if (referenceMaping.TryGetValue(Entity, out ptr))
//			{
//				return BitConverter.GetBytes(ptr.position);
//			}
//			ptr = buff.Alloc(13);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			UnitTest.Models.c5 entity = (UnitTest.Models.c5)Entity;

//			{
//				System.Int32 value = Getter_Yeark__BackingField(entity);

//				BaseConvertor.Write32(buffer, offset, (byte*)&value);

//				offset += 4;

//			}
//			{
//				System.Int32 value = Getter_Monthk__BackingField(entity);

//				BaseConvertor.Write32(buffer, offset, (byte*)&value);

//				offset += 4;

//			}
//			{
//				System.Int32 value = Getter_Dayk__BackingField(entity);

//				BaseConvertor.Write32(buffer, offset, (byte*)&value);

//				offset += 4;

//			}

//			return BitConverter.GetBytes(position);
//		}


//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			if (referenceMaping.ContainsKey(position))
//			{
//				return referenceMaping[position];
//			}
//			offset = position;

//			var entity = (UnitTest.Models.c5)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c5));
//			referenceMaping.Add(position, entity);
//			offset++;
//			Setter_Yeark__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			Setter_Monthk__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			Setter_Dayk__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;


//			return entity;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}
//	public class c3 : IResolver<UnitTest.Models.c3>
//	{
//		public Action<UnitTest.Models.c3, System.String> Setter_p1k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p1k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p2k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p2k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p3k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p3k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p4k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p4k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p5k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p5k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p6k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p6k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p7k__BackingField;

//		public Func<UnitTest.Models.c3, System.String> Getter_p7k__BackingField;


//		TypeInfo typeInfo;

//		public c3()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c3));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 1821177));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 1821177));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35345840));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35345840));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54751106));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54751106));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 33575416));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 33575416));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53196878));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53196878));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 56144108));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 56144108));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61742061));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61742061));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}


//		}


//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return BitConverter.GetBytes(((short)-1));
//			}
//			BufferPtr ptr;
//			if (referenceMaping.TryGetValue(Entity, out ptr))
//			{
//				return BitConverter.GetBytes(ptr.position);
//			}
//			ptr = buff.Alloc(15);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			UnitTest.Models.c3 entity = (UnitTest.Models.c3)Entity;

//			{
//				System.String value = Getter_p1k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p2k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p5k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p6k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p7k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}

//			return BitConverter.GetBytes(position);
//		}


//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			if (referenceMaping.ContainsKey(position))
//			{
//				return referenceMaping[position];
//			}
//			offset = position;

//			var entity = (UnitTest.Models.c3)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c3));
//			referenceMaping.Add(position, entity);
//			offset++;
//			string p1k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p1k__BackingField.Invoke(entity, p1k__BackingField);
//			offset += 2;
//			string p2k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p2k__BackingField.Invoke(entity, p2k__BackingField);
//			offset += 2;
//			string p3k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField);
//			offset += 2;
//			string p4k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField);
//			offset += 2;
//			string p5k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p5k__BackingField.Invoke(entity, p5k__BackingField);
//			offset += 2;
//			string p6k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p6k__BackingField.Invoke(entity, p6k__BackingField);
//			offset += 2;
//			string p7k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p7k__BackingField.Invoke(entity, p7k__BackingField);
//			offset += 2;


//			return entity;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}
//	public class StringArrayResolver : IResolver<System.String[]>
//	{
//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			offset = position;

//			int arrayLenght = BaseConvertor.GetInt(buffer, offset);

//			System.String[] array = new System.String[arrayLenght];

//			referenceMaping.Add(position, array);

//			offset += 4;

//			for (int i = 0; i < arrayLenght; i++)
//			{
//				array[i] = DesirializeString(offset, buff, referenceMaping);
//				offset += 2;
//			}
//			return array;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}

//	public class Int32ArrayResolver : IResolver<System.Int32[]>
//	{
//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			offset = position;

//			int arrayLenght = BaseConvertor.GetInt(buffer, offset);

//			System.Int32[] array = new System.Int32[arrayLenght];

//			referenceMaping.Add(position, array);

//			offset += 4;

//			for (int i = 0; i < arrayLenght; i++)
//			{
//				array[i] = BaseConvertor.GetInt(buffer, offset);
//				offset += 4;
//			}
//			return array;
//		}

//	}
//	public class StrongStructure : IResolver<UnitTest.Models.StrongStructure>
//	{
//		public Action<UnitTest.Models.StrongStructure, System.Boolean> Setter_p1k__BackingField;

//		public Func<UnitTest.Models.StrongStructure, System.Boolean> Getter_p1k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, System.Guid> Setter_p2k__BackingField;

//		public Func<UnitTest.Models.StrongStructure, System.Guid> Getter_p2k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, System.String> Setter_p3k__BackingField;

//		public Func<UnitTest.Models.StrongStructure, System.String> Getter_p3k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1> Setter_p4k__BackingField;

//		public Func<UnitTest.Models.StrongStructure, UnitTest.Models.c1> Getter_p4k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, System.Int32> Setter_p5k__BackingField;

//		public Func<UnitTest.Models.StrongStructure, System.Int32> Getter_p5k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum> Setter_e1;

//		public Func<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum> Getter_e1;


//		TypeInfo typeInfo;

//		public StrongStructure()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.StrongStructure));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30452247));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30452247));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16014678));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Guid>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16014678));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Guid>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46340781));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.String>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46340781));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23960260));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c1), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23960260));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17446390));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Int32>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17446390));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Int32>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45943265));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum>>(body, p1);
//				Getter_e1 = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.TestEnum), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45943265));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum>>(body, p1, p2);
//				Setter_e1 = lambda.Compile();
//			}


//		}


//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return BitConverter.GetBytes(((short)-1));
//			}
//			BufferPtr ptr;
//			if (referenceMaping.TryGetValue(Entity, out ptr))
//			{
//				return BitConverter.GetBytes(ptr.position);
//			}
//			ptr = buff.Alloc(36);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			UnitTest.Models.StrongStructure entity = (UnitTest.Models.StrongStructure)Entity;

//			{
//				System.Boolean value = Getter_p1k__BackingField(entity);

//				BaseConvertor.Write8(buffer, offset, (byte*)&value);

//				offset += 1;

//			}
//			{
//				System.Guid value = Getter_p2k__BackingField(entity);

//				BaseConvertor.Write128(buffer, offset, (byte*)&value);

//				offset += 16;

//			}
//			{
//				System.String value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c1 value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32 value = Getter_p5k__BackingField(entity);

//				BaseConvertor.Write32(buffer, offset, (byte*)&value);

//				offset += 4;

//			}
//			{
//				System.String[] value = entity.p6;

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32[] value = entity.p7;

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32[] value = entity.p8;

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.TestEnum value = Getter_e1(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}

//			return BitConverter.GetBytes(position);
//		}


//		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;

//			short position = (short)offset == 0 ?
//				 (short)0 : BaseConvertor.GetShort(buffer, offset);

//			if (position == -1)
//			{
//				return null;
//			}
//			if (referenceMaping.ContainsKey(position))
//			{
//				return referenceMaping[position];
//			}
//			offset = position;

//			var entity = (UnitTest.Models.StrongStructure)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.StrongStructure));
//			referenceMaping.Add(position, entity);
//			offset++;
//			Setter_p1k__BackingField.Invoke(entity, BaseConvertor.GetBool(buffer, offset));
//			offset += 1;
//			Setter_p2k__BackingField.Invoke(entity, BaseConvertor.GetGuid(buffer, offset));
//			offset += 16;
//			string p3k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField);
//			offset += 2;

//			UnitTest.Models.c1 p4k__BackingField_Result = (UnitTest.Models.c1)TypeResolveFactory.ResolveDesirialize(
//																typeof(UnitTest.Models.c1),
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 2;
//			Setter_p5k__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;

//			System.String[] p6_Result = (System.String[])TypeResolveFactory.ResolveDesirialize(
//																typeof(System.String[]),
//																offset,
//																buff,
//																referenceMaping);

//			entity.p6 = p6_Result;
//			offset += 2;

//			System.Int32[] p7_Result = (System.Int32[])TypeResolveFactory.ResolveDesirialize(
//																typeof(System.Int32[]),
//																offset,
//																buff,
//																referenceMaping);

//			entity.p7 = p7_Result;
//			offset += 2;

//			System.Int32[] p8_Result = (System.Int32[])TypeResolveFactory.ResolveDesirialize(
//																typeof(System.Int32[]),
//																offset,
//																buff,
//																referenceMaping);

//			entity.p8 = p8_Result;
//			offset += 2;
//			Setter_e1.Invoke(entity, (UnitTest.Models.TestEnum)BaseConvertor.GetInt(buffer, offset));
//			offset += 4;


//			return entity;
//		}

//		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
//		{
//			fixed (byte* buf = buffer.CurrentBuffer)
//			{
//				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
//				if (position == -1)
//				{
//					return null;
//				}
//				if (referenceMaping.ContainsKey(position))
//				{
//					return referenceMaping[position] as string;
//				}
//				int lenght = *(int*)(buf + position);

//				fixed (char* charP = new char[lenght])
//				{
//					int bytesForCopy = sizeof(char) * lenght;
//					byte* source = (buf + position + sizeof(int));
//					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
//					return new String(charP);
//				}
//			}
//		}
//	}
//}