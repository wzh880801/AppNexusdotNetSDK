using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class AccountOwnerUser
    {
        [JsonProperty("id")]
        public long UserId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}