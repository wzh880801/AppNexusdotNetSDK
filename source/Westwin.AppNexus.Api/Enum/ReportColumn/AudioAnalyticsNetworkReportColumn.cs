using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum AudioAnalyticsNetworkReportColumn : int
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
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain")]
        SiteDomain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_currency")]
        PublisherCurrency,

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
        [EnumDescription("trafficker_for_insertion_order")]
        TraffickerForInsertionOrder,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesrep_for_insertion_order")]
        SalesrepForInsertionOrder,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("mobile_application_id")]
        MobileApplicationId,

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
        [EnumDescription("errors")]
        Errors,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("starts")]
        Starts,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("start_rate")]
        StartRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("skips")]
        Skips,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("skip_rate")]
        SkipRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("25_pcts")]
        C25Pcts,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("50_pcts")]
        C50Pcts,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("75_pcts")]
        C75Pcts,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("completions")]
        Completions,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("completion_rate")]
        CompletionRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("revenue_per_audio_complete")]
        RevenuePerAudioComplete,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("cost_per_audio_compete")]
        CostPerAudioCompete,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("served")]
        Served,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_recency_bucket_id")]
        CreativeRecencyBucketId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_recency_bucket")]
        CreativeRecencyBucket,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_frequency_bucket_id")]
        CreativeFrequencyBucketId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_frequency_bucket")]
        CreativeFrequencyBucket,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("audio_fill")]
        AudioFill,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("ad_responses")]
        AdResponses,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("supply_type_filterable")]
        SupplyTypeFilterable,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_subtype")]
        MediaSubtype,

    }
}