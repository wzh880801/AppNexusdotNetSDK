using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkBillingReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkBilling;
            }
        }

        public NetworkBillingReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","seller_member_id","advertiser_id","line_item_id","publisher_id","buyer_type","seller_type","imp_type","imp_type_id","advertiser_currency","salesperson_for_advertiser","salesperson_for_publisher","account_manager_for_advertiser","account_manager_for_publisher","cleared_direct","payment_type","adjustment_id","publisher_currency","buyer_currency","entity_member_id","campaign_id","campaign_name","campaign","creative_id","placement_id","placement_name","placement","trafficker_for_line_item","salesrep_for_line_item","revenue_type_id","insertion_order_id" };
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

        private static Dictionary<int, string> _reportColumns = typeof(NetworkBillingReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}