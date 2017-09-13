//using System;
//using DynamicFormatter.interfaces;
//using DynamicFormatter.Generator;
//using DynamicFormatter.Extentions;
//using System.Runtime.Serialization;
//using DynamicFormatter.Models;
//using System.Collections.Generic;

//namespace DynamicFormatter.Dynamic
//{
//	public class JustSimpleClass : IResolver<UnitTest.Models.JustSimpleClass>
//	{
//		public Action<object, object> _Setter_secondInt;

//		public Action<object, object> Setter_secondInt
//		{
//			get
//			{
//				if (this._Setter_secondInt == null)
//				{
//					this._Setter_secondInt = this.typeInfo.AccessMethods[17086828].Setter;
//				}
//				return _Setter_secondInt;
//			}
//		}
//		public Action<object, object> _Setter_test;

//		public Action<object, object> Setter_test
//		{
//			get
//			{
//				if (this._Setter_test == null)
//				{
//					this._Setter_test = this.typeInfo.AccessMethods[49571903].Setter;
//				}
//				return _Setter_test;
//			}
//		}

//		TypeInfo typeInfo;

//		public JustSimpleClass()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.JustSimpleClass));
//		}

//		public UnitTest.Models.JustSimpleClass instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;
//			var entity = (UnitTest.Models.JustSimpleClass)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.JustSimpleClass));
//			offset++;
//			entity.firstInt = BaseConvertor.GetInt(buffer, offset);
//			offset += 4;
//			Setter_secondInt.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			entity.thirdInt = BaseConvertor.GetInt(buffer, offset);
//			offset += 4;
//			string test = DesirializeString(offset, buff, referenceMaping);
//			Setter_test.Invoke(entity, test);
//			offset += 2;
//			string azaza = DesirializeString(offset, buff, referenceMaping);
//			entity.azaza = azaza;
//			offset += 2;
//			ushort ptrForss = BaseConvertor.GetShort(buffer, offset);

//			UnitTest.Models.SecondSimpleClass ss_Result = (UnitTest.Models.SecondSimpleClass)TypeResolveFactory.ResolveDesirialize(
//																	typeof(UnitTest.Models.SecondSimpleClass),
//																	ptrForss,
//																	buff,
//																	referenceMaping);

//			entity.ss = ss_Result;
//			offset += 2;
//			return entity;
//		}

//		public unsafe new string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
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
//	public class SecondSimpleClass : IResolver<UnitTest.Models.SecondSimpleClass>
//	{
//		public Action<object, object> _Setter_z;

//		public Action<object, object> Setter_z
//		{
//			get
//			{
//				if (this._Setter_z == null)
//				{
//					this._Setter_z = this.typeInfo.AccessMethods[46890055].Setter;
//				}
//				return _Setter_z;
//			}
//		}
//		public Action<object, object> _Setter_d;

//		public Action<object, object> Setter_d
//		{
//			get
//			{
//				if (this._Setter_d == null)
//				{
//					this._Setter_d = this.typeInfo.AccessMethods[50727427].Setter;
//				}
//				return _Setter_d;
//			}
//		}

//		TypeInfo typeInfo;

//		public SecondSimpleClass()
//		{
//			this.typeInfo = TypeInfo.instanse(typeof(UnitTest.Models.SecondSimpleClass));
//		}

//		public UnitTest.Models.SecondSimpleClass instanse(int offset, DynamicBuffer buff, Dictionary<int, object> referenceMaping)
//		{
//			byte[] buffer = buff.CurrentBuffer;
//			var entity = (UnitTest.Models.SecondSimpleClass)FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.SecondSimpleClass));
//			offset++;
//			Setter_z.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			Setter_d.Invoke(entity, BaseConvertor.GetInt(buffer, offset));
//			offset += 4;
//			return entity;
//		}

//		public unsafe new string DesirializeString(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping)
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