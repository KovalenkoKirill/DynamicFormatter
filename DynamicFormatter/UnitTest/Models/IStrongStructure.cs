using MessagePack;
using ProtoBuf;
using System;

namespace UnitTest.Models
{
	[ProtoContract(SkipConstructor = true)]
	public interface IStrongStructure
	{
		bool p1 { get; set; }

		Guid p2 { get; set; }

		string p3 { get; set; }

		c1 p4 { get; set; }

		int p5 { get; set; }
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	[MessagePackObject]
	public class StrongStructure : IStrongStructure
	{
		[ProtoMember(1)]
		[Key(0)]
		public bool p1 { get; set; }

		[ProtoMember(2)]
		[Key(1)]
		public Guid p2 { get; set; }

		[ProtoMember(3)]
		[Key(2)]
		public string p3 { get; set; }

		[ProtoMember(4)]
		[Key(3)]
		public c1 p4 { get; set; }

		[ProtoMember(5)]
		[Key(4)]
		public int p5 { get; set; }

		[ProtoMember(6)]
		[Key(5)]
		public string[] p6;

		public StrongStructure()
		{
			p1 = false;
			p2 = Guid.NewGuid();
			p3 = "some string in p3";
			p4 = new c1();
			p5 = 50;
			p6 = new string[]
			{
				"first element",
				"Second element"
			};
		}
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	[MessagePackObject]
	public class c1
	{
		public c1()
		{
			p1 = Guid.NewGuid();
			p2 = Guid.NewGuid();
			p3 = "some string in p3";
			p4 = e1.p3;
			p5 = e2.p4;
			p6 = "some string in p6";
			p7 = "some string in p7";
			p8 = "some string in p8";
			p9 = "some string in p9";
			p10 = "some string in p10";
			p11 = "some string in p11";
			p12 = e3.p7;
			p13 = "some string in p13";
			p14 = DateTime.Now;
			p15 = Guid.NewGuid();
			p16 = new c2();
			p17 = new c3();
		}

		[ProtoMember(1)]
		[Key(0)]
		public Guid p1 { get; set; }

		[ProtoMember(2)]
		[Key(1)]
		public Guid p2 { get; set; }

		[ProtoMember(3)]
		[Key(2)]
		public string p3 { get; set; }

		[ProtoMember(5)]
		[Key(3)]
		public e1 p4 { get; set; }

		[ProtoMember(6)]
		[Key(4)]
		public e2 p5 { get; set; }

		[ProtoMember(7)]
		[Key(5)]
		public string p6 { get; set; }

		[ProtoMember(8)]
		[Key(6)]
		string p7 { get; set; }

		[ProtoMember(9)]
		[Key(7)]
		public string p8 { get; set; }

		[ProtoMember(10)]
		[Key(8)]
		public string p9 { get; set; }

		[ProtoMember(11)]
		[Key(9)]
		public string p10 { get; set; }

		[ProtoMember(12)]
		[Key(10)]
		public string p11 { get; set; }

		[ProtoMember(13)]
		[Key(11)]
		public e3 p12 { get; set; }

		[ProtoMember(14)]
		[Key(12)]
		public string p13 { get; set; }

		[ProtoMember(15)]
		[Key(13)]
		public DateTime p14 { get; set; }

		[ProtoMember(16)]
		[Key(14)]
		public Guid p15 { get; set; }

		[ProtoMember(17)]
		[Key(15)]
		public c2 p16 { get; set; }

		[ProtoMember(18)]
		[Key(16)]
		public c3 p17 { get; set; }
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	[MessagePackObject]
	public class c2
	{
		public c2()
		{
			p1 = "some string in p1";
			p2 = "some string in p1";
			p3 = new c4();
			p4 = new c5();
			p5 = "some string in p5";
			p6 = null;
			p7 = true;
			p8 = null;
			p9 = null;
			p10 = "some string in p10";
			p11 = "some string in p11";
			p12 = "some string in p12";
			p13 = "some string in p13";
			p14 = 100;
			p15 = null;
			p16 = null;
			p17 = 20;
			p18 = null;
		}

		[ProtoMember(1)]
		[Key(0)]
		public string p1 { get; set; }

		[ProtoMember(2)]
		[Key(1)]
		public string p2 { get; set; }

		[ProtoMember(3)]
		[Key(2)]
		public c4 p3 { get; set; }

