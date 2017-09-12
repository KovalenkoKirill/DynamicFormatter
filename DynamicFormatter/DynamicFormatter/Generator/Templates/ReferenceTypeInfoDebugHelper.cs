//using DynamicFormatter.interfaces;
//using DynamicFormatter.Generator;
//using DynamicFormatter.Extentions;
//using System.Runtime.Serialization;

//namespace DynamicFormatter.Dynamic
//{
//	public class JustSimpleClass : IResolver<UnitTest.Models.JustSimpleClass>
//	{

//		public UnitTest.Models.JustSimpleClass instanse(ref byte[] buffer, int offset)
//		{
//			var entity = FormatterServices.GetSafeUninitializedObject(typeof(UnitTest.Models.JustSimpleClass));
//			offset++;

//			entity.firstInt = BaseConvertor.GetInt(buffer, offset);

//			offset += 4;


//			entity.secondInt = BaseConvertor.GetInt(buffer, offset);

//			offset += 4;


//			entity.thirdInt = BaseConvertor.GetInt(buffer, offset);

//			offset += 4;

//		}
//	}
//}