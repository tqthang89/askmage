﻿using System;
namespace Core.Data.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class ParameterAttribute : Attribute
    {
        public string Name { get; set; }

        public ParameterAttribute(string paramaterName)
        {
            this.Name = paramaterName;
        }
    }
}
