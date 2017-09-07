using System;

namespace DynamicFormatter.Models
{
	public struct GetterAndSetter
	{
		public Func<object, object> Getter { get; set; }

		public Action<object, object> Setter { get; set; }
	}
}