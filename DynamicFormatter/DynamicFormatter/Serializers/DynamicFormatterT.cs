namespace DynamicFormatter
{
	public class DynamicFormatter<T> : ISerializer<T>
	{
		private static Serializers.DynamicFormatter _serializer;

		static DynamicFormatter()
		{
			_serializer = Serializers.DynamicFormatter.Instance(typeof(T));
		}

		public T Deserialize(byte[] buffer)
		{
			return (T)_serializer.Deserialize(buffer);
		}

		public byte[] Serialize(T entity)
		{
			return _serializer.Serialize(entity);
		}
	}
}