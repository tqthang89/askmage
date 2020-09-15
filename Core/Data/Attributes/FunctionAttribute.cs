using System;
using System.Reflection;

namespace Core.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple = false)]
    public class FunctionAttribute : Attribute
    {
        public string Name { get; set; }

        public FunctionAttribute(string paramaterName)
        {
            this.Name = paramaterName;
        }
    }
}
