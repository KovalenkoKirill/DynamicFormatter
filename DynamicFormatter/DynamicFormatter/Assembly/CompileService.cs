using DynamicFormatter.Extentions;
using DynamicFormatter.Generator.Templates;
using DynamicFormatter.Models;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFormatter.Assembly
{
	public static class CompileService
	{	
		public static IEnumerable<DynamicClassResolver> Compile(List<Type> targers)
		{
			CSharpCodeProvider codeProvider = new CSharpCodeProvider();
			CompilerParameters parameters = new CompilerParameters();
			parameters.GenerateInMemory = true;
			parameters.ReferencedAssemblies.Add("DynamicFormatter.dll");
			parameters.CompilerOptions = "/unsafe";
			var dependensyAssembly = GetDllDependency(targers);
			foreach(var ddl in dependensyAssembly)
			{
				parameters.ReferencedAssemblies.Add(ddl);
			}
			parameters.OutputAssembly = Сonstants.Dynamic_Assembly_Name;

			var builder = new StringBuilder();

			foreach(var type in targers)
			{
				var typeInfo = TypeInfo.instanse(type);
				var ReferenceTypeTemplate = new ReferenceTypeTemplate(typeInfo);
				builder.Append(ReferenceTypeTemplate.TransformText());
			}

			BaseModuleTemplate baseTemplate = new BaseModuleTemplate(builder.ToString());
			var module = baseTemplate.TransformText();

			CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, module);

			foreach(var type in targers)
			{
				object obj = results.CompiledAssembly.CreateInstance($"DynamicFormatter.Dynamic.{type.Name}");
				var method = obj.GetType().GetMethod("instanse");
				var desirializeService = (Func<int, DynamicBuffer, Dictionary<int, object>, object>)
				Delegate.CreateDelegate(
							typeof(Func<int, DynamicBuffer, Dictionary<int, object>, object>),
							obj, method);
				yield return new DynamicClassResolver()
				{
					service = obj,
					type = type,
					desirializeService = desirializeService
				};
			}
		}

		public static List<string> GetDllDependency(List<Type> types)
		{
			List<string> ddls = new List<string>();
			foreach(var type in types)
			{
				string name = type.Assembly.ManifestModule.Name;
				if(!ddls.Contains(name))
				{
					ddls.Add(name);
				}
			}
			return ddls;
		}
	}
	public class DynamicClassResolver
	{
		public Type type { get; set; }

		public Func<int, DynamicBuffer, Dictionary<int, object>, object> desirializeService { get; set; }

		public object service { get; set; }
	}
}
