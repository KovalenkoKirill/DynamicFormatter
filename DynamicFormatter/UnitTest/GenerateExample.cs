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

//		public Action<UnitTest.Models.c1, object> Setter_p16k__BackingField;

//		public Func<UnitTest.Models.c1, object> Getter_p16k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.c3> Setter_p17k__BackingField;

//		public Func<UnitTest.Models.c1, UnitTest.Models.c3> Getter_p17k__BackingField;


//		TypeInfo typeInfo;

//		public c1()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c1));

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44177654));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.Guid>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44177654));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 22226817));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.Guid>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 22226817));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 18626439));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 18626439));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 15112338));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.e1>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e1), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 15112338));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e1>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36893403));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.e2>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e2), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36893403));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e2>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 29514189));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 29514189));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 25430658));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 25430658));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30963268));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30963268));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17119500));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17119500));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61381638));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61381638));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 47596553));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 47596553));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17411106));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.e3>>(body, p1);
//				Getter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e3), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17411106));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e3>>(body, p1, p2);
//				Setter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17173514));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.String>>(body, p1);
//				Getter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 17173514));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30296746));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.DateTime>>(body, p1);
//				Getter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.DateTime), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30296746));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.DateTime>>(body, p1, p2);
//				Setter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 64658589));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, System.Guid>>(body, p1);
//				Getter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 64658589));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 39087788));
//				body = Expression.Convert(body, typeof(object));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, object>>(body, p1);
//				Getter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(object), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 39087788));
//				BinaryExpression body = Expression.Assign(m1, Expression.Convert(p2, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 39087788).FieldType));

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, object>>(body, p1, p2);
//				Setter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36453459));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c1, UnitTest.Models.c3>>(body, p1);
//				Getter_p17k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c3), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36453459));
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

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.e1 value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(36528427, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}
//			{
//				UnitTest.Models.e2 value = Getter_p5k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(33166512, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}
//			{
//				System.String value = Getter_p6k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p7k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p8k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p9k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p10k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p11k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.e3 value = Getter_p12k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(16098066, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 4;

//			}
//			{
//				System.String value = Getter_p13k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
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
//				object value = Getter_p16k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(5603890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c3 value = Getter_p17k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(53324351, value, buff, referenceMaping);
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

//			var entity = (UnitTest.Models.c1)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
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

//			object p16k__BackingField_Result = (object)TypeResolveFactory.ResolveDesirialize(
//																5603890,
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p16k__BackingField.Invoke(entity, p16k__BackingField_Result);
//			offset += 2;

//			UnitTest.Models.c3 p17k__BackingField_Result = (UnitTest.Models.c3)TypeResolveFactory.ResolveDesirialize(
//																53324351,
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
//	public class c2 : IResolver<object>
//	{
//		Func<object, System.String, object> Setter_p1k__BackingField;


//		public Func<object, System.String> Getter_p1k__BackingField;

//		Func<object, System.String, object> Setter_p2k__BackingField;


//		public Func<object, System.String> Getter_p2k__BackingField;

//		Func<object, UnitTest.Models.c4, object> Setter_p3k__BackingField;


//		public Func<object, UnitTest.Models.c4> Getter_p3k__BackingField;

//		Func<object, UnitTest.Models.c5, object> Setter_p4k__BackingField;


//		public Func<object, UnitTest.Models.c5> Getter_p4k__BackingField;

//		Func<object, System.String, object> Setter_p5k__BackingField;


//		public Func<object, System.String> Getter_p5k__BackingField;

//		Func<object, System.Int64?, object> Setter_p6k__BackingField;


//		public Func<object, System.Int64?> Getter_p6k__BackingField;

//		Func<object, System.Boolean?, object> Setter_p7k__BackingField;


//		public Func<object, System.Boolean?> Getter_p7k__BackingField;

//		Func<object, System.String, object> Setter_p8k__BackingField;


//		public Func<object, System.String> Getter_p8k__BackingField;

//		Func<object, System.String, object> Setter_p9k__BackingField;


//		public Func<object, System.String> Getter_p9k__BackingField;

//		Func<object, System.String, object> Setter_p10k__BackingField;


//		public Func<object, System.String> Getter_p10k__BackingField;

//		Func<object, System.String, object> Setter_p11k__BackingField;


//		public Func<object, System.String> Getter_p11k__BackingField;

//		Func<object, System.String, object> Setter_p12k__BackingField;


//		public Func<object, System.String> Getter_p12k__BackingField;

//		Func<object, System.String, object> Setter_p13k__BackingField;


//		public Func<object, System.String> Getter_p13k__BackingField;

