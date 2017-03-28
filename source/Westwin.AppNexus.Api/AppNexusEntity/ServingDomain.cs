using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// Admin-only. The domain through which advertisements are served. 
    /// The format of the object is {"cname":"ad.domain.com","type":null}
    /// </summary>
    public class ServingDomain
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cname")]
        public string CName { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }
    }
}