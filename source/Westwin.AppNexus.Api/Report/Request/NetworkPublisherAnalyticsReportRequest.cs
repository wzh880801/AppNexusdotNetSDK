using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkPublisherAnalyticsReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkPublisherAnalytics;
            }
        }

        public NetworkPublisherAnalyticsReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","seller_member_id","placement_id","advertiser_id","line_item_id","pub_rule_id","campaign_id","publisher_id","size","geo_country","inventory_class","buyer_type","imp_type","imp_type_id","predict_rev_type","site_id","external_inv_id","payment_type","adjustment_id","publisher_currency","venue","revenue_type_id","member_id","media_type_id","deal_id","creative_id","brand_id","imps_filtered_reason_id","imps_filtered_reason","mediatype_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours","today","yesterday","last_7_days","month_to_date","quarter_to_date","last_month","lifetime","mtd","last_30_days","month_to_yesterday","last_2_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkPublisherAnalyticsReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}