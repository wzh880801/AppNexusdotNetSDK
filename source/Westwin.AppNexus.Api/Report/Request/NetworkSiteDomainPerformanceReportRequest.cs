using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkSiteDomainPerformanceReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkSiteDomainPerformance;
            }
        }

        public NetworkSiteDomainPerformanceReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","buyer_member_id","seller_member_id","advertiser_currency","insertion_order_id","campaign_id","advertiser_id","campaign_group_id","line_item_id","pixel_id","site_domain","second_level_category_id","top_level_category_id","top_level_category","fold_position_id","operating_system_id","operating_system_name","deal_id","supply_type","mobile_application_id","buying_currency","age_bucket","age_bucket_id","gender" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "yesterday","last_7_days","month_to_date","last_30_days","month_to_yesterday" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkSiteDomainPerformanceReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}