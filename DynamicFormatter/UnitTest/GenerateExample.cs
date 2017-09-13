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

//		public Action<UnitTest.Models.c1, System.Guid> Setter_p2k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p3k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.e1> Setter_p4k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.e2> Setter_p5k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p6k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p7k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p8k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p9k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p10k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p11k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.e3> Setter_p12k__BackingField;

//		public Action<UnitTest.Models.c1, System.String> Setter_p13k__BackingField;

//		public Action<UnitTest.Models.c1, System.DateTime> Setter_p14k__BackingField;

//		public Action<UnitTest.Models.c1, System.Guid> Setter_p15k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.c2> Setter_p16k__BackingField;

//		public Action<UnitTest.Models.c1, UnitTest.Models.c3> Setter_p17k__BackingField;


//		TypeInfo typeInfo;

//		public c1()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c1));


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 48795752));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 20806745));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 60729050));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e1), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 20277347));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e1>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e2), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 40311019));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e2>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57968618));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 42529881));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61899952));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p8k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 11419366));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p9k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 36274291));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p10k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53147216));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p11k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.e3), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 56694004));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.e3>>(body, p1, p2);
//				Setter_p12k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2363480));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.String>>(body, p1, p2);
//				Setter_p13k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.DateTime), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61953012));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.DateTime>>(body, p1, p2);
//				Setter_p14k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 26639039));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, System.Guid>>(body, p1, p2);
//				Setter_p15k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c2), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46384945));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.c2>>(body, p1, p2);
//				Setter_p16k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c1), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c3), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54401859));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c1, UnitTest.Models.c3>>(body, p1, p2);
//				Setter_p17k__BackingField = lambda.Compile();
//			}


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

//			var entity = (UnitTest.Models.c1)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c1));
//			offset++;

//			System.Guid p1k__BackingField_Result = (System.Guid)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Guid),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p1k__BackingField.Invoke(entity, p1k__BackingField_Result);
//			offset += 16;

//			System.Guid p2k__BackingField_Result = (System.Guid)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Guid),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p2k__BackingField.Invoke(entity, p2k__BackingField_Result);
//			offset += 16;
//			string p3k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField);
//			offset += 2;

//			UnitTest.Models.e1 p4k__BackingField_Result = (UnitTest.Models.e1)TypeResolveFactory.ResolveDesirialize(
//												typeof(UnitTest.Models.e1),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 4;

//			UnitTest.Models.e2 p5k__BackingField_Result = (UnitTest.Models.e2)TypeResolveFactory.ResolveDesirialize(
//												typeof(UnitTest.Models.e2),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p5k__BackingField.Invoke(entity, p5k__BackingField_Result);
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

//			UnitTest.Models.e3 p12k__BackingField_Result = (UnitTest.Models.e3)TypeResolveFactory.ResolveDesirialize(
//												typeof(UnitTest.Models.e3),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p12k__BackingField.Invoke(entity, p12k__BackingField_Result);
//			offset += 4;
//			string p13k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p13k__BackingField.Invoke(entity, p13k__BackingField);
//			offset += 2;

//			System.DateTime p14k__BackingField_Result = (System.DateTime)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.DateTime),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p14k__BackingField.Invoke(entity, p14k__BackingField_Result);
//			offset += 8;

//			System.Guid p15k__BackingField_Result = (System.Guid)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Guid),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p15k__BackingField.Invoke(entity, p15k__BackingField_Result);
//			offset += 16;


//			UnitTest.Models.c2 p16k__BackingField_Result = (UnitTest.Models.c2)TypeResolveFactory.ResolveDesirialize(
//																	typeof(UnitTest.Models.c2),
//																	ptrForp16k__BackingField,
//																	offset,
//																	referenceMaping);


//			Setter_p16k__BackingField.Invoke(entity, p16k__BackingField_Result);
//			offset += 2;


//			UnitTest.Models.c3 p17k__BackingField_Result = (UnitTest.Models.c3)TypeResolveFactory.ResolveDesirialize(
//																	typeof(UnitTest.Models.c3),
//																	ptrForp17k__BackingField,
//																	offset,
//																	referenceMaping);


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

//		public Action<UnitTest.Models.c2, System.String> Setter_p2k__BackingField;

//		public Action<UnitTest.Models.c2, UnitTest.Models.c4> Setter_p3k__BackingField;

