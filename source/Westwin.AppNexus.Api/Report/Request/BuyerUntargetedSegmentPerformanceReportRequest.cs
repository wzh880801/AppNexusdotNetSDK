using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class BuyerUntargetedSegmentPerformanceReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.BuyerUntargetedSegmentPerformance;
            }
        }

        public BuyerUntargetedSegmentPerformanceReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","insertion_order_id","campaign_id","advertiser_id","line_item_id","pixel_id","segment_id","buying_currency","age_bucket","age_bucket_id","gender","is_targeted","segment_owner_member_id","is_advertiser_segment" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "today","yesterday","last_7_days","last_30_days","last_14_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(BuyerUntargetedSegmentPerformanceReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}