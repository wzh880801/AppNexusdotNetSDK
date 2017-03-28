using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class ContentCategoryVolumeReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.ContentCategoryVolume;
            }
        }

        public ContentCategoryVolumeReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","month","seller_member_id","size","geo_country","top_level_category_id","second_level_category_id","domain_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours","today","yesterday","last_7_days","month_to_date","quarter_to_date","last_month","lifetime","mtd","last_30_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(ContentCategoryVolumeReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}