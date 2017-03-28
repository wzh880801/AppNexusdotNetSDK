using System;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetAdvertiserLineItemRequest : AppNexusBaseRequest<GetAdvertiserLineItemResponse>
    {
        public override string ApiUrl
        {
            get
            {
                var api = string.Format("https://{0}/line-item", this.Host);
                if (this.AdvertiserId.HasValue)
                    api = string.Format("{0}?advertiser_id={1}", api, this.AdvertiserId);
                else if (!string.IsNullOrWhiteSpace(this.LineItemCode) && !string.IsNullOrWhiteSpace(this.AdvertiserCode))
                    api = string.Format("{0}?code={1}&advertiser_code={2}", api, this.LineItemCode, this.AdvertiserCode);

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

        public long? AdvertiserId { get; set; }

        public string LineItemCode { get; set; }

        public string AdvertiserCode { get; set; }

        public GetAdvertiserLineItemRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public GetAdvertiserLineItemRequest(long advertiserId)
            : this()
        {
            this.AdvertiserId = advertiserId;
        }

        public GetAdvertiserLineItemRequest(string line_item_code, string advertiser_code)
            : this()
        {
            this.LineItemCode = line_item_code;
            this.AdvertiserCode = advertiser_code;
        }
    }
}