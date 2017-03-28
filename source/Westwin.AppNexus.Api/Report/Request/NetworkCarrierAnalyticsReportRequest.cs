using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkCarrierAnalyticsReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkCarrierAnalytics;
            }
        }

        public NetworkCarrierAnalyticsReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","buyer_member_id","seller_member_id","advertiser_id","line_item_id","pub_rule_id","campaign_id","publisher_id","size","geo_country","buyer_type","seller_type","imp_type","entity_member_id","imp_type_id","advertiser_currency","pixel_id","insertion_order_id","payment_type","publisher_currency","revenue_type_id","media_type_id","carrier_id","connection_type","device_type","bid_type","mediatype_id" };
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

        private static Dictionary<int, string> _reportColumns = typeof(NetworkCarrierAnalyticsReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}