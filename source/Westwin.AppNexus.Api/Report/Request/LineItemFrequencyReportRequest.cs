﻿using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class LineItemFrequencyReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.LineItemFrequency;
            }
        }

        public LineItemFrequencyReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","month","buyer_member_id","insertion_order_id","campaign_id","advertiser_id","line_item_id","pixel_id","buying_currency","line_item_frequency_bucket_id","line_item_frequency_bucket" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_48_hours","today","yesterday","last_7_days","month_to_date","last_24_hours","last_30_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(LineItemFrequencyReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}