using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class TpasAnalyticsReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.TpasAnalytics;
            }
        }

        public TpasAnalyticsReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id","creative_id","advertiser_currency","insertion_order_id","io_id","campaign_id","advertiser_id","line_item_id","pixel_id","ymd","tpas_pixel_name","tpas_id","tpas_name","timezone","tpas_placement_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "yesterday","last_7_days","month_to_date","last_month","last_30_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(TpasAnalyticsReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}