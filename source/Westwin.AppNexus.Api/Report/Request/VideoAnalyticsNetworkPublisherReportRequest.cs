using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class VideoAnalyticsNetworkPublisherReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.VideoAnalyticsNetworkPublisher;
            }
        }

        public VideoAnalyticsNetworkPublisherReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","buyer_member_id","placement_id","advertiser_id","publisher_id","geo_country","site_id","publisher_currency","member_id","deal_id","mobile_application_id","brand_id","video_context","video_playback_method","video_player_size","site_domain","supply_type" };
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

        private static Dictionary<int, string> _reportColumns = typeof(VideoAnalyticsNetworkPublisherReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}