//		public Action<UnitTest.Models.c2, UnitTest.Models.c5> Setter_p4k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p5k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int64?> Setter_p6k__BackingField;

//		public Action<UnitTest.Models.c2, System.Boolean?> Setter_p7k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p8k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p9k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p10k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p11k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p12k__BackingField;

//		public Action<UnitTest.Models.c2, System.String> Setter_p13k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int64?> Setter_p14k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int32?> Setter_p15k__BackingField;

//		public Action<UnitTest.Models.c2, System.Boolean?> Setter_p16k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int32?> Setter_p17k__BackingField;

//		public Action<UnitTest.Models.c2, System.Int32?> Setter_p18k__BackingField;


//		TypeInfo typeInfo;

//		public c2()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c2));


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 47881589));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 42176571));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c4), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 4952852));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, UnitTest.Models.c4>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c5), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61053624));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, UnitTest.Models.c5>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 48144225));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int64?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53826756));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int64?>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45965852));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Boolean?>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 51124766));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p8k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45921029));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p9k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59899526));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p10k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 40608219));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p11k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 29806012));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p12k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 50493024));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.String>>(body, p1, p2);
//				Setter_p13k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int64?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 35588992));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int64?>>(body, p1, p2);
//				Setter_p14k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53588051));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int32?>>(body, p1, p2);
//				Setter_p15k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 4387730));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Boolean?>>(body, p1, p2);
//				Setter_p16k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 30476148));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int32?>>(body, p1, p2);
//				Setter_p17k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c2), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 61700530));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c2, System.Int32?>>(body, p1, p2);
//				Setter_p18k__BackingField = lambda.Compile();
//			}


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

//			var entity = (UnitTest.Models.c2)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c2));
//			offset++;
//			string p1k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p1k__BackingField.Invoke(entity, p1k__BackingField);
//			offset += 2;
//			string p2k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p2k__BackingField.Invoke(entity, p2k__BackingField);
//			offset += 2;


//			UnitTest.Models.c4 p3k__BackingField_Result = (UnitTest.Models.c4)TypeResolveFactory.ResolveDesirialize(
//																	typeof(UnitTest.Models.c4),
//																	ptrForp3k__BackingField,
//																	offset,
//																	referenceMaping);


//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField_Result);
//			offset += 2;


//			UnitTest.Models.c5 p4k__BackingField_Result = (UnitTest.Models.c5)TypeResolveFactory.ResolveDesirialize(
//																	typeof(UnitTest.Models.c5),
//																	ptrForp4k__BackingField,
//																	offset,
//																	referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 2;
//			string p5k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p5k__BackingField.Invoke(entity, p5k__BackingField);
//			offset += 2;

//			System.Int64? p6k__BackingField_Result = (System.Int64?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Int64?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p6k__BackingField.Invoke(entity, p6k__BackingField_Result);
//			offset += 2;

//			System.Boolean? p7k__BackingField_Result = (System.Boolean?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Boolean?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p7k__BackingField.Invoke(entity, p7k__BackingField_Result);
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

//			System.Int64? p14k__BackingField_Result = (System.Int64?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Int64?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p14k__BackingField.Invoke(entity, p14k__BackingField_Result);
//			offset += 2;

//			System.Int32? p15k__BackingField_Result = (System.Int32?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Int32?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p15k__BackingField.Invoke(entity, p15k__BackingField_Result);
//			offset += 2;

//			System.Boolean? p16k__BackingField_Result = (System.Boolean?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Boolean?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p16k__BackingField.Invoke(entity, p16k__BackingField_Result);
//			offset += 2;

//			System.Int32? p17k__BackingField_Result = (System.Int32?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Int32?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p17k__BackingField.Invoke(entity, p17k__BackingField_Result);
//			offset += 2;

//			System.Int32? p18k__BackingField_Result = (System.Int32?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Int32?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p18k__BackingField.Invoke(entity, p18k__BackingField_Result);
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

//		public Action<UnitTest.Models.c4, System.Byte?> Setter_p2k__BackingField;

//		public Action<UnitTest.Models.c4, System.Byte?> Setter_p3k__BackingField;

//		public Action<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?> Setter_p4k__BackingField;


//		TypeInfo typeInfo;

//		public c4()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c4));


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 53703054));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 28349830));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Byte?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54816296));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, System.Byte?>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c4), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.DayOfWeek?), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 34918831));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c4, UnitTest.Models.DayOfWeek?>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}


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

