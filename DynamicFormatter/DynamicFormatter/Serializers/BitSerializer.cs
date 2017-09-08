using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DynamicFormatter.Serializers
{
	internal class BitSerializer
	{
		private static Dictionary<int, BitSerializer> innerLIst = new Dictionary<int, BitSerializer>();

		public static BitSerializer GetInstanse(Type t)
		{
			BitSerializer instanse;
			int hash = RuntimeHelpers.GetHashCode(t);
			if (!innerLIst.TryGetValue(hash, out instanse))
			{
				instanse = new BitSerializer(t);
				innerLIst.Add(hash, instanse);
			}
			return instanse;
		}

		///
		/// Block from https://github.com/google/flatbuffers/blob/master/net/FlatBuffers/ByteBuffer.cs
		///
#if USE_UNSAFE

		static public ushort ReverseBytes(ushort input)
		{
			return (ushort)(((input & 0x00FFU) << 8) |
							((input & 0xFF00U) >> 8));
		}

		static public uint ReverseBytes(uint input)
		{
			return ((input & 0x000000FFU) << 24) |
				   ((input & 0x0000FF00U) << 8) |
				   ((input & 0x00FF0000U) >> 8) |
				   ((input & 0xFF000000U) >> 24);
		}

		static public ulong ReverseBytes(ulong input)
		{
			return (((input & 0x00000000000000FFUL) << 56) |
					((input & 0x000000000000FF00UL) << 40) |
					((input & 0x0000000000FF0000UL) << 24) |
					((input & 0x00000000FF000000UL) << 8) |
					((input & 0x000000FF00000000UL) >> 8) |
					((input & 0x0000FF0000000000UL) >> 24) |
					((input & 0x00FF000000000000UL) >> 40) |
					((input & 0xFF00000000000000UL) >> 56));
		}

		internal Func<byte[], int, object> Deserialize;
		internal Func<object, byte[]> Serialize;
#else

		internal Func<byte[], object> Deserialize;
		internal Func<object, byte[]> Serialize;

#endif

		private unsafe BitSerializer(Type type)
		{
			#region PrimitiveTypes

#if USE_UNSAFE
			if (type == typeof(bool))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(bool*)(ptr);
					}
				};
				Serialize = (entity) =>
				{
					bool val = (bool)entity;
					bool* ptr = &val;
					int size = sizeof(bool); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(char))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(char*)(ptr + offset);
					}
				};
				Serialize = (entity) =>
				{
					char val = (char)entity;
					char* ptr = &val;
					int size = sizeof(char); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(sbyte))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(sbyte*)(ptr + offset);
					}
				};
				Serialize = (entity) =>
				{
					sbyte val = (sbyte)entity;
					sbyte* ptr = &val;
					int size = sizeof(sbyte); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(short))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(short*)(ptr + offset);
					}
				};
				Serialize = (entity) =>
				{
					short val = (short)entity;
					short* ptr = &val;
					int size = sizeof(short); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(int) || type.IsEnum)
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(int*)(ptr + offset);
					}
				};
				Serialize = (entity) =>
				{
					int val = (int)entity;
					int* ptr = &val;
					int size = sizeof(int); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(long))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(long*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					long val = (long)entity;
					long* ptr = &val;
					int size = sizeof(long); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(byte))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(byte*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					byte val = (byte)entity;
					byte* ptr = &val;
					int size = sizeof(byte); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(ushort))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(ushort*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					ushort val = (ushort)entity;
					ushort* ptr = &val;
					int size = sizeof(ushort); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(uint))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(uint*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					uint val = (uint)entity;
					uint* ptr = &val;
					int size = sizeof(uint); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(ulong))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(ulong*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					ulong val = (ulong)entity;
					ulong* ptr = &val;
					int size = sizeof(ulong); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(float))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(float*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					float val = (float)entity;
					float* ptr = &val;
					int size = sizeof(float); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(double))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(double*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					double val = (double)entity;
					double* ptr = &val;
					int size = sizeof(double); ;
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if (type == typeof(decimal))
			{
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						return *(double*)(ptr + offset);
					};
				};
				Serialize = (entity) =>
				{
					decimal val = (decimal)entity;
					decimal* ptr = &val;
					int size = sizeof(decimal);
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
			}
			else if(type == typeof(DateTime))
			{
				Serialize = (entity) => {
					DateTime date = (DateTime)entity;
					long tick = date.Ticks;
					long* ptr = &tick;
					int size = sizeof(long);
					byte[] buffer = new byte[size];
					fixed (byte* dest = buffer)
					{
						Buffer.MemoryCopy(ptr, dest, size, size);
					}
					return buffer;
				};
				Deserialize = (buffer, offset) =>
				{
					fixed (byte* ptr = buffer)
					{
						long tick = *(long*)(ptr + offset);
						return new DateTime(tick);
					};
				};
			}
			else
			{
				Deserialize = (buffer, offset) =>
				{
					object str = Activator.CreateInstance(type);

					int size = Marshal.SizeOf(type);
					IntPtr ptr = Marshal.AllocHGlobal(size);

					Marshal.Copy(buffer, offset, ptr, size);

					str = Marshal.PtrToStructure(ptr, str.GetType());
					Marshal.FreeHGlobal(ptr);

					return str;
				};
				Serialize = (entity) =>
				{
					int size = Marshal.SizeOf(type);
					byte[] arr = new byte[size];

					IntPtr ptr = Marshal.AllocHGlobal(size);
					Marshal.StructureToPtr(entity, ptr, true);
					Marshal.Copy(ptr, arr, 0, size);
					Marshal.FreeHGlobal(ptr);
					return arr;
				};
			}
