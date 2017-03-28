using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetSiphonResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _GetSiphonResponse Response { get; set; }

        public class _GetSiphonResponse : AppNexusApiBaseResponse
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("siphons")]
            public SiphonInfo[] Siphons { get; set; }
        }
    }
}