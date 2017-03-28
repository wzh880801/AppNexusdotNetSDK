using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkAnalyticsReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkAnalytics;
            }
        }

        public NetworkAnalyticsReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","seller_member_id","advertiser_id","line_item_id","pub_rule_id","campaign_id","size","geo_country","inventory_class","bid_type","buyer_type","seller_type","imp_type","imp_type_id","advertiser_currency","salesperson_for_advertiser","salesperson_for_publisher","account_manager_for_advertiser","account_manager_for_publisher","pixel_id","site_id","insertion_order_id","payment_type","adjustment_id","publisher_currency","trafficker_for_line_item","salesrep_for_line_item","revenue_type_id","user_group_for_campaign","publisher_id","placement_id","entity_member_id","creative_id","media_type_id","campaign_type","advertiser_type","deal_id","trafficker_for_insertion_order","salesrep_for_insertion_order","line_item_type","insertion_order_type","adjustment_hour","adjustment_day","brand_id","imps_filtered_reason_id","imps_filtered_reason","deal_type","buying_currency","selling_currency","mediatype_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours","today","yesterday","last_7_days","month_to_date","quarter_to_date","last_month","lifetime","mtd","last_30_days","last_14_days","month_to_yesterday","last_2_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkAnalyticsReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}