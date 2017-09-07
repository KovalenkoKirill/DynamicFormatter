namespace DynamicFormatter
{
	public class BitSerializer<T> : ISerializer<T>
	{
		private static Serializers.BitSerializer innerSerializer;

		static BitSerializer()
		{
			innerSerializer = Serializers.BitSerializer.GetInstanse(typeof(T));
		}

		public T Deserialize(byte[] buffer)
		{
#if USE_UNSAFE
			return (T)innerSerializer.Deserialize(buffer, 0);
#else
			return (T)innerSerializer.Deserialize(buffer);
#endif
		}

		public byte[] Serialize(T entity)
		{
			return innerSerializer.Serialize(entity);
		}
	}
}