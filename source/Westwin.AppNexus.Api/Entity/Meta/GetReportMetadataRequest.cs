using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetReportMetadataRequest : AppNexusBaseRequest<GetReportMetadataResponse>
    {
        private static Dictionary<int, string> _reports = typeof(ReportType).ToDictionary();

        public override string ApiUrl
        {
            get
            {
                var api = string.Format("https://{0}/report?meta", this.Host);
                if (this.ReportType.HasValue)
                    api = string.Format("{0}={1}", api, _reports[(int)this.ReportType.Value]);
                return api;
            }
        }

        public override string QueryString
        {
            get
            {
                return null;
            }
        }

        public ReportType? ReportType { get; set; }

        public GetReportMetadataRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public GetReportMetadataRequest(ReportType reportType)
            : this()
        {
            this.ReportType = reportType;
        }
    }
}