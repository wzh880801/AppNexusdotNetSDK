using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class SubmitReportResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _SubmitReportResponse Response { get; set; }

        public class _SubmitReportResponse : AppNexusApiBaseResponse
        {
            [JsonProperty("report_id")]
            public string ReportId { get; set; }
        }
    }
}