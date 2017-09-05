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
			return (T)innerSerializer.Deserialize(buffer);
		}

		public byte[] Serialize(T entity)
		{
			return innerSerializer.Serialize(entity);
		}
	}
}