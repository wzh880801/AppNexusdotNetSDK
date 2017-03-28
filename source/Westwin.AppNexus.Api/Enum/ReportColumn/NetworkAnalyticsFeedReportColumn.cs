using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkAnalyticsFeedReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("placement_id")]
        PlacementId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_id")]
        LineItemId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_id")]
        PubRuleId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_convs")]
        TotalConvs,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type_id_DEPRECATED")]
        ImpTypeIdDEPRECATED,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_advertiser_rpm")]
        NetworkAdvertiserRpm,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_advertiser_rpm_adv_curr")]
        NetworkAdvertiserRpmAdvCurr,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_id")]
        CampaignId,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

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
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("network_resold_rpm")]
        NetworkResoldRpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("total_publisher_rpm")]
        TotalPublisherRpm,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("external_inv_id")]
        ExternalInvId,

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
        [EnumDescription("publisher_rpm_publisher_currency")]
        PublisherRpmPublisherCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_pub_curr")]
        MediaCostPubCurr,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type")]
        RevenueType,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("rpm_adv_curr")]
        RpmAdvCurr,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("width")]
        Width,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("height")]
        Height,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("revenue_adv_curr")]
        RevenueAdvCurr,

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
        [EnumDescription("placement_code")]
        PlacementCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_code")]
        PubRuleCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_recency_bucket")]
        CreativeRecencyBucket,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_frequency_bucket")]
        CreativeFrequencyBucket,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("entity_member_id")]
        EntityMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("media_type")]
        MediaType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_subtype_id")]
        MediaSubtypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("media_subtype")]
        MediaSubtype,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_type_id")]
        MediaTypeId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("deal_id")]
        DealId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("age_bucket_id")]
        AgeBucketId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("content_category_id")]
        ContentCategoryId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source_id")]
        InventorySourceId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("gender")]
        Gender,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("is_remarketing")]
        IsRemarketing,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_id")]
        CreativeId,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_type")]
        DealType,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imp_requests")]
        ImpRequests,

    }
}