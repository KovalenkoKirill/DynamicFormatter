using System;
using static System.Buffer;

namespace DynamicFormatter.Models
{
	internal class DynamicBuffer
	{
		private byte[] bytes;

		private int size = 0;

		#region constructor

		public DynamicBuffer(int startSize)
		{
			bytes = new byte[startSize];
		}

		public DynamicBuffer(byte[] readyBuffer)
		{
			bytes = readyBuffer;
			size = readyBuffer.Length;
		}

		#endregion constructor

		public int CurrentPoint
		{
			get
			{
				return size;
			}
		}

		public BufferPtr Alloc(int Count)
		{
			int currentPtr = size;
			size += Count;
			TryResize(Count);
			return new BufferPtr(this, currentPtr, Count);
		}

		public BufferPtr GetPtr(int position, int count)
		{
			return new BufferPtr(this, position, count);
		}

		public int Copy(byte[] buffer)
		{
			return Copy(buffer, size);
		}

		public int Copy(byte[] buffer, int point)
		{
			int lenghtNeeded = point + buffer.Length;
			TryResize(lenghtNeeded);
			BlockCopy(buffer, 0, bytes, point, buffer.Length);
			return point;
		}

		public byte[] Buffer
		{
			get
			{
				byte[] result = new byte[size];
				BlockCopy(bytes, 0 ,result, 0, size);
				return result;
			}
		}

		private void TryResize(int lenghtNeeded)
		{
			if (bytes.Length < lenghtNeeded)
			{
				byte[] nextBuffer = new byte[lenghtNeeded * 2];
				BlockCopy(bytes,0, nextBuffer,0, bytes.Length);
				bytes = nextBuffer;
				size = lenghtNeeded;
			}
		}

		public class BufferPtr
		{
			public short position { get; }

			public int lenght { get; }

			private readonly DynamicBuffer buffer;

			internal BufferPtr(DynamicBuffer buffer, int position, int lenght)
			{
				this.buffer = buffer;
				this.position = (short)position;
				this.lenght = lenght;
			}

			public byte[] Read()
			{
				byte[] readBytes = new byte[lenght];
				BlockCopy(buffer.bytes, position, readBytes, 0, lenght);
				return readBytes;
			}

			public void Set(byte[] buffer)
			{
				BlockCopy(buffer, 0, this.buffer.bytes, position, lenght);
			}
		}
	}
}