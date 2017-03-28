using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum StandardLogLevelEventsReportColumn : int
    {
        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("month")]
        Month,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("day")]
        Day,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("hour")]
        Hour,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("auction_id")]
        AuctionId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("date_time_ll")]
        DateTimeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("user_tz_offset_ll")]
        UserTzOffsetLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("width_ll")]
        WidthLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("height_ll")]
        HeightLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_type_ll")]
        MediaTypeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("fold_position_ll")]
        FoldPositionLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("event_type_ll")]
        EventTypeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imp_type_ll")]
        ImpTypeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("payment_type_ll")]
        PaymentTypeLl,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("media_cost_dollars_cpm_ll")]
        MediaCostDollarsCpmLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type_ll")]
        RevenueTypeLl,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_spend_ll")]
        BuyerSpendLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("buyer_bid_ll")]
        BuyerBidLl,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("ecp_ll")]
        EcpLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("eap_ll")]
        EapLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_imp_ll")]
        IsImpLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_learn_ll")]
        IsLearnLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("predict_type_rev_ll")]
        PredictTypeRevLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("user_id_64_ll")]
        UserIdC64Ll,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("geo_country_ll")]
        GeoCountryLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("ip_address_ll")]
        IpAddressLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("geo_region_ll")]
        GeoRegionLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("operating_system_ll")]
        OperatingSystemLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("browser_ll")]
        BrowserLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("language_ll")]
        LanguageLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("venue_id_ll")]
        VenueIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("seller_member_id_ll")]
        SellerMemberIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("publisher_id_ll")]
        PublisherIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("site_id_ll")]
        SiteIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("site_domain_ll")]
        SiteDomainLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("tag_id_ll")]
        TagIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("external_inv_id_ll")]
        ExternalInvIdLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("reserve_price_ll")]
        ReservePriceLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("seller_revenue_cpm_ll")]
        SellerRevenueCpmLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("media_buy_rev_share_pct_ll")]
        MediaBuyRevSharePctLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("pub_rule_id_ll")]
        PubRuleIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("seller_currency_ll")]
        SellerCurrencyLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("publisher_currency_ll")]
        PublisherCurrencyLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("publisher_exchange_rate_ll")]
        PublisherExchangeRateLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("serving_fees_cpm_ll")]
        ServingFeesCpmLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("serving_fees_revshare_ll")]
        ServingFeesRevshareLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_id_ll")]
        AdvertiserIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("brand_id_ll")]
        BrandIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_frequency_ll")]
        AdvertiserFrequencyLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_recency_ll")]
        AdvertiserRecencyLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("insertion_order_id_ll")]
        InsertionOrderIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("line_item_id_ll")]
        LineItemIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("campaign_id_ll")]
        CampaignIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("creative_id_ll")]
        CreativeIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("creative_freq_ll")]
        CreativeFreqLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("creative_rec_ll")]
        CreativeRecLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("cadence_modifier_ll")]
        CadenceModifierLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("can_convert_ll")]
        CanConvertLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("user_group_id_ll")]
        UserGroupIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("is_control_ll")]
        IsControlLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("control_pct_ll")]
        ControlPctLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("control_creative_id_ll")]
        ControlCreativeIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("is_click_ll")]
        IsClickLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("pixel_id_ll")]
        PixelIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("is_remarketing_ll")]
        IsRemarketingLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_click_conv_ll")]
        PostClickConvLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_view_conv_ll")]
        PostViewConvLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("post_click_revenue_ll")]
        PostClickRevenueLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("post_view_revenue_ll")]
        PostViewRevenueLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("external_data_ll")]
        ExternalDataLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("pricing_type_ll")]
        PricingTypeLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_dollars_ll")]
        BookedRevenueDollarsLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_adv_curr_ll")]
        BookedRevenueAdvCurrLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("commission_cpm_ll")]
        CommissionCpmLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("commission_revshare_ll")]
        CommissionRevshareLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("auction_service_deduction_ll")]
        AuctionServiceDeductionLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("auction_service_fees_ll")]
        AuctionServiceFeesLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("creative_overage_fees_ll")]
        CreativeOverageFeesLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("clear_fees_ll")]
        ClearFeesLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("buyer_currency_ll")]
        BuyerCurrencyLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_currency_ll")]
        AdvertiserCurrencyLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_exchange_rate_ll")]
        AdvertiserExchangeRateLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("latitude_ll")]
        LatitudeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("longitude_ll")]
        LongitudeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("device_unique_id_ll")]
        DeviceUniqueIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("device_id_ll")]
        DeviceIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("carrier_id_ll")]
        CarrierIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("deal_id_ll")]
        DealIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_result_ll")]
        ViewResultLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("application_id_ll")]
        ApplicationIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("supply_type_ll")]
        SupplyTypeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("sdk_version_ll")]
        SdkVersionLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("ozone_id_ll")]
        OzoneIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("billing_period_id_ll")]
        BillingPeriodIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_non_measurable_reason_ll")]
        ViewNonMeasurableReasonLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("external_uid_ll")]
        ExternalUidLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("request_uuid_ll")]
        RequestUuidLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("dma_ll")]
        DmaLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("city_ll")]
        CityLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("mobile_app_instance_id_ll")]
        MobileAppInstanceIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("traffic_source_code_ll")]
        TrafficSourceCodeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("external_request_id_ll")]
        ExternalRequestIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("deal_type_ll")]
        DealTypeLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("ym_floor_id_ll")]
        YmFloorIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("ym_bias_id_ll")]
        YmBiasIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("is_filtered_request_ll")]
        IsFilteredRequestLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("age_ll")]
        AgeLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("gender_ll")]
        GenderLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("is_exclusive_ll")]
        IsExclusiveLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("bid_priority_ll")]
        BidPriorityLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("custom_model_id_ll")]
        CustomModelIdLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("custom_model_last_modified_ll")]
        CustomModelLastModifiedLl,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("custom_model_output_code_ll")]
        CustomModelOutputCodeLl,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("third_party_costs_cpm_ll")]
        ThirdPartyCostsCpmLl,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id")]
        MemberId,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_ll")]
        AdvertiserLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("campaign_ll")]
        CampaignLl,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("carrier_ll")]
        CarrierLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("geo_city_ll")]
        GeoCityLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("deal_ll")]
        DealLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("insertion_order_ll")]
        InsertionOrderLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("line_item_ll")]
        LineItemLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("optimization_zone_ll")]
        OptimizationZoneLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("pixel_ll")]
        PixelLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("pub_rule_ll")]
        PubRuleLl,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_ll")]
        PublisherLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("seller_member_ll")]
        SellerMemberLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("site_ll")]
        SiteLl,

        /// <summary>
        /// Type is string. This column is in havings
        /// </summary>
        [EnumDescription("placement_ll")]
        PlacementLl,

    }
}