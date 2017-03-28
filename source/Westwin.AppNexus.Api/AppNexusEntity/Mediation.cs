using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// Indicates whether automatic bid adjustments and reporting sync are enabled for this member. 
    /// See Mediation below for the definitions of the objects in this array.
    /// </summary>
    public class Mediation
    {
        /// <summary>
        /// If true , this member can use the automatic bid adjustment feature, in which AppNexus suggests a bid based on an estimate what the network will pay and automatically updates the bid as conditions change.
        /// </summary>
        [JsonProperty("auto_bid_adjustment_enabled")]
        public bool AutoBidAdjustmentEnabled { get; set; }

        /// <summary>
        /// If true, this member can use the reporting sync feature, in which reporting data from third-party networks can be pulled from that network's servers. 
        /// This data is used to create daily reports and monitor trends directly from Console.
        /// </summary>
        [JsonProperty("reporting_sync_enabled")]
        public bool ReportingSyncEnabled { get; set; }
    }
}