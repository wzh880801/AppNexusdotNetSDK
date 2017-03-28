using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class PlatformSellerSiteDomainPerformanceReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.PlatformSellerSiteDomainPerformance;
            }
        }

        public PlatformSellerSiteDomainPerformanceReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","seller_member_id","bidder_id","site_domain","publisher_id","mobile_application_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "yesterday","last_7_days","month_to_date","last_30_days","month_to_yesterday" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(PlatformSellerSiteDomainPerformanceReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}