﻿using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class SegmentLoadReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.SegmentLoad;
            }
        }

        public SegmentLoadReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "member_id","segment_id" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","today","yesterday","last_7_days","month_to_date","mtd" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(SegmentLoadReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}