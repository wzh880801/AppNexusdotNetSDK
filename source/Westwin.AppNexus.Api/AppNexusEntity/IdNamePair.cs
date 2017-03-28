using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class IdNamePair
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}