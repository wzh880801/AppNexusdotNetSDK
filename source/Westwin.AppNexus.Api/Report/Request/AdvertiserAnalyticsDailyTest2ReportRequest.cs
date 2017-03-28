using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class AdvertiserAnalyticsDailyTest2ReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.AdvertiserAnalyticsDailyTest2;
            }
        }

        public AdvertiserAnalyticsDailyTest2ReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "buyer_member_id2","seller_member_id","placement_id","imp_type_id","advertiser_currency","campaign_id","line_item_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Monthly;
            }
        }

        private static string[] _intervals = new string[] { "last_hour","today","yesterday","last_7_days","last_100_days","last_2_days","last_7_available_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(AdvertiserAnalyticsDailyTest2ReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}