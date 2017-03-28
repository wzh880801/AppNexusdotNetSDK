using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class BuyerSegmentPerformanceReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.BuyerSegmentPerformance;
            }
        }

        public BuyerSegmentPerformanceReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","member_id","insertion_order_id","campaign_id","advertiser_id","line_item_id","pixel_id","segment_id","buying_currency","age_bucket","age_bucket_id","gender" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "today","yesterday","last_7_days","last_month","last_30_days","last_14_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(BuyerSegmentPerformanceReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}