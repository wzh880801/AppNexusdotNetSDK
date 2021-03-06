using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum VideoAnalyticsNetworkAdvertiserReportColumn : int
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
        [EnumDescription("revenue")]
        Revenue,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_view_convs")]
        PostViewConvs,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_click_convs")]
        PostClickConvs,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain")]
        SiteDomain,

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
        [EnumDescription("cost_per_video_complete")]
        CostPerVideoComplete,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("revenue_per_video_complete")]
        RevenuePerVideoComplete,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("viewdef_definition_id")]
        ViewdefDefinitionId,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_viewed")]
        ImpsViewed,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("ad_responses")]
        AdResponses,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("video_context")]
        VideoContext,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("video_playback_method")]
        VideoPlaybackMethod,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("video_player_size")]
        VideoPlayerSize,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("supply_type")]
        SupplyType,

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

    }
}