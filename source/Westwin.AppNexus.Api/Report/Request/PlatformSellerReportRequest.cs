﻿using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public class PlatformSellerReportRequest : ReportRequest
    {
        public override ReportType ReportType
        {
            get
            {
                return ReportType.PlatformSeller;
            }
        }

        public PlatformSellerReportColumn[] Columns { get; set; }

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ "hour","day","year","buyer_member_id","seller_member_id","tag_id","publisher_id","size","geo_country","imp_type","imp_type_id_DEPRECATED","gender","site_id","is_dw","bidder_id","price_bucket_id","is_delivered","cleared_direct","seller_currency" };
            }
        }

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity.Hourly;
            }
        }

        private static string[] _intervals = new string[] { "current_hour","last_hour","last_48_hours","today","yesterday","last_7_days","month_to_date","quarter_to_date","last_month","lifetime","mtd","month_to_yesterday" };

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }

        private static Dictionary<int, string> _reportColumns = typeof(PlatformSellerReportColumn).ToDictionary();

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }
    }
}