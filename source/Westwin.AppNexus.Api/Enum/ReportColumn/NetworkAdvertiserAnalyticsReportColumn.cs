using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkAdvertiserAnalyticsReportColumn : int
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
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_revenue")]
        TotalRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpm")]
        CostEcpm,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("bid_type")]
        BidType,

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
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("post_view_convs_rate")]
        PostViewConvsRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("post_click_convs_rate")]
        PostClickConvsRate,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpm")]
        RevenueEcpm,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("click_convs_rate")]
        ClickConvsRate,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("click_conv_rate")]
        ClickConvRate,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit")]
        Profit,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_ecpm")]
        ProfitEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpc")]
        RevenueEcpc,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpa")]
        RevenueEcpa,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpc")]
        CostEcpc,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpa")]
        CostEcpa,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("profit_margin")]
        ProfitMargin,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_revenue_adv_curr")]
        TotalRevenueAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpm_adv_curr")]
        RevenueEcpmAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpc_adv_curr")]
        RevenueEcpcAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpa_adv_curr")]
        RevenueEcpaAdvCurr,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("predict_type_rev")]
        PredictTypeRev,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("post_view_convs_pixel")]
        PostViewConvsPixel,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("post_click_convs_pixel")]
        PostClickConvsPixel,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("total_revenue_pixel")]
        TotalRevenuePixel,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("pixel_id")]
        PixelId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_id")]
        SiteId,

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
        [EnumDescription("profit_including_fees")]
        ProfitIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_revenue_including_fees")]
        TotalRevenueIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_revenue_including_fees_adv_currency")]
        TotalRevenueIncludingFeesAdvCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("total_revenue_including_fees_pixel")]
        TotalRevenueIncludingFeesPixel,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpa_including_fees")]
        RevenueEcpaIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpa_including_fees_adv_currency")]
        RevenueEcpaIncludingFeesAdvCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpc_including_fees")]
        RevenueEcpcIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpc_including_fees_adv_currency")]
        RevenueEcpcIncludingFeesAdvCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpm_including_fees")]
        RevenueEcpmIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpm_including_fees_adv_currency")]
        RevenueEcpmIncludingFeesAdvCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpa_including_fees")]
        CostEcpaIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpc_including_fees")]
        CostEcpcIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_net_including_fees")]
        ProfitNetIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_ecpm_including_fees")]
        ProfitEcpmIncludingFees,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("profit_margin_including_fees")]
        ProfitMarginIncludingFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpm_including_fees")]
        CostEcpmIncludingFees,

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
        [EnumDescription("venue")]
        Venue,

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
        [EnumDescription("user_group_for_campaign")]
        UserGroupForCampaign,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_recency_bucket_id")]
        CreativeRecencyBucketId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_recency_bucket")]
        CreativeRecencyBucket,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_frequency_bucket_id")]
        CreativeFrequencyBucketId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_frequency_bucket")]
        CreativeFrequencyBucket,

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
        [EnumDescription("member_id")]
        MemberId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("venue_id")]
        VenueId,

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
        [EnumDescription("age_bucket_id")]
        AgeBucketId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source_id")]
        InventorySourceId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("age_bucket")]
        AgeBucket,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("gender")]
        Gender,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("is_remarketing")]
        IsRemarketing,

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
        [EnumDescription("cost_ecpvm")]
        CostEcpvm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buying_currency")]
        BuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("commissions_buying_currency")]
        CommissionsBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("media_cost_buying_currency")]
        MediaCostBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_ecpm_buying_currency")]
        CostEcpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("serving_fees_buying_currency")]
        ServingFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_ecpa_buying_currency")]
        CostEcpaBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_ecpc_buying_currency")]
        CostEcpcBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_ecpm_buying_currency")]
        ProfitEcpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_buying_currency")]
        ProfitBuyingCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediatype_id")]
        MediatypeId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("quality_imps")]
        QualityImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("quality_cpm")]
        QualityCpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_group")]
        SellerMemberGroup,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_payment")]
        SellerPayment,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("seller_payment_pct")]
        SellerPaymentPct,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpm_including_fees_buying_currency")]
        CostEcpmIncludingFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpc_including_fees_buying_currency")]
        CostEcpcIncludingFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpa_including_fees_buying_currency")]
        CostEcpaIncludingFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_including_fees_buying_currency")]
        ProfitIncludingFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_ecpm_including_fees_buying_currency")]
        ProfitEcpmIncludingFeesBuyingCurrency,

    }
}