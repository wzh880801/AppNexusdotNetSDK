using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class OptDashAnalyticsTestReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.OptDashAnalyticsTest;
            }
        }

        public OptDashAnalyticsTestReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "tag_id","advertiser_id","campaign_id","entity_member_id","imp_type_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours","today","yesterday","last_7_days","month_to_date","quarter_to_date","last_month","lifetime","mtd","last_100_days","month_to_yesterday" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(OptDashAnalyticsTestReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}