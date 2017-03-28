using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkAnalyticsFeedReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkAnalyticsFeed;
            }
        }

        public NetworkAnalyticsFeedReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id","seller_member_id","placement_id","advertiser_id","line_item_id","pub_rule_id","publisher_id","size","geo_country","bid_type","buyer_type","seller_type","imp_type","imp_type_id_DEPRECATED","advertiser_currency","campaign_id","pixel_id","site_id","insertion_order_id","external_inv_id","payment_type","adjustment_id","publisher_currency","width","height","entity_member_id","media_subtype_id","media_type_id","deal_id","creative_id","deal_type" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_2_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkAnalyticsFeedReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}