using System;
using DynamicFormatter.interfaces;
using DynamicFormatter.Generator;
using DynamicFormatter.Extentions;
using System.Runtime.Serialization;
using DynamicFormatter.Models;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace DynamicFormatter.Dynamic
{
	public class JustSimpleClass : IResolver<UnitTest.Models.JustSimpleClass>
	{
		Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass> Setter_firstIntk__BackingField;

		Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass> Setter_secondIntk__BackingField;

		Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass> Setter_thirdIntk__BackingField;

		Func<UnitTest.Models.JustSimpleClass, System.String, UnitTest.Models.JustSimpleClass> Setter_test;


		TypeInfo typeInfo;

		public JustSimpleClass()
		{
			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.JustSimpleClass));


			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 5523950));

				var assign = Expression.Assign(makeMeberAccess, p2);
				var assingnToResult = Expression.Assign(
												retObjectParam,
												(SturctObjectParam));

				GotoExpression returnExpression = Expression.Return(returnTarget,
																retObjectParam, typeof(UnitTest.Models.JustSimpleClass));

				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

				BlockExpression block = Expression.Block(
														new ParameterExpression[] { SturctObjectParam, retObjectParam },
														assignToRet,
														assign,
														assingnToResult,
														returnExpression,
														returnLabel);
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass>>(block, p1, p2);
				Setter_firstIntk__BackingField = lambda.Compile();
			}


			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 31008595));

				var assign = Expression.Assign(makeMeberAccess, p2);
				var assingnToResult = Expression.Assign(
												retObjectParam,
												(SturctObjectParam));

				GotoExpression returnExpression = Expression.Return(returnTarget,
																retObjectParam, typeof(UnitTest.Models.JustSimpleClass));

				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

				BlockExpression block = Expression.Block(
														new ParameterExpression[] { SturctObjectParam, retObjectParam },
														assignToRet,
														assign,
														assingnToResult,
														returnExpression,
														returnLabel);
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass>>(block, p1, p2);
				Setter_secondIntk__BackingField = lambda.Compile();
			}


			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 43437836));

				var assign = Expression.Assign(makeMeberAccess, p2);
				var assingnToResult = Expression.Assign(
												retObjectParam,
												(SturctObjectParam));

				GotoExpression returnExpression = Expression.Return(returnTarget,
																retObjectParam, typeof(UnitTest.Models.JustSimpleClass));

				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

				BlockExpression block = Expression.Block(
														new ParameterExpression[] { SturctObjectParam, retObjectParam },
														assignToRet,
														assign,
														assingnToResult,
														returnExpression,
														returnLabel);
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass>>(block, p1, p2);
				Setter_thirdIntk__BackingField = lambda.Compile();
			}


			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 29634628));

				var assign = Expression.Assign(makeMeberAccess, p2);
				var assingnToResult = Expression.Assign(
												retObjectParam,
												(SturctObjectParam));

				GotoExpression returnExpression = Expression.Return(returnTarget,
																retObjectParam, typeof(UnitTest.Models.JustSimpleClass));

				LabelExpression returnLabel = Expression.Label(returnTarget, retObjectParam);

				BlockExpression block = Expression.Block(
														new ParameterExpression[] { SturctObjectParam, retObjectParam },
														assignToRet,
														assign,
														assingnToResult,
														returnExpression,
														returnLabel);
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.String, UnitTest.Models.JustSimpleClass>>(block, p1, p2);
				Setter_test = lambda.Compile();
			}


		}

		public UnitTest.Models.JustSimpleClass instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
		{
			byte[] buffer = buff.CurrentBuffer;
			var entity = (UnitTest.Models.JustSimpleClass)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.JustSimpleClass));
			offset++;
			entity = Setter_firstIntk__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
			offset += 4;
			entity = Setter_secondIntk__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
			offset += 4;
			entity = Setter_thirdIntk__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
			offset += 4;
			string test = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_test.Invoke(entity, test);
			offset += 2;
			string azaza = DesirializeString(offset, buff, referenceMaping);
			entity.azaza = azaza;
			offset += 2;
			short ptrForss = BaseConvertor.GetShort(buffer, offset);

			UnitTest.Models.SecondSimpleClass ss_Result = (UnitTest.Models.SecondSimpleClass)TypeResolveFactory.ResolveDesirialize(
																	typeof(UnitTest.Models.SecondSimpleClass),
																	ptrForss,
																	buff,
																	referenceMaping);

			entity.ss = ss_Result;
			offset += 2;
			return entity;
		}

		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			fixed (byte* buf = buffer.CurrentBuffer)
			{
				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
				if (position == -1)
				{
					return null;
				}
				if (referenceMaping.ContainsKey(position))
				{
					return referenceMaping[position] as string;
				}
				int lenght = *(int*)(buf + position);

				fixed (char* charP = new char[lenght])
				{
					int bytesForCopy = sizeof(char) * lenght;
					byte* source = (buf + position + sizeof(int));
					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
					return new String(charP);
				}
			}
		}
	}
	public class SecondSimpleClass : IResolver<UnitTest.Models.SecondSimpleClass>
	{
		public Action<UnitTest.Models.SecondSimpleClass, System.Int32> Setter_z;

		public Action<UnitTest.Models.SecondSimpleClass, System.Int32> Setter_d;


		TypeInfo typeInfo;

		public SecondSimpleClass()
		{
			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.SecondSimpleClass));


			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 54666846));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.SecondSimpleClass, System.Int32>>(body, p1, p2);
				Setter_z = lambda.Compile();
			}


			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57213402));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.SecondSimpleClass, System.Int32>>(body, p1, p2);
				Setter_d = lambda.Compile();
			}


		}

		public UnitTest.Models.SecondSimpleClass instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
		{
			byte[] buffer = buff.CurrentBuffer;
			var entity = (UnitTest.Models.SecondSimpleClass)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.SecondSimpleClass));
			offset++;
			Setter_z.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
			offset += 4;
			Setter_d.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
			offset += 4;
			return entity;
		}

		public unsafe string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
		{
			fixed (byte* buf = buffer.CurrentBuffer)
			{
				short position = offset == 0 ? (short)0 : *(short*)(buf + offset);
				if (position == -1)
				{
					return null;
				}
				if (referenceMaping.ContainsKey(position))
				{
					return referenceMaping[position] as string;
				}
				int lenght = *(int*)(buf + position);

				fixed (char* charP = new char[lenght])
				{
					int bytesForCopy = sizeof(char) * lenght;
					byte* source = (buf + position + sizeof(int));
					Buffer.MemoryCopy(source, charP, bytesForCopy, bytesForCopy);
					return new String(charP);
				}
			}
		}
	}
}