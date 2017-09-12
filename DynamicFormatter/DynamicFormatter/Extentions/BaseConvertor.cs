using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Extentions
{
	public unsafe static class BaseConvertor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GetBool(byte[] buffer,int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(bool*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static char GetChar(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(char*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte GetSbyte(byte[] buffer,int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(sbyte*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short GetShort(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(short*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetInt(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(int*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long GetLong(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(long*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte GetByte(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort GetUshort(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(ushort*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetUint(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(uint*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong GetUlong(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(ulong*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetFloat(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(float*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double GetDouble(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(double*)(ptr + offset);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal GetDecimal(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				return *(decimal*)(ptr + offset);
			}
		}
	}
}
