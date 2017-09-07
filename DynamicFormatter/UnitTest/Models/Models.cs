﻿using System;
using System.Collections.Generic;

namespace UnitTest.Models
{
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