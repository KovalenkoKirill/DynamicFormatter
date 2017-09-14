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


		public Func<UnitTest.Models.JustSimpleClass, System.Int32> Getter_firstIntk__BackingField;

		Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass> Setter_secondIntk__BackingField;


		public Func<UnitTest.Models.JustSimpleClass, System.Int32> Getter_secondIntk__BackingField;

		Func<UnitTest.Models.JustSimpleClass, System.Int32, UnitTest.Models.JustSimpleClass> Setter_thirdIntk__BackingField;


		public Func<UnitTest.Models.JustSimpleClass, System.Int32> Getter_thirdIntk__BackingField;

		Func<UnitTest.Models.JustSimpleClass, System.String, UnitTest.Models.JustSimpleClass> Setter_test;


		public Func<UnitTest.Models.JustSimpleClass, System.String> Getter_test;


		TypeInfo typeInfo;

		public JustSimpleClass()
		{
			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.JustSimpleClass));

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16521053));
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.Int32>>(body, p1);
				Getter_firstIntk__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16521053));

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
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 11243366));
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.Int32>>(body, p1);
				Getter_secondIntk__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 11243366));

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
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 26262343));
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.Int32>>(body, p1);
				Getter_thirdIntk__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 26262343));

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
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 8625575));
				var lambda = Expression.Lambda<Func<UnitTest.Models.JustSimpleClass, System.String>>(body, p1);
				Getter_test = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.JustSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(UnitTest.Models.JustSimpleClass), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(UnitTest.Models.JustSimpleClass));


				var assignToRet = Expression.Assign(SturctObjectParam, p1);
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 8625575));

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


		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return BitConverter.GetBytes(((short)-1));
			}
			DynamicBuffer.BufferPtr ptr;
			if (referenceMaping.TryGetValue(Entity, out ptr))
			{
				return BitConverter.GetBytes(ptr.position);
			}
			ptr = buff.Alloc(19);
			short position = ptr.position;
			int offset = (int)position;
			byte[] buffer = buff.CurrentBuffer;

			UnitTest.Models.JustSimpleClass entity = (UnitTest.Models.JustSimpleClass)Entity;

			{
				System.Int32 value = Getter_firstIntk__BackingField(entity);

				BaseConvertor.Write32(buffer, offset, (byte*)&value);

				offset += 4;

			}
			{
				System.Int32 value = Getter_secondIntk__BackingField(entity);

				BaseConvertor.Write32(buffer, offset, (byte*)&value);

				offset += 4;

			}
			{
				System.Int32 value = Getter_thirdIntk__BackingField(entity);

				BaseConvertor.Write32(buffer, offset, (byte*)&value);

				offset += 4;

			}
			{
				System.String value = Getter_test(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = entity.azaza;

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				UnitTest.Models.SecondSimpleClass value = entity.ss;

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}

			return BitConverter.GetBytes(position);
		}


		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
		{
			byte[] buffer = buff.CurrentBuffer;

			short position = (short)offset == 0 ?
				 (short)0 : BaseConvertor.GetShort(buffer, offset);

			if (position == -1)
			{
				return null;
			}
			if (referenceMaping.ContainsKey(position))
			{
				return referenceMaping[position];
			}
			offset = position;

			var entity = (UnitTest.Models.JustSimpleClass)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
			referenceMaping.Add(position, entity);
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

			UnitTest.Models.SecondSimpleClass ss_Result = (UnitTest.Models.SecondSimpleClass)TypeResolveFactory.ResolveDesirialize(
																typeof(UnitTest.Models.SecondSimpleClass),
																offset,
																buff,
																referenceMaping);

			entity.ss = ss_Result;
			offset += 2;

			return (object)entity;
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
		public Action<UnitTest.Models.SecondSimpleClass, System.Guid> Setter_guid;

		public Func<UnitTest.Models.SecondSimpleClass, System.Guid> Getter_guid;

		public Action<UnitTest.Models.SecondSimpleClass, System.Int32> Setter_z;

		public Func<UnitTest.Models.SecondSimpleClass, System.Int32> Getter_z;

		public Action<UnitTest.Models.SecondSimpleClass, System.Int32> Setter_d;

		public Func<UnitTest.Models.SecondSimpleClass, System.Int32> Getter_d;


		TypeInfo typeInfo;

		public SecondSimpleClass()
		{
			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.SecondSimpleClass));

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57427257));
				var lambda = Expression.Lambda<Func<UnitTest.Models.SecondSimpleClass, System.Guid>>(body, p1);
				Getter_guid = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57427257));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.SecondSimpleClass, System.Guid>>(body, p1, p2);
				Setter_guid = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12007849));
				var lambda = Expression.Lambda<Func<UnitTest.Models.SecondSimpleClass, System.Int32>>(body, p1);
				Getter_z = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 12007849));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.SecondSimpleClass, System.Int32>>(body, p1, p2);
				Setter_z = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 4199185));
				var lambda = Expression.Lambda<Func<UnitTest.Models.SecondSimpleClass, System.Int32>>(body, p1);
				Getter_d = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.SecondSimpleClass), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 4199185));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.SecondSimpleClass, System.Int32>>(body, p1, p2);
				Setter_d = lambda.Compile();
			}


		}


		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return BitConverter.GetBytes(((short)-1));
			}
			DynamicBuffer.BufferPtr ptr;
			if (referenceMaping.TryGetValue(Entity, out ptr))
			{
				return BitConverter.GetBytes(ptr.position);
			}
			ptr = buff.Alloc(25);
			short position = ptr.position;
			int offset = (int)position;
			byte[] buffer = buff.CurrentBuffer;

			UnitTest.Models.SecondSimpleClass entity = (UnitTest.Models.SecondSimpleClass)Entity;

			{
				System.Guid value = Getter_guid(entity);

				BaseConvertor.Write128(buffer, offset, (byte*)&value);

				offset += 16;

			}
			{
				System.Int32 value = Getter_z(entity);

				BaseConvertor.Write32(buffer, offset, (byte*)&value);

				offset += 4;

			}
			{
				System.Int32 value = Getter_d(entity);

				BaseConvertor.Write32(buffer, offset, (byte*)&value);

				offset += 4;

			}

			return BitConverter.GetBytes(position);
		}


		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
		{
			byte[] buffer = buff.CurrentBuffer;

			short position = (short)offset == 0 ?
				 (short)0 : BaseConvertor.GetShort(buffer, offset);

			if (position == -1)
			{
				return null;
			}
			if (referenceMaping.ContainsKey(position))
			{
				return referenceMaping[position];
			}
			offset = position;

			var entity = (UnitTest.Models.SecondSimpleClass)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
			referenceMaping.Add(position, entity);
			offset++;
			Setter_guid.Invoke(entity, BaseConvertor.GetGuid(buffer, offset));
			offset += 16;
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
	public class StrongStructure : IResolver<UnitTest.Models.StrongStructure>
	{
		public Action<UnitTest.Models.StrongStructure, System.Boolean> Setter_p1k__BackingField;

		public Func<UnitTest.Models.StrongStructure, System.Boolean> Getter_p1k__BackingField;

		public Action<UnitTest.Models.StrongStructure, System.Guid> Setter_p2k__BackingField;

		public Func<UnitTest.Models.StrongStructure, System.Guid> Getter_p2k__BackingField;

		public Action<UnitTest.Models.StrongStructure, System.String> Setter_p3k__BackingField;

		public Func<UnitTest.Models.StrongStructure, System.String> Getter_p3k__BackingField;

		public Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1> Setter_p4k__BackingField;

		public Func<UnitTest.Models.StrongStructure, UnitTest.Models.c1> Getter_p4k__BackingField;

		public Action<UnitTest.Models.StrongStructure, System.Int32> Setter_p5k__BackingField;

		public Func<UnitTest.Models.StrongStructure, System.Int32> Getter_p5k__BackingField;

		public Action<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum> Setter_e1;

		public Func<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum> Getter_e1;


		TypeInfo typeInfo;

		public StrongStructure()
		{
			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.StrongStructure));

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 52099176));
				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1);
				Getter_p1k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Boolean), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 52099176));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Boolean>>(body, p1, p2);
				Setter_p1k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 28538918));
				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Guid>>(body, p1);
				Getter_p2k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Guid), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 28538918));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Guid>>(body, p1, p2);
				Setter_p2k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 25854020));
				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.String>>(body, p1);
				Getter_p3k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 25854020));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.String>>(body, p1, p2);
				Setter_p3k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46913081));
				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1);
				Getter_p4k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c1), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 46913081));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, UnitTest.Models.c1>>(body, p1, p2);
				Setter_p4k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45289214));
				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, System.Int32>>(body, p1);
				Getter_p5k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.Int32), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45289214));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, System.Int32>>(body, p1, p2);
				Setter_p5k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				var body = Expression.Field(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 42471437));
				var lambda = Expression.Lambda<Func<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum>>(body, p1);
				Getter_e1 = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(UnitTest.Models.StrongStructure), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.TestEnum), "p2");

				var m1 = Expression.MakeMemberAccess(p1, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 42471437));
				BinaryExpression body = Expression.Assign(m1, p2);
				var lambda = Expression.Lambda<Action<UnitTest.Models.StrongStructure, UnitTest.Models.TestEnum>>(body, p1, p2);
				Setter_e1 = lambda.Compile();
			}


		}


		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return BitConverter.GetBytes(((short)-1));
			}
			DynamicBuffer.BufferPtr ptr;
			if (referenceMaping.TryGetValue(Entity, out ptr))
			{
				return BitConverter.GetBytes(ptr.position);
			}
			ptr = buff.Alloc(36);
			short position = ptr.position;
			int offset = (int)position;
			byte[] buffer = buff.CurrentBuffer;

			UnitTest.Models.StrongStructure entity = (UnitTest.Models.StrongStructure)Entity;

			{
				System.Boolean value = Getter_p1k__BackingField(entity);

				BaseConvertor.Write8(buffer, offset, (byte*)&value);

				offset += 1;

			}
			{
				System.Guid value = Getter_p2k__BackingField(entity);

				BaseConvertor.Write128(buffer, offset, (byte*)&value);

				offset += 16;

			}
			{
				System.String value = Getter_p3k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				UnitTest.Models.c1 value = Getter_p4k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int32 value = Getter_p5k__BackingField(entity);

				BaseConvertor.Write32(buffer, offset, (byte*)&value);

				offset += 4;

			}
			{
				System.String[] value = entity.p6;

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int32[] value = entity.p7;

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int32[] value = entity.p8;

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				UnitTest.Models.TestEnum value = Getter_e1(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 4;

			}

			return BitConverter.GetBytes(position);
		}


		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
		{
			byte[] buffer = buff.CurrentBuffer;

			short position = (short)offset == 0 ?
				 (short)0 : BaseConvertor.GetShort(buffer, offset);

			if (position == -1)
			{
				return null;
			}
			if (referenceMaping.ContainsKey(position))
			{
				return referenceMaping[position];
			}
			offset = position;

			var entity = (UnitTest.Models.StrongStructure)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
			referenceMaping.Add(position, entity);
			offset++;
			Setter_p1k__BackingField.Invoke(entity, BaseConvertor.GetBool(buffer, offset));
			offset += 1;
			Setter_p2k__BackingField.Invoke(entity, BaseConvertor.GetGuid(buffer, offset));
			offset += 16;
			string p3k__BackingField = DesirializeString(offset, buff, referenceMaping);
			Setter_p3k__BackingField.Invoke(entity, p3k__BackingField);
			offset += 2;

			UnitTest.Models.c1 p4k__BackingField_Result = (UnitTest.Models.c1)TypeResolveFactory.ResolveDesirialize(
																typeof(UnitTest.Models.c1),
																offset,
																buff,
																referenceMaping);


			Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
			offset += 2;
			Setter_p5k__BackingField.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
			offset += 4;

			System.String[] p6_Result = (System.String[])TypeResolveFactory.ResolveDesirialize(
																typeof(System.String[]),
																offset,
																buff,
																referenceMaping);

			entity.p6 = p6_Result;
			offset += 2;

			System.Int32[] p7_Result = (System.Int32[])TypeResolveFactory.ResolveDesirialize(
																typeof(System.Int32[]),
																offset,
																buff,
																referenceMaping);

			entity.p7 = p7_Result;
			offset += 2;

			System.Int32[] p8_Result = (System.Int32[])TypeResolveFactory.ResolveDesirialize(
																typeof(System.Int32[]),
																offset,
																buff,
																referenceMaping);

			entity.p8 = p8_Result;
			offset += 2;
			Setter_e1.Invoke(entity, (UnitTest.Models.TestEnum)BaseConvertor.GetInt(buffer, offset));
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
	public class c2 : IResolver<object>
	{
		Func<object, System.String, object> Setter_p1k__BackingField;


		public Func<object, System.String> Getter_p1k__BackingField;

		Func<object, System.String, object> Setter_p2k__BackingField;


		public Func<object, System.String> Getter_p2k__BackingField;

		Func<object, UnitTest.Models.c4, object> Setter_p3k__BackingField;


		public Func<object, UnitTest.Models.c4> Getter_p3k__BackingField;

		Func<object, UnitTest.Models.c5, object> Setter_p4k__BackingField;


		public Func<object, UnitTest.Models.c5> Getter_p4k__BackingField;

		Func<object, System.String, object> Setter_p5k__BackingField;


		public Func<object, System.String> Getter_p5k__BackingField;

		Func<object, System.Int64?, object> Setter_p6k__BackingField;


		public Func<object, System.Int64?> Getter_p6k__BackingField;

		Func<object, System.Boolean?, object> Setter_p7k__BackingField;


		public Func<object, System.Boolean?> Getter_p7k__BackingField;

		Func<object, System.String, object> Setter_p8k__BackingField;


		public Func<object, System.String> Getter_p8k__BackingField;

		Func<object, System.String, object> Setter_p9k__BackingField;


		public Func<object, System.String> Getter_p9k__BackingField;

		Func<object, System.String, object> Setter_p10k__BackingField;


		public Func<object, System.String> Getter_p10k__BackingField;

		Func<object, System.String, object> Setter_p11k__BackingField;


		public Func<object, System.String> Getter_p11k__BackingField;

		Func<object, System.String, object> Setter_p12k__BackingField;


		public Func<object, System.String> Getter_p12k__BackingField;

		Func<object, System.String, object> Setter_p13k__BackingField;


		public Func<object, System.String> Getter_p13k__BackingField;

		Func<object, System.Int64?, object> Setter_p14k__BackingField;


		public Func<object, System.Int64?> Getter_p14k__BackingField;

		Func<object, System.Int32?, object> Setter_p15k__BackingField;


		public Func<object, System.Int32?> Getter_p15k__BackingField;

		Func<object, System.Boolean?, object> Setter_p16k__BackingField;


		public Func<object, System.Boolean?> Getter_p16k__BackingField;

		Func<object, System.Int32?, object> Setter_p17k__BackingField;


		public Func<object, System.Int32?> Getter_p17k__BackingField;

		Func<object, System.Int32?, object> Setter_p18k__BackingField;


		public Func<object, System.Int32?> Getter_p18k__BackingField;


		TypeInfo typeInfo;

		public c2()
		{
			this.typeInfo = TypeInfo.instanse(41228758);

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45941824));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p1k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 45941824));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p1k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 65286507));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p2k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 65286507));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p2k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44993220));
				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c4>>(body, p1);
				Getter_p3k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c4), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 44993220));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c4, object>>(block, p1, p2);
				Setter_p3k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 60350475));
				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c5>>(body, p1);
				Getter_p4k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(UnitTest.Models.c5), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 60350475));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, UnitTest.Models.c5, object>>(block, p1, p2);
				Setter_p4k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62994688));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p5k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62994688));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p5k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62248291));
				var lambda = Expression.Lambda<Func<object, System.Int64?>>(body, p1);
				Getter_p6k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(730715).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62248291));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Int64?, object>>(block, p1, p2);
				Setter_p6k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19148020));
				var lambda = Expression.Lambda<Func<object, System.Boolean?>>(body, p1);
				Getter_p7k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(13115852).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 19148020));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Boolean?, object>>(block, p1, p2);
				Setter_p7k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57143155));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p8k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 57143155));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p8k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 49939616));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p9k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 49939616));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p9k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62884923));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p10k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 62884923));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p10k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 37281284));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p11k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 37281284));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p11k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59804090));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p12k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 59804090));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p12k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 9066271));
				var lambda = Expression.Lambda<Func<object, System.String>>(body, p1);
				Getter_p13k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(typeof(System.String), "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 9066271));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.String, object>>(block, p1, p2);
				Setter_p13k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 55723506));
				var lambda = Expression.Lambda<Func<object, System.Int64?>>(body, p1);
				Getter_p14k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(730715).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 55723506));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Int64?, object>>(block, p1, p2);
				Setter_p14k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2854387));
				var lambda = Expression.Lambda<Func<object, System.Int32?>>(body, p1);
				Getter_p15k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(66695541).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 2854387));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Int32?, object>>(block, p1, p2);
				Setter_p15k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16752354));
				var lambda = Expression.Lambda<Func<object, System.Boolean?>>(body, p1);
				Getter_p16k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(13115852).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 16752354));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Boolean?, object>>(block, p1, p2);
				Setter_p16k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 63774847));
				var lambda = Expression.Lambda<Func<object, System.Int32?>>(body, p1);
				Getter_p17k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(66695541).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 63774847));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Int32?, object>>(block, p1, p2);
				Setter_p17k__BackingField = lambda.Compile();
			}
			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				var body = Expression.Field(Expression.Convert(p1, this.typeInfo.Type), this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 66515594));
				var lambda = Expression.Lambda<Func<object, System.Int32?>>(body, p1);
				Getter_p18k__BackingField = lambda.Compile();
			}

			{
				ParameterExpression p1 = Expression.Parameter(typeof(object), "p1");
				ParameterExpression p2 = Expression.Parameter(TypeInfo.instanse(66695541).Type, "p2");
				ParameterExpression SturctObjectParam = Expression.Variable(this.typeInfo.Type, "Struct");
				ParameterExpression retObjectParam = Expression.Variable(typeof(object), "ret");

				LabelTarget returnTarget = Expression.Label(typeof(object));


				var assignToRet = Expression.Assign(SturctObjectParam, Expression.Convert(p1, this.typeInfo.Type));
				var makeMeberAccess = Expression.MakeMemberAccess(SturctObjectParam, this.typeInfo.Fields.Single(x => RuntimeHelpers.GetHashCode(x) == 66515594));

				var assign = Expression.Assign(makeMeberAccess, p2);
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
				var lambda = Expression.Lambda<Func<object, System.Int32?, object>>(block, p1, p2);
				Setter_p18k__BackingField = lambda.Compile();
			}

		}


		public unsafe byte[] Serialize(object Entity, DynamicBuffer buff, Dictionary<object, DynamicBuffer.BufferPtr> referenceMaping)
		{
			if (Entity == null)
			{
				return BitConverter.GetBytes(((short)-1));
			}
			DynamicBuffer.BufferPtr ptr;
			if (referenceMaping.TryGetValue(Entity, out ptr))
			{
				return BitConverter.GetBytes(ptr.position);
			}
			ptr = buff.Alloc(37);
			short position = ptr.position;
			int offset = (int)position;
			byte[] buffer = buff.CurrentBuffer;

			object entity = (object)Entity;

			{
				System.String value = Getter_p1k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p2k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				UnitTest.Models.c4 value = Getter_p3k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				UnitTest.Models.c5 value = Getter_p4k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p5k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int64? value = Getter_p6k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Boolean? value = Getter_p7k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p8k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p9k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p10k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p11k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p12k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.String value = Getter_p13k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int64? value = Getter_p14k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int32? value = Getter_p15k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Boolean? value = Getter_p16k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int32? value = Getter_p17k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}
			{
				System.Int32? value = Getter_p18k__BackingField(entity);

				byte[] result = TypeResolveFactory.ResolveSerialize((object)value, buff, referenceMaping);
				System.Buffer.BlockCopy(result, 0, buffer, offset, result.Length);

				offset += 2;

			}

			return BitConverter.GetBytes(position);
		}


		public object instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
		{
			byte[] buffer = buff.CurrentBuffer;

			short position = (short)offset == 0 ?
				 (short)0 : BaseConvertor.GetShort(buffer, offset);

			if (position == -1)
			{
				return null;
			}
			if (referenceMaping.ContainsKey(position))
			{
				return referenceMaping[position];
			}
			offset = position;

			var entity = (object)FormatterServices.GetSafeUninitializedObject(this.typeInfo.Type);
			referenceMaping.Add(position, entity);
			offset++;
			string p1k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p1k__BackingField.Invoke(entity, p1k__BackingField);
			offset += 2;
			string p2k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p2k__BackingField.Invoke(entity, p2k__BackingField);
			offset += 2;

			UnitTest.Models.c4 p3k__BackingField_Result = (UnitTest.Models.c4)TypeResolveFactory.ResolveDesirialize(
																typeof(UnitTest.Models.c4),
																offset,
																buff,
																referenceMaping);


			entity = Setter_p3k__BackingField.Invoke(entity, p3k__BackingField_Result);
			offset += 2;

			UnitTest.Models.c5 p4k__BackingField_Result = (UnitTest.Models.c5)TypeResolveFactory.ResolveDesirialize(
																typeof(UnitTest.Models.c5),
																offset,
																buff,
																referenceMaping);


			entity = Setter_p4k__BackingField.Invoke(entity, p4k__BackingField_Result);
			offset += 2;
			string p5k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p5k__BackingField.Invoke(entity, p5k__BackingField);
			offset += 2;
			{
				System.Int64? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetLong(buffer, ptrToNullable + 1);





					entity = Setter_p6k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;
			{
				System.Boolean? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetBool(buffer, ptrToNullable + 1);





					entity = Setter_p7k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;
			string p8k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p8k__BackingField.Invoke(entity, p8k__BackingField);
			offset += 2;
			string p9k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p9k__BackingField.Invoke(entity, p9k__BackingField);
			offset += 2;
			string p10k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p10k__BackingField.Invoke(entity, p10k__BackingField);
			offset += 2;
			string p11k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p11k__BackingField.Invoke(entity, p11k__BackingField);
			offset += 2;
			string p12k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p12k__BackingField.Invoke(entity, p12k__BackingField);
			offset += 2;
			string p13k__BackingField = DesirializeString(offset, buff, referenceMaping);
			entity = Setter_p13k__BackingField.Invoke(entity, p13k__BackingField);
			offset += 2;
			{
				System.Int64? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetLong(buffer, ptrToNullable + 1);





					entity = Setter_p14k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;
			{
				System.Int32? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetInt(buffer, ptrToNullable + 1);





					entity = Setter_p15k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;
			{
				System.Boolean? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetBool(buffer, ptrToNullable + 1);





					entity = Setter_p16k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;
			{
				System.Int32? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetInt(buffer, ptrToNullable + 1);





					entity = Setter_p17k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;
			{
				System.Int32? fieldValue = null;
				short ptrToNullable = BaseConvertor.GetShort(buffer, offset);
				bool hasValue = BaseConvertor.GetBool(buffer, ptrToNullable);
				if (hasValue)
				{

					fieldValue = BaseConvertor.GetInt(buffer, ptrToNullable + 1);





					entity = Setter_p18k__BackingField.Invoke(entity, fieldValue);

				}
			}

			offset += 2;

			return (object)entity;
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