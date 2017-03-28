using System;
using System.Collections.Generic;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetAdvertiserRequest : AppNexusBaseRequest<GetAdvertiserResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/advertiser", this.Host);
            }
        }

        public List<long> AdvertiserIds { get; set; }

        public override string QueryString
        {
            get
            {
                if (AdvertiserIds != null && AdvertiserIds.Count > 0)
                    return string.Format("id={0}", string.Join(",", AdvertiserIds));
                return null;
            }
        }

        public GetAdvertiserRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public GetAdvertiserRequest(List<long> ids)
            : this()
        {
            this.AdvertiserIds = ids;
        }
    }
}