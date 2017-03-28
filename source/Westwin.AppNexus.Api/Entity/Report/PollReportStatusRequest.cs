using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class PollReportStatusRequest : AppNexusBaseRequest<PollReportStatusResponse>
    {
        public override string ApiUrl
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.ReportId))
                    throw new Exception("Invalid report id");

                return string.Format("https://{0}/report?id={1}", this.Host, this.ReportId);
            }
        }

        public override string QueryString
        {
            get
            {
                return "";
            }
        }

        public string ReportId { get; set; }

        public PollReportStatusRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public PollReportStatusRequest(string report_id) 
            : this()
        {
            this.ReportId = report_id;
        }
    }
}