//		Func<object, System.Int64?, object> Setter_p14k__BackingField;


//		public Func<object, System.Int64?> Getter_p14k__BackingField;

//		Func<object, System.Int32?, object> Setter_p15k__BackingField;


//		public Func<object, System.Int32?> Getter_p15k__BackingField;

//		Func<object, System.Boolean?, object> Setter_p16k__BackingField;


//		public Func<object, System.Boolean?> Getter_p16k__BackingField;

//		Func<object, System.Int32?, object> Setter_p17k__BackingField;


//		public Func<object, System.Int32?> Getter_p17k__BackingField;

//		Func<object, System.Int32?, object> Setter_p18k__BackingField;


//		public Func<object, System.Int32?> Getter_p18k__BackingField;


//		TypeInfo typeInfo;

//		public c2()
//		{
//			this.typeInfo = TypeInfo.instanse(5603890);

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19508958));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19508958));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 18516527));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 18516527));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2190341));
//				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c4>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c4), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2190341));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c4, object>>(block, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 34999721));
//				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c5>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c5), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 34999721));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c5, object>>(block, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 50212076));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 50212076));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 13069983));
//				var lambda = Expression.Lambda<Func<object, System.Int64?>>(body, p1);
//				Getter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int64?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 13069983));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Int64?, object>>(block, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23178896));
//				var lambda = Expression.Lambda<Func<object, System.Boolean?>>(body, p1);
//				Getter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23178896));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Boolean?, object>>(block, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 43536272));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p8k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 43536272));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p8k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 41585520));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p9k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 41585520));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p9k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35832574));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p10k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35832574));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p10k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61656587));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p11k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61656587));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p11k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53168999));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p12k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53168999));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p12k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23851235));
//				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
//				Getter_p13k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23851235));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
//				Setter_p13k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 39508813));
//				var lambda = Expression.Lambda<Func<object, System.Int64?>>(body, p1);
//				Getter_p14k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int64?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 39508813));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Int64?, object>>(block, p1, p2);
//				Setter_p14k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 64282230));
//				var lambda = Expression.Lambda<Func<object, System.Int32?>>(body, p1);
//				Getter_p15k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 64282230));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Int32?, object>>(block, p1, p2);
//				Setter_p15k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12113199));
//				var lambda = Expression.Lambda<Func<object, System.Boolean?>>(body, p1);
//				Getter_p16k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12113199));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Boolean?, object>>(block, p1, p2);
//				Setter_p16k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 50852166));
//				var lambda = Expression.Lambda<Func<object, System.Int32?>>(body, p1);
//				Getter_p17k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 50852166));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Int32?, object>>(block, p1, p2);
//				Setter_p17k__BackingField = lambda.Compile();
//			}
//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				Expression body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 48565132));
//				var lambda = Expression.Lambda<Func<object, System.Int32?>>(body, p1);
//				Getter_p18k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");
//				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
//				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

//				LabelTarget returnTarget = Expression.Label(typeof(object));


//				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
//				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 48565132));

//				var assign = Expression.Assign(makeMeberAccess, p2);
//				var assingnToResult = Expression.Assign(
//												retObjectParam,
//												 Expression.Convert(SturctObjectParam, typeof(object)));

//				GotoExpression returnExpression = Expression.Return(returnTarget,
//																retObjectParam, typeof(object));

//				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

//				BlockExpression block = Expression.Block(
//														new ParameterExpression[] { SturctObjectParam, retObjectParam },
//														assignToRet,
//														assign,
//														assingnToResult,
//														returnExpression,
//														returnLabel);
//				var lambda = Expression.Lambda<Func<object, System.Int32?, object>>(block, p1, p2);
//				Setter_p18k__BackingField = lambda.Compile();
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
//			ptr = buff.Alloc(37);
//			short position = ptr.position;
//			int offset = (int)position;
//			byte[] buffer = buff.CurrentBuffer;

//			object entity = (object)Entity;

//			{
//				System.String value = Getter_p1k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p2k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c4 value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(50848483, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c5 value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(23181364, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p5k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int64? value = Getter_p6k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(61342683, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Boolean? value = Getter_p7k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(16678014, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p8k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p9k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p10k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p11k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p12k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p13k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int64? value = Getter_p14k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(61342683, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32? value = Getter_p15k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(45279885, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Boolean? value = Getter_p16k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(16678014, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32? value = Getter_p17k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(45279885, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32? value = Getter_p18k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(45279885, value, buff, referenceMaping);
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

