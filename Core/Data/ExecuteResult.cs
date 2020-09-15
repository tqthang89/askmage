using System;
using System.Collections.Generic;
using System.Data;

namespace Core.Data
{
    public class ExecuteResult
    {
        public Dictionary<string,Object> Outputs => new Dictionary<string,object>();
        public DataTable Result { get; set; }
    }
}
