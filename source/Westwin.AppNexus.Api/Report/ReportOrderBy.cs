using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class ReportOrderBy
    {
        public string OrderBy { get; set; }

        public OrderDirection Direction { get; set; }

        private static Dictionary<int, string> _dics = typeof(OrderDirection).ToDictionary();

        public override string ToString()
        {
            return string.Format("{{\"order_by\":\"{0}\", \"direction\":\"{1}\"}}", this.OrderBy, _dics[(int)this.Direction]);
        }
    }
}