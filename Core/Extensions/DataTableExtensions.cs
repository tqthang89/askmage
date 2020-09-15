using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Aca.MondelezGT.Extensions
{
    public static class DataTableExtensions
    {
        public static IList<IDictionary<string,object>> ToList(this DataRow[] rows)
        {
            if(rows == null || rows.Length == 0)
            {
                return null;
            }
            List<IDictionary<string, object>> keyValues = new List<IDictionary<string, object>>();
            foreach (var item in rows)
            {
                IDictionary<string, object> values = new Dictionary<string, object>();
                foreach (DataColumn col in item.Table.Columns)
                {
                    values.Add(col.ColumnName, item[col]);
                }
                keyValues.Add(values);
            }
            return keyValues;
        }
    }
}
