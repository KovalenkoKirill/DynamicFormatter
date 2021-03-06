﻿using ProtoBuf;
using System;
using ZeroFormatter;

namespace PerformanceComparison.Models
{
	[Serializable]
	[ZeroFormattable]
	[ProtoContract(SkipConstructor = true)]
	public struct BaseStruct
	{
		[Index(0)]
		[ProtoMember(1)]
		public int R { get; set; }

		[Index(1)]
		[ProtoMember(2)]
		public int G { get; set; }

		[Index(2)]
		[ProtoMember(3)]
		public int B { get; set; }

		public BaseStruct(int R, int G, int B)
		{
			this.R = R;
			this.G = G;
			this.B = B;
		}
	}

	[Serializable]
	[ZeroFormattable]
	[ProtoContract(SkipConstructor = true)]
	public class BaseClass
	{
		[Index(0)]
		[ProtoMember(1)]
		public virtual int R { get; set; }

		[Index(1)]
		[ProtoMember(2)]
		public virtual int G { get; set; }

		[Index(2)]
		[ProtoMember(3)]
		public virtual int B { get; set; }
	}

	[Serializable]
	[ZeroFormattable]
	[ProtoContract(SkipConstructor = true)]
	public class ClassWithInnerReference
	{
		[Index(0)]
		[ProtoMember(1)]
		public int R { get; set; }

		[Index(1)]
		[ProtoMember(2)]
		public virtual int G { get; set; }

		[Index(2)]
		[ProtoMember(3)]
		public virtual int B { get; set; }

		[Index(3)]
		[ProtoMember(4)]
		public BaseClass InnerClass;
	}

	[Serializable]
	[ZeroFormattable]
	[ProtoContract(SkipConstructor = true)]
	public class CrossReferenceClass
	{
		[Index(0)]
		[ProtoMember(1)]
		public int R;

		[Index(1)]
		[ProtoMember(2)]
		public int G;

		[Index(2)]
		[ProtoMember(3)]
		public int B;

		[ProtoMember(4)]
		public CrossReferenceInner inner;

		public CrossReferenceClass()
		{
			R = 10;
			G = 50;
			B = 32;
			inner = new CrossReferenceInner();
			inner.reference = this;
		}
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	public class CrossReferenceInner
	{
		[ProtoMember(1)]
		public int someint;

		[ProtoMember(2)]
		public CrossReferenceClass reference;
	}
}