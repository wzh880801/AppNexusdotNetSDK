using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetLineItemMetadataRequest : AppNexusBaseRequest<GetLineItemMetadataResponse>
    {
        private static Dictionary<int, string> _reports = typeof(ReportType).ToDictionary();

        public override string ApiUrl
        {
            get
            {
                var api = string.Format("https://{0}/line-item/meta", this.Host);
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

        public GetLineItemMetadataRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }
    }
}