using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// You can use the read-only Label Service to view all possible labels for line items, advertisers, insertion orders, campaigns, and publishers. 
    /// This service also allows you to view the labels that have already been applied to your objects.
    /// </summary>
    public class Labels
    {
        private Dictionary<int, string> _dics = typeof(LabelType).ToDictionary();

        /// <summary>
        /// The ID of the label. Possible values: 7, 8, 11.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        public LabelType LabelType { get; set; } = LabelType.CampaignType;

        /// <summary>
        /// Read-only. The name of the label. Possible values: "Trafficker", "Sales Rep", or "Campaign Type".
        /// </summary>
        [JsonProperty("name")]
        internal string Name
        {
            get
            {
                return _dics[(int)this.LabelType];
            }
            set
            {
                foreach(var c in _dics)
                {
                    if(c.Value == value)
                    {
                        this.LabelType = (LabelType)c.Key;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}