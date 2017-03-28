using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkDeviceAnalyticsReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkDeviceAnalytics;
            }
        }

        public NetworkDeviceAnalyticsReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","buyer_member_id","seller_member_id","advertiser_id","line_item_id","pub_rule_id","campaign_id","publisher_id","size","geo_country","buyer_type","seller_type","imp_type","entity_member_id","imp_type_id","advertiser_currency","pixel_id","insertion_order_id","payment_type","publisher_currency","revenue_type_id","media_type_id","device_model_id","device_make_id","connection_type","device_type","operating_system_id","operating_system_name","browser_id","browser_name","bid_type","selling_currency","buying_currency","mediatype_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "today","yesterday","last_7_days","last_14_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkDeviceAnalyticsReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}