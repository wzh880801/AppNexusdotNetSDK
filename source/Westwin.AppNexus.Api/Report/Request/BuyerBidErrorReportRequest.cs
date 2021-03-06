﻿using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class BuyerBidErrorReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.BuyerBidErrorReport;
            }
        }

        public BuyerBidErrorReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","buyer_member_id","seller_member_id","publisher_id","creative_size","creative_id","brand_id","deal_id","ad_profile_id","creative_category_id","error_id","language_id","technical_attribute_id","creative_code" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "last_hour","yesterday","last_7_days","last_24_hours","last_30_days","last_2_days" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(BuyerBidErrorReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}