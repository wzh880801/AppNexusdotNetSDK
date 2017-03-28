using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SellerFillAndDeliveryNetworkReportColumn : int
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
        [EnumDescription("placement_id")]
        PlacementId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_name")]
        PlacementName,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_id")]
        SiteId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement")]
        Placement,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("mobile_application_id")]
        MobileApplicationId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mobile_application")]
        MobileApplication,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain")]
        SiteDomain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("supply_type")]
        SupplyType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("call_type")]
        CallType,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("filtered_requests")]
        FilteredRequests,

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
        [EnumDescription("defaults")]
        Defaults,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("video_player_errors")]
        VideoPlayerErrors,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("video_default_errors")]
        VideoDefaultErrors,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("bid_sent_no_responses")]
        BidSentNoResponses,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("default_no_responses")]
        DefaultNoResponses,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("psas_or_blanks")]
        PsasOrBlanks,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_ad_requests")]
        TotalAdRequests,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_ad_responses")]
        TotalAdResponses,

    }
}