#else
			if (type == typeof(bool))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToBoolean(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((bool)Convert.ChangeType(entity, typeof(bool)));
				};
			}
			else if (type == typeof(char))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToChar(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((char)Convert.ChangeType(entity, typeof(char)));
				};
			}
			else if (type == typeof(sbyte))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType((sbyte)buffer.First(), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((sbyte)Convert.ChangeType(entity, typeof(sbyte)));
				};
			}
			else if (type == typeof(short))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToInt16(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((short)Convert.ChangeType(entity, typeof(short)));
				};
			}
			else if (type == typeof(int))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToInt32(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((int)Convert.ChangeType(entity, typeof(int)));
				};
			}
			else if (type == typeof(long))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToInt64(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((long)Convert.ChangeType(entity, typeof(long)));
				};
			}
			else if (type == typeof(byte))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(buffer.First(), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((byte)Convert.ChangeType(entity, typeof(byte)));
				};
			}
			else if (type == typeof(ushort))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToUInt16(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((ushort)Convert.ChangeType(entity, typeof(ushort)));
				};
			}
			else if (type == typeof(uint))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToUInt32(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((uint)Convert.ChangeType(entity, typeof(uint)));
				};
			}
			else if (type == typeof(ulong))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToUInt64(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((ulong)Convert.ChangeType(entity, typeof(ulong)));
				};
			}
			else if (type == typeof(float))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToSingle(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((float)Convert.ChangeType(entity, typeof(float)));
				};
			}
			else if (type == typeof(double))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToDouble(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((double)Convert.ChangeType(entity, typeof(double)));
				};
			}
			else if (type == typeof(decimal))
			{
				Deserialize = (buffer) =>
				{
					return Convert.ChangeType(BitConverter.ToInt32(buffer, 0), type);
				};
				Serialize = (entity) => {
					return BitConverter.GetBytes((int)Convert.ChangeType(entity, typeof(decimal)));
				};
			}
			else
			{
				Deserialize = (buffer) => {
					object str = Activator.CreateInstance(type);

					int size = Marshal.SizeOf(str);
					IntPtr ptr = Marshal.AllocHGlobal(size);

					Marshal.Copy(buffer, 0, ptr, size);

					str = Marshal.PtrToStructure(ptr, str.GetType());
					Marshal.FreeHGlobal(ptr);

					return str;
				};
				Serialize = (entity) =>
				{
					int size = Marshal.SizeOf(entity);
					byte[] arr = new byte[size];

					IntPtr ptr = Marshal.AllocHGlobal(size);
					Marshal.StructureToPtr(entity, ptr, true);
					Marshal.Copy(ptr, arr, 0, size);
					Marshal.FreeHGlobal(ptr);
					return arr;
				};
			}
#endif

			#endregion PrimitiveTypes
		}
	}
}