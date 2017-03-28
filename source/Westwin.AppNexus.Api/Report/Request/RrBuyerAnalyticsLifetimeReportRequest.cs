using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class RrBuyerAnalyticsLifetimeReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.RrBuyerAnalyticsLifetime;
            }
        }

        public RrBuyerAnalyticsLifetimeReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id","advertiser_currency","insertion_order_id","campaign_id","advertiser_id","campaign_group_id","pixel_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Lifetime;
            }
        }

        private static string[] _intervals = new string[] { "lifetime" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(RrBuyerAnalyticsLifetimeReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}