using DynamicFormatter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.interfaces
{
	public interface IResolver<T>
	{
		object instanse(int offset, DynamicBuffer buffer, Dictionary<int, object> referenceMaping);
	}
}
