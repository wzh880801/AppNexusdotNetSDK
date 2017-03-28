using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class SubmitReportRequest : AppNexusBaseRequest<SubmitReportResponse>
    {
        private static Dictionary<int, string> _reportTypes = typeof(ReportType).ToDictionary();
        private static Dictionary<int, string> _reportIntervals = typeof(ReportInterval).ToDictionary();
        private static Dictionary<int, string> _reportFormats = typeof(ReportFormat).ToDictionary();
        private static Dictionary<int, string> _reportDecimalType = typeof(ReportingDecimalType).ToDictionary();
        private static Dictionary<int, string> _reportTimezone = typeof(ReportTimezone).ToDictionary();

        public override string ApiUrl
        {
            get
            {
                var api = string.Format("https://{0}/report", this.Host);
                if (!string.IsNullOrWhiteSpace(this.SavedReportId))
                    api = string.Format("{0}?saved_report_id={1}", api, this.SavedReportId);
                if (this.ReportRequest.AdvertiserId.HasValue)
                {
                    api = string.Format("{0}{1}advertiser_id={2}", api, api.Contains("?") ? "&" : "?", this.ReportRequest.AdvertiserId);
                }
                if (this.ReportRequest.PublisherId.HasValue)
                {
                    api = string.Format("{0}{1}publisher_id={2}", api, api.Contains("?") ? "&" : "?", this.ReportRequest.PublisherId);
                }
                return api;
            }
        }

        public override string QueryString
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SavedReportId))
                    return null;

                //reportInterval check
                var dateRange = "";
                if (this.ReportRequest.ReportInterval != ReportInterval.Custom)
                {
                    if (!this.ReportRequest.AcceptTimeIntervals.Contains(this.ReportRequest.ReportInterval))
                        throw new Exception(string.Format("report '{0}' doesn't support {1}",
                                                _reportTypes[(int)this.ReportRequest.ReportType],
                                                _reportIntervals[(int)this.ReportRequest.ReportInterval]));

                    dateRange = string.Format(@"""report_interval"": ""{0}"",", _reportIntervals[(int)this.ReportRequest.ReportInterval]);
                }
                else
                {
                    dateRange = string.Format(@"""start_date"": ""{0}"",
        ""end_date"": ""{1}"",",
                        this.ReportRequest.AcceptTimeGranularity == TimeGranularity.Hourly ? this.ReportRequest.ReportStartDate.ToString("yyyy-MM-dd HH:00:00") : this.ReportRequest.ReportStartDate.ToString("yyyy-MM-dd"),
                        this.ReportRequest.AcceptTimeGranularity == TimeGranularity.Hourly ? this.ReportRequest.ReportEndDate.ToString("yyyy-MM-dd HH:00:00") : this.ReportRequest.ReportEndDate.ToString("yyyy-MM-dd"));
                }

                //filter check
                if (this.ReportRequest.Filters != null && this.ReportRequest.Filters.Length > 0)
                {
                    foreach(var f in this.ReportRequest.Filters)
                    {
                        if (!this.ReportRequest.AcceptFilters.Contains(f.Name))
                            throw new Exception(string.Format("Filter '{0}' is not supported by report '{1}'", f.Name, this.ReportRequest.ReportType));
                    }
                }

                return
 @"{
    ""report"": {
        ""report_type"": """ + _reportTypes[(int)this.ReportRequest.ReportType] + @""",
        " + dateRange + @"
        ""columns"": [" + this.ReportRequest.GetColumns() + @"]," +
        this.ReportRequest.GetFilters() +
        this.ReportRequest.GetOrderBys() + @"
        ""format"": """ + _reportFormats[(int)this.ReportRequest.Format] + @"""," + 
        this.ReportRequest.GetGroupFilters() + @"
        ""reporting_decimal_type"": """ + _reportDecimalType[(int)this.ReportRequest.ReportingDecimalType] + @"""," + this.ReportRequest.GetEmails() + @"
        ""escape_fields"": " + this.ReportRequest.EscapeFields.ToString().ToLower() + @",
        ""timezone"": """ + _reportTimezone[(int)this.ReportRequest.TimeZone] + @"""
    }
}";
            }
        }

        public Report.ReportRequest ReportRequest { get; set; } 

        public string SavedReportId { get; set; }

        public SubmitReportRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.POST;
            this.ContentType = SimpleWebRequestHelper.Enum.ContentTypes.JSON;
        }

        public SubmitReportRequest(string saved_report_id) 
            : this()
        {
            this.SavedReportId = saved_report_id;
        }

        public SubmitReportRequest(Report.ReportRequest report_request) 
            : this()
        {
            this.ReportRequest = report_request;
        }
    }
}