using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class SellerSiteDomainReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.SellerSiteDomain;
            }
        }

        public SellerSiteDomainReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","seller_member_id","placement_id","publisher_id","content_category_id","imp_type_id","age_bucket_id","age_bucket","gender","site_id","site_domain","audit_type_id","exposed_for_resale_id","domains_exposed_id","fold_position_id","operating_system_id","operating_system_name","supply_type","mobile_application_id","imps_filtered_reason_id","imps_filtered_reason" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "yesterday","last_7_days","month_to_date","last_month","last_30_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(SellerSiteDomainReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}