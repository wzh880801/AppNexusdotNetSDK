using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class RrBidAnalyzerReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.RrBidAnalyzer;
            }
        }

        public RrBidAnalyzerReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id","line_item_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Minutely;
            }
        }

        private static string[] _intervals = new string[] { "lifetime" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(RrBidAnalyzerReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}