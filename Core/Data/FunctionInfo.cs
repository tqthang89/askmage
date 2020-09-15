using System;
using System.Data.Common;

namespace Core.Data
{
    public class FunctionInfo
    {
        public string Query { get; set; }
        public DbParameter[] Parameters { get; set; }

    }
}
