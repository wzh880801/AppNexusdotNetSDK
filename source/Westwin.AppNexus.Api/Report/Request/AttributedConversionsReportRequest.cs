using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class AttributedConversionsReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.AttributedConversions;
            }
        }

        public AttributedConversionsReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id","imp_type","imp_type_id","campaign_id","advertiser_id","line_item_id","pixel_id","auction_id","imp_time","order_id","post_click_or_post_view_conv","datetime","post_click_or_post_view_revenue","external_data","user_id","creative_id","deal_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours","today","yesterday","last_7_days","month_to_date","mtd","last_30_days","month_to_yesterday" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(AttributedConversionsReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}