using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetLineItemMetadataResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _GetLineItemMetadataResponse Response { get; set; }

        public class _GetLineItemMetadataResponse : AppNexusApiBaseResponse
        {

        }
    }
}