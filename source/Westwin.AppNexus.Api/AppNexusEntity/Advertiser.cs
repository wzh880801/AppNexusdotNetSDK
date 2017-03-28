using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class Advertiser
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_brand_id")]
        public object DefaultBrandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remarketing_segment_id")]
        public object RemarketingSegmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("profile_id")]
        public int ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("control_pct")]
        public int ControlPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member_id")]
        public int MemberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_name")]
        public string BillingName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_phone")]
        public string BillingPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_address1")]
        public string BillingAddress1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_address2")]
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_city")]
        public string BillingCity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_state")]
        public string BillingState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_country")]
        public string BillingCountry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_zip")]
        public string BillingZip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("use_insertion_orders")]
        public bool UseInsertionOrders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time_format")]
        public string TimeFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_malicious")]
        public bool IsMalicious { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_mediated")]
        public bool IsMediated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing_internal_user")]
        public object BillingInternalUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_category")]
        public object DefaultCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_brand")]
        public object DefaultBrand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("labels")]
        public object Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("competitive_brands")]
        public object CompetitiveBrands { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("competitive_categories")]
        public object CompetitiveCategories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thirdparty_pixels")]
        public object ThirdpartyPixels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("macros")]
        public object Macros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifetime_budget")]
        public object LifetimeBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifetime_budget_imps")]
        public object LifetimeBudgetImps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_budget")]
        public object DailyBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_budget_imps")]
        public object DailyBudgetImps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_pacing")]
        public object EnablePacing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allow_safety_pacing")]
        public object AllowSafetyPacing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifetime_pacing")]
        public object LifetimePacing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifetime_pacing_span")]
        public object LifetimePacingSpan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lifetime_pacing_pct")]
        public object LifetimePacingPct { get; set; }
    }
}