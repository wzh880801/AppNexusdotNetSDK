using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkAnalyticsReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member_id")]
        BuyerMemberId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_id")]
        SellerMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_name")]
        SellerMemberName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member")]
        SellerMember,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_name")]
        AdvertiserName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser")]
        Advertiser,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_id")]
        LineItemId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_name")]
        LineItemName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item")]
        LineItem,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_id")]
        PubRuleId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_name")]
        PubRuleName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule")]
        PubRule,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_id")]
        CampaignId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_name")]
        CampaignName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign")]
        Campaign,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("size")]
        Size,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country")]
        GeoCountry,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country_name")]
        GeoCountryName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_class")]
        InventoryClass,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps")]
        Imps,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("clicks")]
        Clicks,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost")]
        Cost,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue")]
        Revenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue")]
        BookedRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue")]
        ResellerRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit")]
        Profit,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cpm")]
        Cpm,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_convs")]
        TotalConvs,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("convs_rate")]
        ConvsRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("ctr")]
        Ctr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("rpm")]
        Rpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_network_rpm")]
        TotalNetworkRpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("ppm")]
        Ppm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("bid_type")]
        BidType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_type")]
        BuyerType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_type")]
        SellerType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type")]
        ImpType,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_blank")]
        ImpsBlank,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_psa")]
        ImpsPsa,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_default_error")]
        ImpsDefaultError,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_default_bidder")]
        ImpsDefaultBidder,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_kept")]
        ImpsKept,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_resold")]
        ImpsResold,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_rtb")]
        ImpsRtb,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type_id")]
        ImpTypeId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_view_convs")]
        PostViewConvs,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("post_view_revenue")]
        PostViewRevenue,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_click_convs")]
        PostClickConvs,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("post_click_revenue")]
        PostClickRevenue,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_adv_curr")]
        BookedRevenueAdvCurr,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesperson_for_advertiser")]
        SalespersonForAdvertiser,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesperson_for_publisher")]
        SalespersonForPublisher,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("account_manager_for_advertiser")]
        AccountManagerForAdvertiser,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("account_manager_for_publisher")]
        AccountManagerForPublisher,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("pixel_id")]
        PixelId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_psa_error")]
        ImpsPsaError,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_id")]
        SiteId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_name")]
        InsertionOrderName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order")]
        InsertionOrder,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("commissions")]
        Commissions,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("serving_fees")]
        ServingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_including_fees")]
        RevenueIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_including_fees")]
        CostIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_including_fees")]
        ProfitIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cpm_including_fees")]
        CpmIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("rpm_including_fees")]
        RpmIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("ppm_including_fees")]
        PpmIncludingFees,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("sold_network_rpm")]
        SoldNetworkRpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("sold_publisher_rpm")]
        SoldPublisherRpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_publisher_rpm")]
        TotalPublisherRpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("payment_type")]
        PaymentType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("adjustment_id")]
        AdjustmentId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_currency")]
        PublisherCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_pub_curr")]
        MediaCostPubCurr,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("convs_per_mm")]
        ConvsPerMm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("trafficker_for_line_item")]
        TraffickerForLineItem,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesrep_for_line_item")]
        SalesrepForLineItem,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("supply_type")]
        SupplyType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type_id")]
        RevenueTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type")]
        RevenueType,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("click_thru_pct")]
        ClickThruPct,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("external_impression")]
        ExternalImpression,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("external_click")]
        ExternalClick,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_name")]
        SiteName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site")]
        Site,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_priority")]
        CampaignPriority,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_code")]
        InsertionOrderCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_code")]
        LineItemCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_code")]
        CampaignCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_code")]
        AdvertiserCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_code")]
        PublisherCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_code")]
        SiteCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_code")]
        PubRuleCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("user_group_for_campaign")]
        UserGroupForCampaign,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_name")]
        PublisherName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher")]
        Publisher,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("placement_id")]
        PlacementId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_code")]
        PlacementCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_name")]
        PlacementName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement")]
        Placement,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("entity_member_id")]
        EntityMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member_name")]
        BuyerMemberName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member")]
        BuyerMember,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_id")]
        CreativeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_name")]
        CreativeName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative")]
        Creative,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediatype")]
        Mediatype,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("media_type")]
        MediaType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_type_id")]
        MediaTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_type")]
        CampaignType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_type")]
        AdvertiserType,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_insertion")]
        ImpsInsertion,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("deal_id")]
        DealId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_name")]
        DealName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal")]
        Deal,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_code")]
        DealCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_code")]
        CreativeCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("trafficker_for_insertion_order")]
        TraffickerForInsertionOrder,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesrep_for_insertion_order")]
        SalesrepForInsertionOrder,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_type")]
        LineItemType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_type")]
        InsertionOrderType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("adjustment_hour")]
        AdjustmentHour,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("adjustment_day")]
        AdjustmentDay,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_viewed")]
        ImpsViewed,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_measured_imps")]
        ViewMeasuredImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_rate")]
        ViewRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_measurement_rate")]
        ViewMeasurementRate,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("content_category_id")]
        ContentCategoryId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("fold_position_id")]
        FoldPositionId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source_id")]
        InventorySourceId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("content_category")]
        ContentCategory,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("content_category_name")]
        ContentCategoryName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("fold_position")]
        FoldPosition,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source")]
        InventorySource,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source_name")]
        InventorySourceName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("brand_id")]
        BrandId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("brand_name")]
        BrandName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("brand")]
        Brand,

        /// <summary>
        /// Type is datetime. This column is not in havings
        /// </summary>
        [EnumDescription("billing_period_start_date")]
        BillingPeriodStartDate,

        /// <summary>
        /// Type is datetime. This column is not in havings
        /// </summary>
        [EnumDescription("billing_period_end_date")]
        BillingPeriodEndDate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_filtered")]
        ImpsFiltered,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("viewdef_definition_id")]
        ViewdefDefinitionId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("viewdef_viewed_imps")]
        ViewdefViewedImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("viewdef_view_rate")]
        ViewdefViewRate,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("third_party_costs")]
        ThirdPartyCosts,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cpvm")]
        Cpvm,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("data_costs")]
        DataCosts,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("data_costs_buying_currency")]
        DataCostsBuyingCurrency,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_filtered_reason_id")]
        ImpsFilteredReasonId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("imps_filtered_reason")]
        ImpsFilteredReason,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_type")]
        DealType,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("booked_revenue_buying_currency")]
        BookedRevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("booked_revenue_selling_currency")]
        BookedRevenueSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_buying_currency")]
        RevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_selling_currency")]
        RevenueSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("reseller_revenue_buying_currency")]
        ResellerRevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("reseller_revenue_selling_currency")]
        ResellerRevenueSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("data_costs_buying_currency_duplicate_DEPRECATED")]
        DataCostsBuyingCurrencyDuplicateDEPRECATED,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("data_costs_selling_currency")]
        DataCostsSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("commissions_buying_currency")]
        CommissionsBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("commissions_selling_currency")]
        CommissionsSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_buying_currency")]
        ProfitBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_selling_currency")]
        ProfitSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_buying_currency")]
        CostBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_selling_currency")]
        CostSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm_selling_currency")]
        CpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm_buying_currency")]
        CpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("rpm_buying_currency")]
        RpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("rpm_selling_currency")]
        RpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ppm_buying_currency")]
        PpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ppm_selling_currency")]
        PpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("total_network_rpm_buying_currency")]
        TotalNetworkRpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("total_network_rpm_selling_currency")]
        TotalNetworkRpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("sold_network_rpm_buying_currency")]
        SoldNetworkRpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("sold_network_rpm_selling_currency")]
        SoldNetworkRpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("serving_fees_buying_currency")]
        ServingFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("serving_fees_selling_currency")]
        ServingFeesSellingCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buying_currency")]
        BuyingCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("selling_currency")]
        SellingCurrency,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imp_requests")]
        ImpRequests,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediatype_id")]
        MediatypeId,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_media_cost_ecpm")]
        BuyerMediaCostEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_media_cost_ecpc")]
        BuyerMediaCostEcpc,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_media_cost_ecpa")]
        BuyerMediaCostEcpa,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_ecpm")]
        BookedRevenueEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_ecpm_buying_currency")]
        BookedRevenueEcpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_ecpc")]
        BookedRevenueEcpc,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_ecpc_buying_currency")]
        BookedRevenueEcpcBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_ecpa")]
        BookedRevenueEcpa,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_ecpa_buying_currency")]
        BookedRevenueEcpaBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_advertiser_currency")]
        MediaCostAdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_advertiser_currency")]
        ProfitAdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpm_advertiser_currency")]
        CostEcpmAdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpc_advertiser_currency")]
        CostEcpcAdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpa_advertiser_currency")]
        CostEcpaAdvertiserCurrency,

    }
}