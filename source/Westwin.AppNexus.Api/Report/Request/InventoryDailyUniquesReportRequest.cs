using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class InventoryDailyUniquesReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.InventoryDailyUniques;
            }
        }

        public InventoryDailyUniquesReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "day","member_id","publisher_id","content_category_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Daily;
            }
        }

        private static string[] _intervals = new string[] { "today","yesterday" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(InventoryDailyUniquesReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}