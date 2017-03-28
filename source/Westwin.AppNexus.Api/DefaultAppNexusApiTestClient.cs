using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public class DefaultAppNexusApiTestClient : DefaultWebClient
    {
        public DefaultAppNexusApiTestClient()
            : base("api-test.appnexus.com")
        {
            
        }
    }
}