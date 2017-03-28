using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetUserResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _GetUserResponse Response { get; set; }

        public class _GetUserResponse : AppNexusApiBaseResponse
        {
            [JsonProperty("users")]
            public User[] Users { get; set; }
        }
    }
}