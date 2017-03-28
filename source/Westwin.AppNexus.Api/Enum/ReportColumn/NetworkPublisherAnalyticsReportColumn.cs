using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkPublisherAnalyticsReportColumn : int
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
        [EnumDescription("imps_total")]
        ImpsTotal,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("clicks")]
        Clicks,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_revenue")]
        NetworkRevenue,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_convs")]
        TotalConvs,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("ctr")]
        Ctr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_network_rpm")]
        TotalNetworkRpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_ppm")]
        NetworkPpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_type")]
        BuyerType,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("publisher_revenue")]
        PublisherRevenue,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("predict_rev_type")]
        PredictRevType,

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
        [EnumDescription("network_profit")]
        NetworkProfit,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_sold")]
        ImpsSold,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_default")]
        ImpsDefault,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_psa_error")]
        ImpsPsaError,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("convs_rate")]
        ConvsRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("network_roi")]
        NetworkRoi,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("network_roi_net_commissions")]
        NetworkRoiNetCommissions,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("network_rpm")]
        NetworkRpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("sold_network_rpm")]
        SoldNetworkRpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("publisher_rpm")]
        PublisherRpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("sold_publisher_rpm")]
        SoldPublisherRpm,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("external_inv_id")]
        ExternalInvId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("external_inv_name")]
        ExternalInvName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("external_inv")]
        ExternalInv,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_revenue_net_commissions")]
        NetworkRevenueNetCommissions,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_profit_net_commissions")]
        NetworkProfitNetCommissions,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_rpm_net_commissions")]
        NetworkRpmNetCommissions,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_ppm_net_commissions")]
        NetworkPpmNetCommissions,

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
        [EnumDescription("publisher_revenue_pub_curr")]
        PublisherRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("publisher_rpm_pub_curr")]
        PublisherRpmPubCurr,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_priority")]
        CampaignPriority,

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
        [EnumDescription("placement_code")]
        PlacementCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_code")]
        PubRuleCode,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id")]
        MemberId,

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
        [EnumDescription("age_bucket")]
        AgeBucket,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_id")]
        CreativeId,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_filtered")]
        ImpsFiltered,

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
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("network_revenue_selling_currency")]
        NetworkRevenueSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("network_profit_selling_currency")]
        NetworkProfitSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("total_network_rpm_selling_currency")]
        TotalNetworkRpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("network_ppm_selling_currency")]
        NetworkPpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("sold_network_rpm_selling_currency")]
        SoldNetworkRpmSellingCurrency,

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
        [EnumDescription("total_publisher_rpm_selling_currency")]
        TotalPublisherRpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("sold_publisher_rpm_selling_currency")]
        SoldPublisherRpmSellingCurrency,

    }
}