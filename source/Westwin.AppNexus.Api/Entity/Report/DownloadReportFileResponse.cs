using System;
using SimpleWebRequestHelper.Enum;

namespace Westwin.AppNexus.Api.Entity
{
    public class DownloadReportFileResponse : AppNexusBaseResponse
    {
        public string ReportFilePath
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.ResponseBase64String))
                    return null;

                return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(this.ResponseBase64String));
            }
        }

        public override ResponseType ResponseType
        {
            get
            {
                return ResponseType.Stream;
            }
        }

        public bool Success
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.ReportFilePath) && System.IO.File.Exists(this.ReportFilePath);
            }
        }
    }
}