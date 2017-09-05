using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Models
{
	public struct GetterAndSetter
	{
		public Func<object, object> Getter { get; set; }

		public Action<object, object> Setter { get; set; }
	}
}
