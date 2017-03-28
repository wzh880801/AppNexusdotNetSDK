using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// The valuation object is used to set performance goals for line items with the goal_type "cpc" or "ctr". 
    /// It contains the performance goal threshold, which determines the bid/no bid cutoff on optimized campaigns, 
    /// and the performance goal target, which represents the desired clicks or click-through rate.
    /// </summary>
    public class Valuation
    {

        /// <summary>
        /// For line items with revenue_type "cpm", "cpa", or "cpc" the minimum margin PCT.
        /// </summary>
        [JsonProperty("min_margin_pct")]
        public decimal? MinMarginPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("max_avg_cpm")]
        public decimal? MaxAvgCpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("min_avg_cpm")]
        public decimal? MinAvgCpm { get; set; }

        /// <summary>
        /// For line items with the goal_type "cpc" or "ctr", the performance goal target, representing the desired clicks or click-through rate.
        /// </summary>
        [JsonProperty("goal_target")]
        public decimal? GoalTarget { get; set; }

        /// <summary>
        /// For line items with the goal_type "cpc" or "ctr", the performance goal threshold, which determines the bid/no bid cutoff on optimized campaigns.
        /// </summary>
        [JsonProperty("goal_threshold")]
        public decimal? GoalThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("no_revenue_log")]
        public bool NoRevenueLog { get; set; }

        /// <summary>
        /// If true, the line item is a performance offer line item. 
        /// This field is applicable only when revenue_type is "cpc" or "cpa". 
        /// Note that once set, this field cannot be changed.
        /// <para>To set this field to false, performance_mkt_crossnet (in the valuation object) must also be false .</para>
        /// <para>To set this field to true, the following requirements must be met:</para>
        /// <para>performance_mkt_managed and/or performance_mkt_crossnet (in the valuation object) must be true</para>
        /// <para>goal_type must be "none"</para>
        /// <para>manage_creative must be true</para>
        /// <para>revenue_type must be "cpa" or "cpc"</para>
        /// <para>If revenue_type is "cpa", post_view_revenue must be null for all associated pixels</para>
        /// <para>If profile_id is set, the associated profile may only target country, supply_type, device_type, operating_system_family, browser, device_model, or carrier</para>
        /// </summary>
        [JsonProperty("performance_offer")]
        public bool PerformanceOffer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("performance_mkt_managed")]
        public bool PerformanceMktManaged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("performance_mkt_crossnet")]
        public bool PerformanceMktCrossnet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bid_price_pacing_enabled")]
        public bool BidPricePacingEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bid_price_pacing_lever")]
        public int BidPricePacingLever { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private CampaignGroupValuationStrategy _strategy = Api.CampaignGroupValuationStrategy.Prospecting;
        public CampaignGroupValuationStrategy CampaignGroupValuationStrategy
        {
            get
            {
                return _strategy;
            }
            set
            {
                _strategy = value;
                _campaign_group_valuation_strategy = _dics[(int)value];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("goal_confidence_threshold")]
        public object GoalConfidenceThreshold { get; set; }

        private static Dictionary<int, string> _dics = typeof(CampaignGroupValuationStrategy).ToDictionary();

        private string _campaign_group_valuation_strategy = "prospecting";

        [JsonProperty("campaign_group_valuation_strategy")]
        internal string campaign_group_valuation_strategy
        {
            get
            {
                return _dics[(int)_strategy];
            }
            set
            {
                _campaign_group_valuation_strategy = value;

                foreach(var c in _dics)
                {
                    if(c.Value == value)
                    {
                        _strategy = (CampaignGroupValuationStrategy)c.Key;
                        break;
                    }
                }
            }
        }
    }
}