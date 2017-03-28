using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class ViewMemberResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _ViewMemberResponse Response { get; set; }

        public class _ViewMemberResponse : AppNexusApiBaseResponse
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("member")]
            public Member Member { get; set; }
        }
    }
}