using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetAdvertiserLineItemResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _GetAdvertiserLineItemResponse Response { get; set; }

        public class _GetAdvertiserLineItemResponse : AppNexusApiBaseResponse
        {

        }
    }
}