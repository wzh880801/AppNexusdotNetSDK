using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// A member is any entity that has a financial relationship with the AppNexus platform, and each Console client is a single member. 
    /// Members are registered with the Member Service by AppNexus personnel, and all API activity must be associated with a member. 
    /// Note that the Member Service does not grant API or UI access. 
    /// Each member has multiple users who have their own UI and API credentials, and are managed by the User Service(https://wiki.appnexus.com/display/api/User+Service).
    /// </summary>
    public class Member
    {
        /// <summary>
        /// The ID of the member.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the member.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("whitelabel_support_email")]
        public string WhiteLabelSupportEmail { get; set; }

        /// <summary>
        /// This description is not currently used in the UI.
        /// </summary>
        [JsonProperty("reselling_description")]
        public string ResellingDescription { get; set; }

        /// <summary>
        /// The state of the member. Possible values: "active" or "inactive".
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }


        /// <summary>
        /// This value is used to determine whether RTB bids are allowed to compete with your managed campaigns. In order for an RTB bid to be able to compete with a managed bid for an impression, this field's value must be greater than the campaign priority of the managed bid.
        /// For example, let's say you have the following auction and settings:
        /// <para>Bid Type  |   Bid Price   |   Priority</para>
        /// <para>RTB       |   $5          |   8(no_reselling_priority)</para>
        /// <para>Managed   |   $3          |   8</para>
        /// <para>In this example, the RTB bid will not compete, even though its bid price is higher. In order for RTB to compete on this impression, no_reselling_priority would have to be 9 or higher.</para>
        /// </summary>
        [JsonProperty("no_reselling_priority")]
        public int NoResellingPriority { get; set; }


        /// <summary>
        /// Admin-only. A legacy field that may be used in the future. Possible values: "reseller" or "direct" (deprecated).
        /// </summary>
        [JsonProperty("entity_type")]
        public string EntityType { get; set; }


        /// <summary>
        /// string(100): You can change the URL you use to access the AppNexus UI. This is useful for white labeling.
        /// </summary>
        [JsonProperty("interface_domain")]
        public object InterfaceDomain { get; set; }


        /// <summary>
        /// string(100): You can change the URL you use to access the AppNexus Beta UI. This is useful for white labeling.
        /// </summary>
        [JsonProperty("interface_domain_beta")]
        public object InterfaceDomainBeta { get; set; }


        /// <summary>
        /// Whether or not to expose the member's inventory to the platform for reselling in the real-time marketplace. 
        /// <para>Possible values: "public" or "private".</para>
        /// </summary>
        [JsonProperty("reselling_exposure")]
        public string ResellingExposure { get; set; }


        /// <summary>
        /// The date and time at which reselling_exposure was changed to "public"
        /// </summary>
        [JsonProperty("reselling_exposed_on")]
        public string ResellingExposedOn { get; set; }


        /// <summary>
        /// timestamp: The timestamp of last modification to this member.
        /// </summary>
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }


        /// <summary>
        /// The timezone of the member. 
        /// See API Timezones for details and accepted values. 
        /// To change the default timezone of an individual advertiser, use the Advertiser Service . 
        /// If no timezone is specified in the Advertiser Service, advertisers inherit the member's timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }


        /// <summary>
        /// The default currency for this member. Can be overridden at more granular levels. For possible currency values, please use the Currency Service.
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }


        /// <summary>
        /// If true, use insertion orders (an organizational level above line items) for this member. Many members find insertion orders necessary. For details see Working with Insertion Orders. (Customer login required)
        /// </summary>
        [JsonProperty("use_insertion_orders")]
        public bool UseInsertionOrders { get; set; }


        /// <summary>
        /// Admin-only. If true, optimization levers are shown in the UI.
        /// </summary>
        [JsonProperty("expose_optimization_levers")]
        public bool ExposeOptimizationLevers { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_optimization_version")]
        public int DefaultOptimizationVersion { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_imps_verified")]
        public int? DailyImpsVerified { get; set; }

        /// <summary>
        /// Admin-only. If a selling member is IASH compliant, a logo will be placed next to the member's name in the Console UI Partner Center. (Customer login required)
        /// </summary>
        [JsonProperty("is_iash_compliant")]
        public bool IsIashCompliant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_imps_self_audited")]
        public int? DailyImpsSelfAudited { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_imps_unaudited")]
        public int? DailyImpsUnaudited { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allow_non_cpm_payment")]
        public bool AllowNonCpmPayment { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_allow_cpc")]
        public bool DefaultAllowCpc { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_allow_cpa")]
        public bool DefaultAllowCpa { get; set; }


        /// <summary>
        /// AppNexus reviews a significant portion of inventory and applies quality attributes, and also encourages members who sell on our platform to review their inventory in the same manner. If you would like campaigns to by default run only on AppNexus-reviewed inventory, then set this field to "appnexus". If you wish to default to your seller trust settings, which may include seller-reviewed and unreviewed inventory, set this field to "seller". You can override this with the campaign's profile. Please see Inventory Quality for more information on this concept. (Customer login required)
        /// <para>Possible values:</para>
        /// <para>seller</para>
        /// <para>appnexus</para>
        /// </summary>
        [JsonProperty("default_campaign_trust")]
        public string DefaultCampaignTrust { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_campaign_allow_unaudited")]
        public bool DefaultCampaignAllowUnaudited { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contract_allows_unaudited")]
        public bool ContractAllowsUnaudited { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_facebook")]
        public bool EnableFacebook { get; set; }


        /// <summary>
        /// The decimal mark used in reporting. This setting can be overridden at the user and report levels (see "reporting_decimal_type" in the User Service and Report Service). 
        /// Possible values:
        /// <para>"comma"</para>
        /// <para>"decimal" (period)</para>
        /// </summary>
        [JsonProperty("reporting_decimal_type")]
        public string ReportingDecimalType { get; set; }


        /// <summary>
        /// string(50): Email code is a unique value used when placements are processed via our email tag processing tool. Must be an alphanumeric value.
        /// </summary>
        [JsonProperty("email_code")]
        public object EmailCode { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enable_click_and_imp_trackers")]
        public bool EnableClickAndImpTrackers { get; set; }


        /// <summary>
        /// The ID of the default Ad Profile to use. This is required when allow_ad_profile_override is true.
        /// </summary>
        [JsonProperty("default_ad_profile_id")]
        public int DefaultAdProfileId { get; set; }


        /// <summary>
        /// Admin-only. The AppNexus credit limit taken into consideration when the member is buying inventory.
        /// </summary>
        [JsonProperty("buyer_credit_limit")]
        public double? BuyerCreditLimit { get; set; }


        /// <summary>
        /// This determines whether and how your member appears in the Buyers tab of the Ad Quality Manager in the UI and in the Platform Member service (Customer login required). Possible values:
        /// "public" = Your member name is shown.
        /// "private" = Your member ID is shown.
        /// "hidden" = Your member does not appear.
        /// Note that primary_type must be either "buyer" or "network" in order for it to appear in the Buyers tab of the Ad Quality Manager in the UI.
        /// </summary>
        [JsonProperty("platform_exposure")]
        public string PlatformExposure { get; set; }


        /// <summary>
        /// The email contact for this member.
        /// </summary>
        [JsonProperty("contact_email")]
        public object ContactEmail { get; set; }


        /// <summary>
        /// If true, the ad quality restrictions in default_ad_profile_id will take precedence over ad quality restrictions defined at the placement level. For example, if you restrict Advertiser X in the default ad quality profile at the network level, but do not restrict Advertiser X at the placement level, Advertiser X will still be restricted. 
        /// If you set this to false , settings at the placement level will take precedence.
        /// If you set this to true, you must set the default_ad_profile_id as well.
        /// </summary>
        [JsonProperty("allow_ad_profile_override")]
        public bool AllowAdProfileOverride { get; set; }


        /// <summary>
        /// URL-friendly name to be used as needed.
        /// </summary>
        [JsonProperty("short_name")]
        public string ShortName { get; set; }


        /// <summary>
        /// Deprecated as of March 2011.
        /// </summary>
        [System.Obsolete("Deprecated as of March 2011.")]
        [JsonProperty("expose_eap_ecp_placement_settings")]
        public bool ExposeEapEcpPlacementSettings { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_external_audit")]
        public bool DefaultExternalAudit { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("plugins_enabled")]
        public bool PluginsEnabled { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_placement_id")]
        public object DefaultPlacementId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_inv_source_id")]
        public object DefaultInvSourceId { get; set; }


        /// <summary>
        /// Admin-only. If this member is a seller and has a revenue sharing agreement with AppNexus, the AppNexus portion of the revenue sharing is indicated here.
        /// </summary>
        [JsonProperty("seller_revshare_pct")]
        public int? SellerRevsharePct { get; set; }


        /// <summary>
        /// A code that is used as a password for a member's AppNexus debug output.
        /// </summary>
        [JsonProperty("dongle")]
        public string Dongle { get; set; }


        /// <summary>
        /// Admin-only. The percent of the CPM paid for inventory charged as a fee in certain cases. See your contract for more information.
        /// </summary>
        [JsonProperty("buyer_clearing_fee_pct")]
        public double? BuyerClearingFeePct { get; set; }


        /// <summary>
        /// e.g. leonluo@westwin.com, meihongzhu@westwin.com, jingzou@westwin.com, wma@appnexus.com
        /// </summary>
        [JsonProperty("audit_notify_email")]
        public string AuditNotifyEmail { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("max_hosted_video_size")]
        public object MaxHostedVideoSize { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("visibility_profile_id")]
        public object VisibilityProfileId { get; set; }


        /// <summary>
        /// Admin-only. If true, pop ad support is shown in the UI.
        /// </summary>
        [JsonProperty("pops_enabled_UI")]
        public bool PopsEnabledUI { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allow_priority_audit")]
        public bool AllowPriorityAudit { get; set; }


        /// <summary>
        /// See default_accept_supply_partner_usersync.
        /// </summary>
        [JsonProperty("default_accept_data_provider_usersync")]
        public bool DefaultAcceptDataProviderUsersync { get; set; }


        /// <summary>
        /// See default_accept_supply_partner_usersync.
        /// </summary>
        [JsonProperty("default_accept_demand_partner_usersync")]
        public bool DefaultAcceptDemandPartnerUsersync { get; set; }


        /// <summary>
        /// We use pixels to sync user IDs between AppNexus and our major non-platform supply partners, such as Google, and third party data providers. This increases our ability to apply frequency and recency caps and segment data across the Internet. You can opt not to participate in user syncing; however this reduces our ability to apply the right information to your campaigns.
        /// </summary>
        [JsonProperty("default_accept_supply_partner_usersync")]
        public bool DefaultAcceptSupplyPartnerUsersync { get; set; }


        /// <summary>
        /// When AppNexus finds domains belonging to this member to be in violation of the Inventory Standards and Auditing policies (Customer login required), the domains are blacklisted and an email is sent to this email address. 
        /// The email identifies the domain URL, average daily impressions, and blacklist reason(s) for each domain that averaged at least 10,000 daily impressions over the last 7 days. Blacklisted domains that averaged less than 10,000 daily impressions over the last 7 days are not included in the email.
        /// If no email address is provided here, the email address in the audit_notify_email is used instead.
        /// </summary>
        [JsonProperty("domain_blacklist_email")]
        public string DomainBlacklistEmail { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("require_facebook_preaudit")]
        public bool RequireFacebookPreaudit { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ym_profile_id")]
        public object YmProfileId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_discrepancy_pct")]
        public object DefaultDiscrepancyPct { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pitbull_segment_id")]
        public int PitbullSegmentId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pitbull_segment_value")]
        public int PitbullSegmentValue { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description")]
        public object Description { get; set; }


        /// <summary>
        /// Each time Sherlock scans a creative belonging to this member, a response is sent to this email address. 
        /// The response includes the creative's audit status and any reasons why the creative has not passed audit. 
        /// This email address will also receive object limit notifications , sent when you reach 85, 95, and 100 percent of your limit for an object. 
        /// This field supports multiple comma-separated email addresses.
        /// </summary>
        [JsonProperty("sherlock_notify_email")]
        public string SherlockNotifyEmail { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_content_retrieval_timeout_ms")]
        public int DefaultContentRetrievalTimeoutMs { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_enable_for_mediation")]
        public bool DefaultEnableForMediation { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prioritize_margin")]
        public bool PrioritizeMargin { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deal_visibility_profile_id")]
        public object DealVisibilityProfileId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("xd_coop")]
        public bool XdCoop { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("age_segment_id")]
        public object AgeSegmentId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gender_segment_id")]
        public object GenderSegmentId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("requires_publisher_audit")]
        public bool RequiresPublisherAudit { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("developer_id")]
        public object DeveloperId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_budget")]
        public int DailyBudget { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("account_owner_user")]
        public AccountOwnerUser AccountOwnerUser { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_country")]
        public object DefaultCountry { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("content_categories")]
        public object ContentCategories { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inventory_trust")]
        public InventoryTrust InventoryTrust { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("seller_member_groups")]
        public object SellerMemberGroups { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("default_creatives")]
        public object DefaultCreatives { get; set; }


        /// <summary>
        /// The list of sizes which are included in the standard sizes dropdown in the UI when creating creatives. The array is of the following format:
        /// </summary>
        [JsonProperty("standard_sizes")]
        public StandardSize[] StandardSizes { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deal_types")]
        public object DealTypes { get; set; }


        /// <summary>
        /// Admin-only. The domain through which advertisements are served. The format of the object is {"cname":"ad.domain.com","type":null}
        /// </summary>
        [JsonProperty("serving_domain")]
        public ServingDomain ServingDomain { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contracts")]
        public object Contracts { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contact_info")]
        public object ContactInfo { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("features")]
        public object Features { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member_brand_exceptions")]
        public object MemberBrandExceptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thirdparty_pixels")]
        public object ThirdpartyPixels { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("floor_optimization")]
        public object FloorOptimization { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("native_custom_keys")]
        public object NativeCustomKeys { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mediation")]
        public Mediation Mediation { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_of_record")]
        public object ServerOfRecord { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("macros")]
        public object Macros { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("active_contract")]
        public object ActiveContract { get; set; }

        /// <summary>
        /// Currently used for an alpha feature.
        /// </summary>
        [JsonProperty("default_buyer_group_id")]
        public int DefaultBuyerGroupId { get; set; }

        /// <summary>
        /// Read-only. The size above which a creative is considered over-sized. The member is charged a creative overage fee for serving an over-sized creative.
        /// </summary>
        [JsonProperty("creative_size_minimum_bytes")]
        public int CreativeSizeMinimumBytes { get; set; }

        /// <summary>
        /// Read-only. The fee that is charged per GB for a creative that exceeds the creative_size_minimum_bytes.
        /// </summary>
        [JsonProperty("creative_size_fee_per_gb")]
        public float CreativeSizeFeePerGb { get; set; }


    }
}