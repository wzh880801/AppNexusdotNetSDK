using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class RrForecastReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.RrForecast;
            }
        }

        public RrForecastReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "member_id","insertion_order_id","campaign_id","advertiser_id","line_item_id","minute" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Minutely;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(RrForecastReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}