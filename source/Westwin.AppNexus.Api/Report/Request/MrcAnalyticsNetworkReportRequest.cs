using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class MrcAnalyticsNetworkReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.MrcAnalyticsNetwork;
            }
        }

        public MrcAnalyticsNetworkReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id","seller_member_id","placement_id","advertiser_id","publisher_id","creative_id","line_item_id","member_id","campaign_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "yesterday","last_7_days","quarter_to_date","last_30_days","last_2_days","last_365_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(MrcAnalyticsNetworkReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}