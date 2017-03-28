using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class DataUsageAnalyticsForDataProvidersReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.DataUsageAnalyticsForDataProviders;
            }
        }

        public DataUsageAnalyticsForDataProvidersReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","geo_country","advertiser_currency","campaign_id","geo_country_code","cpm_usd","data_provider_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","yesterday","last_7_days","month_to_date","quarter_to_date","last_month","lifetime","last_24_hours","last_30_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(DataUsageAnalyticsForDataProvidersReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}