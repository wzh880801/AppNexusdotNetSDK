using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// Base Api Client
    /// <para>You should handle the token-refreshing by your self.</para>
    /// </summary>
    public class DefaultAppNexusApiClient : DefaultWebClient
    {
        public DefaultAppNexusApiClient()
            : base("api.appnexus.com")
        {

        }
    }
}