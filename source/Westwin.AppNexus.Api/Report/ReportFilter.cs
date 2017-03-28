using System;

namespace Westwin.AppNexus.Api.Report
{
    public class ReportFilter
    {
        public string Name { get; set; }

        public object Value { get; set; }

        public override string ToString()
        {
            return string.Format("{{\"{0}\":{2}{1}{2}}}", this.Name, this.Value, this.Value.GetType().IsValueType ? "" : "\"");
        }
    }
}