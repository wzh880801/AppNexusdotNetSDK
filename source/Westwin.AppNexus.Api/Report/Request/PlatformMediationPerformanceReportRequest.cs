using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class PlatformMediationPerformanceReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.PlatformMediationPerformance;
            }
        }

        public PlatformMediationPerformanceReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","placement_id","publisher_id","creative_id","creative_recency_bucket_id","creative_frequency_bucket_id","site_id","width","height","geo_country","creative_custom_request_template_id","os_family_id","fill_rate","revenue","latency_50_percentile","latency_95_percentile","device_type" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "custom" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(PlatformMediationPerformanceReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}