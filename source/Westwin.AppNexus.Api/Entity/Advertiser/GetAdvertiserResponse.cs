using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetAdvertiserResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _GetAdvertiserResponse Response { get; set; }

        public class _GetAdvertiserResponse : AppNexusApiBaseResponse
        {
            [JsonProperty("advertisers")]
            public Advertiser[] Advertisers { get; set; }
        }
    }
}