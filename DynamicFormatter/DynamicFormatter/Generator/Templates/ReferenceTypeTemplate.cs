﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Версия среды выполнения: 14.0.0.0
//  
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace DynamicFormatter.Generator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using DynamicFormatter.Extentions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ReferenceTypeTemplate : ReferenceTypeTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using DynamicFormatter.interfaces;\r\nusing DynamicFormatter.Generator;\r\nusing Dyna" +
                    "micFormatter.Extentions;\r\nusing System.Runtime.Serialization;\r\n\r\nnamespace ");
            
            #line 13 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.nameSpace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 15 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.className));
            
            #line default
            #line hidden
            this.Write(" :IResolver<");
            
            #line 15 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Type.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n\t{\r\n\t");
            
            #line 17 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
foreach(var type in this.referenceFields)
	  {
		
            
            #line default
            #line hidden
            this.Write("public IResolver<");
            
            #line 19 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.FullName));
            
            #line default
            #line hidden
            this.Write("> _");
            
            #line 19 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("Resolver = null;\r\n\r\n\t\tpublic IResolver<");
            
            #line 21 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.FullName));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 21 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("Resolver\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\tif(_");
            
            #line 25 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("Resolver == null)\r\n\t\t\t\t{\r\n\t\t\t\t\t_");
            
            #line 27 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("Resolver = TypeResolveFactory.GetResolver<");
            
            #line 27 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write(">();\r\n\t\t\t\t}\r\n\t\t\t\treturn _");
            
            #line 29 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type.Name));
            
            #line default
            #line hidden
            this.Write("Resolver;\r\n\t\t\t}\r\n\t\t}\r\n\t\t\r\n\t");
            
            #line 33 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t\tpublic ");
            
            #line 35 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Type.FullName));
            
            #line default
            #line hidden
            this.Write(" instanse(byte[] buffer, int offset)\r\n\t\t{\r\n\t\t\tvar entity = (");
            
            #line 37 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Type.FullName));
            
            #line default
            #line hidden
            this.Write(")FormatterServices.GetSafeUninitializedObject(typeof(");
            
            #line 37 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeInfo.Type.FullName));
            
            #line default
            #line hidden
            this.Write("));\r\n\t\t\toffset++;\r\n\t\t\t");
            
            #line 39 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
foreach(var field in this.typeInfo.Fields)
			{
				if(this.isPrimitive(field))
				{
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\r\n\t\t\tentity.");
            
            #line 44 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write(" = BaseConvertor.Get");
            
            #line 44 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.GetTypePrefix(field)));
            
            #line default
            #line hidden
            this.Write("(buffer, offset);\r\n\r\n\t\t\toffset += ");
            
            #line 46 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.GetSizeInBuffer(field)));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\t\t\t\t");
            
            #line 48 "C:\Users\kkovalenko\Documents\DynamicFormatter\DynamicFormatter\DynamicFormatter\Generator\Templates\ReferenceTypeTemplate.tt"
}
			}
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn entity;\r\n\t\t}\r\n\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class ReferenceTypeTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
