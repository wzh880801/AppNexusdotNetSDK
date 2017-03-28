using System;
using System.Collections.Generic;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetUserRequest : AppNexusBaseRequest<GetUserResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/user", this.Host);
            }
        }

        public List<long> UserIds { get; set; }

        public override string QueryString
        {
            get
            {
                if (UserIds != null && UserIds.Count > 0)
                    return string.Format("id={0}", string.Join(",", UserIds));
                return null;
            }
        }

        public GetUserRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public GetUserRequest(List<long> ids)
            : this()
        {
            this.UserIds = ids;
        }
    }
}