		[ProtoMember(4)]
		[Key(3)]
		public c5 p4 { get; set; }

		[ProtoMember(5)]
		[Key(4)]
		public string p5 { get; set; }

		[ProtoMember(6)]
		[Key(5)]
		public long? p6 { get; set; }

		[ProtoMember(7)]
		[Key(6)]
		public bool? p7 { get; set; }

		[ProtoMember(8)]
		[Key(7)]
		public string p8 { get; set; }

		[ProtoMember(9)]
		[Key(8)]
		public string p9 { get; set; }

		[ProtoMember(10)]
		[Key(9)]
		public string p10 { get; set; }

		[ProtoMember(11)]
		[Key(10)]
		public string p11 { get; set; }

		[ProtoMember(12)]
		[Key(11)]
		public string p12 { get; set; }

		[ProtoMember(13)]
		[Key(12)]
		public string p13 { get; set; }

		[ProtoMember(14)]
		[Key(13)]
		public long? p14 { get; set; }

		[ProtoMember(15)]
		[Key(14)]
		public int? p15 { get; set; }

		[ProtoMember(16)]
		[Key(15)]
		public bool? p16 { get; set; }

		[ProtoMember(17)]
		[Key(16)]
		public int? p17 { get; set; }

		[ProtoMember(18)]
		[Key(17)]
		public int? p18 { get; set; }
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	[MessagePackObject]
	public class c4
	{
		public c4()
		{
			p1 = 1;
			p2 = null;
			p3 = null;
			p4 = DayOfWeek.Sunday;
		}
		[ProtoMember(1)]
		[Key(0)]
		public byte? p1 { get; set; }

		[ProtoMember(2)]
		[Key(1)]
		public byte? p2 { get; set; }

		[ProtoMember(3)]
		[Key(2)]
		public byte? p3 { get; set; }

		[ProtoMember(4)]
		[Key(3)]
		public DayOfWeek? p4 { get; set; }
	}


	public enum DayOfWeek
	{

		Sunday = 0,


		Monday = 1,


		Tuesday = 2,


		Wednesday = 3,


		Thursday = 4,

		Friday = 5,

		Saturday = 6
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	[MessagePackObject]
	public class c5
	{
		public c5()
		{
			Year = 2017;
			Month = 10;
			Day = 15;
		}
		[ProtoMember(1)]
		[Key(0)]
		public int Year { get; set; }

		[ProtoMember(2)]
		[Key(1)]
		public int Month { get; set; }

		[ProtoMember(3)]
		[Key(2)]
		public int Day { get; set; }
	}

	[Flags]
	public enum e1
	{
		p0 = 0,

		p1 = 1,

		p2 = 2,

		p3 = 4,

		p4 = 8,

		p5 = 16,

		p6 = 32
	}

	[Flags]
	public enum e2
	{
		p0 = 0,

		p1 = 1,

		p2 = 2,

		p3 = 4,

		p4 = 8,

		p5 = 16,

		p6 = 32
	}

	[Flags]
	public enum e3
	{
		p0 = 0,

		p1 = 1,

		p2 = 2,

		p3 = 4,

		p4 = 8,

		p5 = 16,

		p6 = 32,

		p7 = 64
	}

	[Serializable]
	[ProtoContract(SkipConstructor = true)]
	[MessagePackObject]
	public class c3
	{
		public c3()
		{
			p1 = "fs";
			p2 = "fsdsdfds";
			p3 = "fsdfdfdss";
			p4 = "fsdasd34235rdsffds";
			p5 = "fsdfdvcvs";
			p6 = "fsdgsdgdgsfds";
			p7 = "fsdffsdfsdgdsgds";
		}

		[ProtoMember(1)]
		[Key(0)]
		public string p1 { get; set; }

		[ProtoMember(2)]
		[Key(1)]
		public string p2 { get; set; }

		[ProtoMember(3)]
		[Key(2)]
		public string p3 { get; set; }

		[ProtoMember(4)]
		[Key(3)]
		public string p4 { get; set; }

		[ProtoMember(5)]
		[Key(4)]
		public string p5 { get; set; }

		[ProtoMember(6)]
		[Key(5)]
		public string p6 { get; set; }

		[ProtoMember(7)]
		[Key(6)]
		public string p7 { get; set; }
	}
}