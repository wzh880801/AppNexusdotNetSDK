using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class SupplementalInvoiceActivityReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.SupplementalInvoiceActivity;
            }
        }

        public SupplementalInvoiceActivityReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","buyer_member_id","seller_member_id","advertiser_currency","insertion_order_id","advertiser_id","campaign_group_id","deal_id","cleared_direct","campaign_id","transaction_type_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","yesterday","last_7_days","month_to_date","last_24_hours","last_30_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(SupplementalInvoiceActivityReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}