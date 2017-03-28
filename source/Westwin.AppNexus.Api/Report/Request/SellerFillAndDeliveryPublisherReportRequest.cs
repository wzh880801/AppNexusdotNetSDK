using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class SellerFillAndDeliveryPublisherReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.SellerFillAndDeliveryPublisher;
            }
        }

        public SellerFillAndDeliveryPublisherReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","seller_member_id","placement_id","publisher_id","geo_country","site_id","deal_id","mobile_application_id","site_domain","supply_type","call_type" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","today","yesterday","last_7_days","last_24_hours","last_14_days","last_2_days","last_available_day","last_7_available_days","last_14_available_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(SellerFillAndDeliveryPublisherReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}