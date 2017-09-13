using DynamicFormatter.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Generator.Templates
{
	public partial class BaseModuleTemplate : BaseModuleTemplateBase
	{
		public string content;

		public string nameSpace;

		public BaseModuleTemplate(string content)
		{
			this.content = content;
			this.nameSpace = Сonstants.Dynamic_Assembly_Name;
		}
	}
}
