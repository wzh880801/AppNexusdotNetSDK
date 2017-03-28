using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class StandardSize
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("is_standard")]
        public bool IsStandard { get; set; }
    }
}