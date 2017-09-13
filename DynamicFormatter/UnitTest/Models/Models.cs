﻿using System;
using System.Collections.Generic;

namespace UnitTest.Models
{
	public enum TestEnum
	{
		fist,
		second
	}

	public struct JustSimpleClass
	{
		public int firstInt { get; set; }

		int secondInt { get; set; }

		public int thirdInt { get; set; }

		string test;
		public string azaza;

		public SecondSimpleClass ss;

		public JustSimpleClass(int z)
		{
			firstInt = 40;
			secondInt = 30;
			thirdInt = 12;
			test = "azaza";
			ss = new SecondSimpleClass();
			azaza = "zzaza";
		}
	}

	public class SecondSimpleClass
	{
		int z = 50;
		int d = 213;
	}

	public class ChashedObject<T>
	{
		public DateTime date;

		public T Value { get; set; }

		public ChashedObject()
		{
			date = DateTime.Now;
		}
	}

	[Serializable]
	internal class CrossReferenceClass
	{
		Inner inner;

		public CrossReferenceClass()
		{
			inner = new Inner(this);
		}

		class Inner
		{
			CrossReferenceClass val;

			public Inner(CrossReferenceClass val)
			{
				this.val = val;	
			}
		}
	}

	[Serializable]
	internal class ClassWithNullable
	{
		public bool? boolNulable;

		public int? intNullable;

		public long? longNullable;
	}

	[Serializable]
	internal struct TestStructWithReference
	{
		public int R { get; set; }

		public int G { get; set; }

		public int B { get; set; }

		public List<int> List { get; set; }
	}

	[Serializable]
	internal struct TestStruct
	{
		public int R { get; set; }

		public int G { get; set; }

		public int B { get; set; }
	}

	[Serializable]
	public class InnerTestClass
	{
		public ClassForTest inner { get; set; }
	}

	[Serializable]
	public class ArrayItem
	{
		public int abc = 99;

		public int dfg = 50;
	}

	[Serializable]
	public class ClassForTest
	{
		private int i = 0;
		public int z = 50;
		public int azaza { get; set; }

		public int[] _Array;

		private TestStruct str;

		public InnerTestClass inner;

		private ArrayItem[] arrayClass;

		public ClassForTest()
		{
			inner = new InnerTestClass()
			{
				inner = this
			};
			_Array = new int[]
			{
					10,0,9,1
			};

			str = new TestStruct()
			{
				B = 10,
				G = 10,
				R = 10
			};
			arrayClass = new[]
			{
					new ArrayItem(),
					new ArrayItem(),
					new ArrayItem()
				};
		}
	}

	[Serializable]
	public class ClassWithStrings
	{
		public string someString = "First string";

		public string secondSomeString = "Second string";
	}
	[Serializable]
	public class ClassWithDateTime
	{
		public DateTime FirstDate { get; set; }

		public DateTime OtherDate { get; set; }
	}
}