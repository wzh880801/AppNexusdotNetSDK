using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// This controls who you buy from and whether AppNexus will use their quality and category information for targeting. 
    /// </summary>
    public class InventoryTrust
    {
        /// <summary>
        /// Possible values:
        /// <para>appnexus: Campaigns using inventory quality filtering will only buy AppNexus-audited inventory from sellers unless overridden in the members array.</para>
        /// <para>seller: inventory quality filtering will allow inventory that has been audited by the selling member in AppNexus.</para>
        /// </summary>
        [JsonProperty("default_trust")]
        public string DefaultTrust { get; set; }

        /// <summary>
        /// If true, campaigns using inventory quality filtering will allow unaudited inventory from sellers unless overridden in the members array.
        /// </summary>
        [JsonProperty("default_allow_unaudited")]
        public bool DefaultAllowUnaudited { get; set; }

        /// <summary>
        /// For each selling member, controls banned/eligible for selling to you, whether you trust their inventory audit, and whether you allow unaudited inventory from them.
        /// </summary>
        [JsonProperty("members")]
        public Member[] Members { get; set; }
    }
}