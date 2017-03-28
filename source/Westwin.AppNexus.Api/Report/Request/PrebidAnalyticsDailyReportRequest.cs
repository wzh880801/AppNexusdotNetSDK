using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class PrebidAnalyticsDailyReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.PrebidAnalyticsDaily;
            }
        }

        public PrebidAnalyticsDailyReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","seller_member_id","bidder_code" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "today","yesterday","last_7_days","month_to_date","last_30_days","last_14_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(PrebidAnalyticsDailyReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}