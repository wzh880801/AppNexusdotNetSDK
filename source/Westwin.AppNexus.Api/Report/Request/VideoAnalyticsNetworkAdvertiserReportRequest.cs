using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class VideoAnalyticsNetworkAdvertiserReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.VideoAnalyticsNetworkAdvertiser;
            }
        }

        public VideoAnalyticsNetworkAdvertiserReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","seller_member_id","line_item_id","size","geo_country","advertiser_currency","campaign_id","advertiser_id","insertion_order_id","site_domain","publisher_id","placement_id","member_id","creative_id","deal_id","trafficker_for_insertion_order","salesrep_for_insertion_order","mobile_application_id","creative_recency_bucket_id","creative_recency_bucket","creative_frequency_bucket_id","creative_frequency_bucket","video_context","video_playback_method","video_player_size","supply_type" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","today","yesterday","last_7_days","month_to_date","last_month","last_24_hours","last_30_days","last_14_days","month_to_yesterday","last_2_days","last_available_day","last_7_available_days","last_14_available_days","last_30_available_days","last_365_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(VideoAnalyticsNetworkAdvertiserReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}