//			var entity = (object)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
//			referenceMaping.Add(position, entity);
//			offset++;
//			string p1k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p1k__BackingField.Invoke(entity, p1k__BackingField);
//			offset += 2;
//			string p2k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p2k__BackingField.Invoke(entity, p2k__BackingField);
//			offset += 2;

//			UnitTest.Models.c4 p3k__BackingField_Result = (UnitTest.Models.c4)TypeResolveFactory.ResolveDesirialize(
//																50848483,
//																offset,
//																buff,
//																referenceMaping);


//			entity = Setter_p3k__BackingField.Invoke(entity, p3k__BackingField_Result);
//			offset += 2;

//			UnitTest.Models.c5 p4k__BackingField_Result = (UnitTest.Models.c5)TypeResolveFactory.ResolveDesirialize(
//																23181364,
//																offset,
//																buff,
//																referenceMaping);


//			entity = Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 2;
//			string p5k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p5k__BackingField.Invoke(entity, p5k__BackingField);
//			offset += 2;
//			{
//				System.Int64? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetLong(buffer, ptrToNullable + 1);





//					entity = Setter_p6k__BackingField.Invoke(entity, fieldValue);

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





//					entity = Setter_p7k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;
//			string p8k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p8k__BackingField.Invoke(entity, p8k__BackingField);
//			offset += 2;
//			string p9k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p9k__BackingField.Invoke(entity, p9k__BackingField);
//			offset += 2;
//			string p10k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p10k__BackingField.Invoke(entity, p10k__BackingField);
//			offset += 2;
//			string p11k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p11k__BackingField.Invoke(entity, p11k__BackingField);
//			offset += 2;
//			string p12k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p12k__BackingField.Invoke(entity, p12k__BackingField);
//			offset += 2;
//			string p13k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			entity = Setter_p13k__BackingField.Invoke(entity, p13k__BackingField);
//			offset += 2;
//			{
//				System.Int64? fieldValue = null;
//				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
//				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
//				if (hasValue)
//				{

//					fieldValue = BaseConvertor.GetLong(buffer, ptrToNullable + 1);





//					entity = Setter_p14k__BackingField.Invoke(entity, fieldValue);

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





//					entity = Setter_p15k__BackingField.Invoke(entity, fieldValue);

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





//					entity = Setter_p16k__BackingField.Invoke(entity, fieldValue);

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





//					entity = Setter_p17k__BackingField.Invoke(entity, fieldValue);

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





//					entity = Setter_p18k__BackingField.Invoke(entity, fieldValue);

//				}
//			}

//			offset += 2;

//			return (object)entity;



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
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 10257073));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, System.Byte?>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 10257073));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53944861));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, System.Byte?>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53944861));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62599984));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, System.Byte?>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62599984));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19784333));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.DayOfWeek?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19784333));
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
//			DynamicBuffer.BufferPtr ptr;
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

//				byte[] result = TypeResolveFactory.ResolveSerialize(36201927, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Byte? value = Getter_p2k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(36201927, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Byte? value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(36201927, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.DayOfWeek? value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(35212414, value, buff, referenceMaping);
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

//			var entity = (UnitTest.Models.c4)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
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
//																	35212414,
//																	offset,
//																	buff,
//																	referenceMaping);




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
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61151430));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c5, System.Int32>>(body, p1);
//				Getter_Yeark__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61151430));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Yeark__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23663325));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c5, System.Int32>>(body, p1);
//				Getter_Monthk__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 23663325));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Monthk__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 38368963));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c5, System.Int32>>(body, p1);
//				Getter_Dayk__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 38368963));
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
//			DynamicBuffer.BufferPtr ptr;
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

//			var entity = (UnitTest.Models.c5)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
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
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54719442));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54719442));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2850719));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2850719));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 1163494));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 1163494));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62521017));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62521017));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12263577));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12263577));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 47670010));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 47670010));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12429244));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.c3, System.String>>(body, p1);
//				Getter_p7k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12429244));
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
//			DynamicBuffer.BufferPtr ptr;
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

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p2k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p3k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p5k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p6k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.String value = Getter_p7k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
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

//			var entity = (UnitTest.Models.c3)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
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
//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			int size = 4;

//			if (Entity == null)
//			{
//				return BitConverter.GetBytes((short)-1);
//			}

//			if (referenceMaping.ContainsKey(Entity))
//			{
//				return BitConverter.GetBytes(referenceMaping[Entity].position);
//			}

//			System.String[] array = (System.String[])Entity;

//			size += 2 * array.Length;

//			var ptr = buff.Alloc(size);

//			byte[] buffer = buff.CurrentBuffer;

//			referenceMaping.Add(Entity, ptr);

//			int offset = ptr.position;

