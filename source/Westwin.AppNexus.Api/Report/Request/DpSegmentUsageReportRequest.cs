using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class DpSegmentUsageReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.DpSegmentUsage;
            }
        }

        public DpSegmentUsageReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","member_id","campaign_id","segment_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "yesterday","last_30_days","last_14_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(DpSegmentUsageReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}