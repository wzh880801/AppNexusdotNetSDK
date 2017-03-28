using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class RrBuyerAnalyticsHourlyReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.RrBuyerAnalyticsHourly;
            }
        }

        public RrBuyerAnalyticsHourlyReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","buyer_member_id","creative_id","advertiser_currency","insertion_order_id","io_id","campaign_id","advertiser_id","campaign_group_id","pixel_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","today","yesterday","last_7_days","month_to_date","last_24_hours","last_available_day","last_7_available_days","last_14_available_days","last_30_available_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(RrBuyerAnalyticsHourlyReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}