//			BaseConvertor.Write32(buffer, offset, (byte*)array.Length);

//			offset += 4;

//			for (int i = 0; i < array.Length; i++)
//			{
//				System.String value = array[i];


//				byte[] result = SerializeString(value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);


//				offset += 2;
//			}

//			return BitConverter.GetBytes(ptr.position);
//		}

//		public unsafe byte[] SerializeString(object Entity, DynamicBuffer buf, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			if (Entity == null)
//			{
//				return Сonstants.nullPtrBytres;
//			}
//			if (referenceMaping.ContainsKey(Entity))
//			{
//				var bufferPtr = referenceMaping[Entity];
//				return BitConverter.GetBytes(bufferPtr.position);
//			}
//			int charSize = sizeof(char);
//			string entity = (string)Entity;
//			int size = charSize * entity.Length + sizeof(int);
//			var ptr = buf.Alloc(size);
//			byte[] buffer = buf.CurrentBuffer;
//			int offset = ptr.position;

//			int lenght = entity.Length;

//			BaseConvertor.Write32(buffer, offset, (byte*)&lenght);

//			offset += sizeof(int);

//			fixed (char* str = entity)
//			fixed (byte* bufferPtr = buffer)
//			{
//				int bytesToCopy = charSize * entity.Length;
//				Buffer.MemoryCopy(str, bufferPtr + offset, bytesToCopy, bytesToCopy);
//			}

//			return BitConverter.GetBytes(ptr.position);
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
//		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
//		{
//			int size = 4;

//			if (Entity == null)
//			{
//				return BitConverter.GetBytes((short)-1);
//			}

//			if (referenceMaping.ContainsKey(Entity))
//			{
//				return BitConverter.GetBytes(referenceMaping[Entity].position);
//			}

//			System.Int32[] array = (System.Int32[])Entity;

//			size += 4 * array.Length;

//			var ptr = buff.Alloc(size);

//			byte[] buffer = buff.CurrentBuffer;

//			referenceMaping.Add(Entity, ptr);

//			int offset = ptr.position;

//			BaseConvertor.Write32(buffer, offset, (byte*)array.Length);

//			offset += 4;

//			for (int i = 0; i < array.Length; i++)
//			{
//				System.Int32 value = array[i];


//				BaseConvertor.Write32(buffer, offset, (byte*)&value);


//				offset += 4;
//			}

//			return BitConverter.GetBytes(ptr.position);
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
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2282372));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1);
//				Getter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2282372));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30709776));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Guid>>(body, p1);
//				Getter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30709776));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Guid>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59863213));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.String>>(body, p1);
//				Getter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59863213));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16143157));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1);
//				Getter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c1), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16143157));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 21889970));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Int32>>(body, p1);
//				Getter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 21889970));
//				BinaryExpression body = Expression.Assign(m1, p2);

//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Int32>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				Expression body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 27594380));
//				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum>>(body, p1);
//				Getter_e1 = lambda.Compile();
//			}

//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.TestEnum), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 27594380));
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
//			DynamicBuffer.BufferPtr ptr;
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

//				byte[] result = TypeResolveFactory.ResolveSerialize(30015890, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.c1 value = Getter_p4k__BackingField(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(22494152, value, buff, referenceMaping);
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

//				byte[] result = TypeResolveFactory.ResolveSerialize(41622463, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32[] value = entity.p7;

//				byte[] result = TypeResolveFactory.ResolveSerialize(17822266, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				System.Int32[] value = entity.p8;

//				byte[] result = TypeResolveFactory.ResolveSerialize(17822266, value, buff, referenceMaping);
//				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

//				offset += 2;

//			}
//			{
//				UnitTest.Models.TestEnum value = Getter_e1(entity);

//				byte[] result = TypeResolveFactory.ResolveSerialize(50785559, value, buff, referenceMaping);
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

//			var entity = (UnitTest.Models.StrongStructure)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
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
//																22494152,
//																offset,
//																buff,
//																referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 2;
//			Setter_p5k__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;

//			System.String[] p6_Result = (System.String[])TypeResolveFactory.ResolveDesirialize(
//																41622463,
//																offset,
//																buff,
//																referenceMaping);

//			entity.p6 = p6_Result;
//			offset += 2;

//			System.Int32[] p7_Result = (System.Int32[])TypeResolveFactory.ResolveDesirialize(
//																17822266,
//																offset,
//																buff,
//																referenceMaping);

//			entity.p7 = p7_Result;
//			offset += 2;

//			System.Int32[] p8_Result = (System.Int32[])TypeResolveFactory.ResolveDesirialize(
//																17822266,
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