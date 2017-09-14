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
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static DateTime GetDate(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				long tick = *(long*)(ptr + offset);
				return new DateTime(tick);
			}
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Guid GetGuid(byte[] buffer, int offset)
		{
			fixed (byte* ptr = buffer)
			{
				byte[] guid = new byte[16];
				fixed (byte* guidPtr = guid)
				{

					Buffer.MemoryCopy((ptr + offset),guidPtr, 16, 16);
					return new Guid(guid);
				}
			}
		}
		#region write

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write(byte[] buffer, int offset, bool value)
		{
			buffer[offset] = *((byte*)(&value));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write(byte[] buffer, int offset, char value)
		{
			buffer[offset] = *((byte*)(&value));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write8(byte[] buffer, int offset, byte* value)
		{
			buffer[offset] = *(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write16(byte[] buffer, int offset, byte* value)
		{
			buffer[offset] = *(value);
			buffer[offset + 1] = *(value + 1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write32(byte[] buffer,int offset,byte* value)
		{
			buffer[offset] = *(value);
			buffer[offset + 1] = *(value+1);
			buffer[offset + 2] = *(value+2);
			buffer[offset + 3] = *(value + 3);
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write64(byte[] buffer, int offset, byte* value)
		{
			buffer[offset] = *(value);
			buffer[offset + 1] = *(value + 1);
			buffer[offset + 2] = *(value + 2);
			buffer[offset + 3] = *(value + 3);
			buffer[offset + 4] = *(value + 4);
			buffer[offset + 5] = *(value + 5);
			buffer[offset + 6] = *(value + 6);
			buffer[offset + 7] = *(value + 7);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write128(byte[] buffer, int offset, byte* value)
		{
			buffer[offset] = *(value);
			buffer[offset + 1] = *(value + 1);
			buffer[offset + 2] = *(value + 2);
			buffer[offset + 3] = *(value + 3);
			buffer[offset + 4] = *(value + 4);
			buffer[offset + 5] = *(value + 5);
			buffer[offset + 6] = *(value + 6);
			buffer[offset + 7] = *(value + 7);
			buffer[offset + 8] = *(value + 8);
			buffer[offset + 9] = *(value + 9);
			buffer[offset + 10] = *(value + 10);
			buffer[offset + 11] = *(value + 11);
			buffer[offset + 12] = *(value + 12);
			buffer[offset + 13] = *(value + 13);
			buffer[offset + 14] = *(value + 14);
			buffer[offset + 15] = *(value + 15);
		}

		#endregion
	}
}
