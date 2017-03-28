using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkAdvertiserFrequencyRecencyReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkAdvertiserFrequencyRecency;
            }
        }

        public NetworkAdvertiserFrequencyRecencyReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","advertiser_id","line_item_id","campaign_id","size","bid_type","creative_recency_bucket_id","creative_recency_bucket","creative_frequency_bucket_id","creative_frequency_bucket","insertion_order_id","trafficker_for_line_item","salesrep_for_line_item","user_group_for_campaign","creative_id","media_type_id","trafficker_for_insertion_order","salesrep_for_insertion_order","line_item_type","insertion_order_type","mediatype_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_hour","last_48_hours","today","yesterday","last_7_days","last_14_days","last_2_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkAdvertiserFrequencyRecencyReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}