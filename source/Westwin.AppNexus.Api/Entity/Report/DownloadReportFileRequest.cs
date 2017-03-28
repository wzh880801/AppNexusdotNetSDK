using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class DownloadReportFileRequest : AppNexusBaseRequest<DownloadReportFileResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/{1}", this.Host, this.DownloadUrl);
            }
        }

        public override string QueryString
        {
            get
            {
                return "";
            }
        }

        public string DownloadUrl { get; set; }

        public DownloadReportFileRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public DownloadReportFileRequest(string download_url)
            : this()
        {
            this.DownloadUrl = download_url;
        }
    }
}