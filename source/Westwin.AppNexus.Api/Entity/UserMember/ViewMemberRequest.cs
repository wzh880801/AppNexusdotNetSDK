using System;

namespace Westwin.AppNexus.Api.Entity
{
    public class ViewMemberRequest : AppNexusBaseRequest<ViewMemberResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/member", this.Host);
            }
        }

        public override string QueryString
        {
            get
            {
                return null;
            }
        }

        public ViewMemberRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }
    }
}