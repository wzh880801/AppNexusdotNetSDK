using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class NetworkAnalyticsProvisionalReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.NetworkAnalyticsProvisional;
            }
        }

        public NetworkAnalyticsProvisionalReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","seller_member_id","advertiser_id","member_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(NetworkAnalyticsProvisionalReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}