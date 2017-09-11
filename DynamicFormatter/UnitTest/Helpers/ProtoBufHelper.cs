using ProtoBuf;
using System.IO;

namespace UnitTest.Helpers
{
	public static class ProtoBufHelper
	{
		public static byte[] ProtoSerialize<T>(T record)
		{
			if (null == record) return null;

			try
			{
				using (var stream = new MemoryStream())
				{
					ProtoBuf.Serializer.Serialize(stream, record);
					return stream.ToArray();
				}
			}
			catch
			{
				// Log error
				throw;
			}
		}

		public static T ProtoDeserialize<T>(byte[] data)
		{
			if (null == data) return default(T);

			try
			{
				using (var stream = new MemoryStream(data))
				{
					return Serializer.Deserialize<T>(stream);
				}
			}
			catch
			{
				// Log error
				throw;
			}
		}
	}
}