//			var entity = (UnitTest.Models.c4)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c4));
//			offset++;

//			System.Byte? p1k__BackingField_Result = (System.Byte?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Byte?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p1k__BackingField.Invoke(entity, p1k__BackingField_Result);
//			offset += 2;

//			System.Byte? p2k__BackingField_Result = (System.Byte?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Byte?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p2k__BackingField.Invoke(entity, p2k__BackingField_Result);
//			offset += 2;

//			System.Byte? p3k__BackingField_Result = (System.Byte?)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Byte?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField_Result);
//			offset += 2;

//			UnitTest.Models.DayOfWeek? p4k__BackingField_Result = (UnitTest.Models.DayOfWeek?)TypeResolveFactory.ResolveDesirialize(
//												typeof(UnitTest.Models.DayOfWeek?),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
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

//		public Action<UnitTest.Models.c5, System.Int32> Setter_Monthk__BackingField;

//		public Action<UnitTest.Models.c5, System.Int32> Setter_Dayk__BackingField;


//		TypeInfo typeInfo;

//		public c5()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c5));


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45691344));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Yeark__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 47174597));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Monthk__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c5), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2000966));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c5, System.Int32>>(body, p1, p2);
//				Setter_Dayk__BackingField = lambda.Compile();
//			}


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

//			var entity = (UnitTest.Models.c5)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c5));
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

//		public Action<UnitTest.Models.c3, System.String> Setter_p2k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p3k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p4k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p5k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p6k__BackingField;

//		public Action<UnitTest.Models.c3, System.String> Setter_p7k__BackingField;


//		TypeInfo typeInfo;

//		public c3()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.c3));


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57568131));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19614112));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45941824));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 20563740));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 65286507));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54922726));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p6k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.c3), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44993220));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.c3, System.String>>(body, p1, p2);
//				Setter_p7k__BackingField = lambda.Compile();
//			}


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

//			var entity = (UnitTest.Models.c3)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.c3));
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
//	public class StrongStructure : IResolver<UnitTest.Models.StrongStructure>
//	{
//		public Action<UnitTest.Models.StrongStructure, System.Boolean> Setter_p1k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, System.Guid> Setter_p2k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, System.String> Setter_p3k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1> Setter_p4k__BackingField;

//		public Action<UnitTest.Models.StrongStructure, System.Int32> Setter_p5k__BackingField;


//		TypeInfo typeInfo;

//		public StrongStructure()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.StrongStructure));


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 65499460));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1, p2);
//				Setter_p1k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 8541105));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Guid>>(body, p1, p2);
//				Setter_p2k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16521053));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.String>>(body, p1, p2);
//				Setter_p3k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c1), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 14086080));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1, p2);
//				Setter_p4k__BackingField = lambda.Compile();
//			}


//			{
//				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
//				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

//				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 66699219));
//				BinaryExpression body = Expression.Assign(m1, p2);
//				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Int32>>(body, p1, p2);
//				Setter_p5k__BackingField = lambda.Compile();
//			}


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

//			var entity = (UnitTest.Models.StrongStructure)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.StrongStructure));
//			offset++;
//			Setter_p1k__BackingField.Invoke(entity, BaseConvertor.GetBool(buffer, offset));
//			offset += 1;

//			System.Guid p2k__BackingField_Result = (System.Guid)TypeResolveFactory.ResolveDesirialize(
//												typeof(System.Guid),
//												offset,
//												buff,
//												referenceMaping);


//			Setter_p2k__BackingField.Invoke(entity, p2k__BackingField_Result);
//			offset += 16;
//			string p3k__BackingField = DesirializeString(offset, buff, referenceMaping);
//			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField);
//			offset += 2;


//			UnitTest.Models.c1 p4k__BackingField_Result = (UnitTest.Models.c1)TypeResolveFactory.ResolveDesirialize(
//																	typeof(UnitTest.Models.c1),
//																	ptrForp4k__BackingField,
//																	offset,
//																	referenceMaping);


//			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
//			offset += 2;
//			Setter_p5k__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;


//			System.String[] p6_Result = (System.String[])TypeResolveFactory.ResolveDesirialize(
//																	typeof(System.String[]),
//																	ptrForp6,
//																	offset,
//																	referenceMaping);

//			entity.p6 = p6_Result;
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
//}