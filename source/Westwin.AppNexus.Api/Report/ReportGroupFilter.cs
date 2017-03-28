using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class ReportGroupFilter
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public Operator Operaor { get; set; }

        private static Dictionary<int, string> _dics = typeof(Operator).ToDictionary();

        public override string ToString()
        {
            return string.Format(
@"{{
            ""{0}"": {{
                ""value"": {1},
                ""operator"": ""{2}""
            }}
        }}", this.Name, string.Format("{0}{1}{0}", this.Value.GetType().IsValueType ? "" : "\"", this.Value), _dics[(int)this.Operaor]);
        }
    }
}