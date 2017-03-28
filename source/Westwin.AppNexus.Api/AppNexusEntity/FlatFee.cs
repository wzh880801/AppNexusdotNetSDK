using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class FlatFee
    {
        private static Dictionary<int, string> _dics = typeof(FlatfeeStatus).ToDictionary();

        public FlatfeeStatus Status { get; set; } = FlatfeeStatus.Error;

        [JsonProperty("flat_fee_allocation_date")]
        public DateTime? FlatFeeAllocationDate { get; set; }

        [JsonProperty("flat_fee_status")]
        internal string flat_fee_status
        {
            get
            {
                return _dics[(int)this.Status];
            }
            set
            {
                foreach (var c in _dics)
                {
                    if (c.Value == value)
                    {
                        this.Status = (FlatfeeStatus)c.Key;
                        break;
                    }
                }
            }
        }

        [JsonProperty("flat_fee_adjustment_id")]
        public int? FlatFeeAdjustmentId { get; set; }
    }
}