using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum MrcAnalyticsNetworkPublisherReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member_id")]
        BuyerMemberId,

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
        [EnumDescription("campaign_name")]
        CampaignName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign")]
        Campaign,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_id")]
        LineItemId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement")]
        Placement,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_name")]
        PlacementName,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_viewed")]
        ImpsViewed,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_id")]
        CampaignId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_downloaded_imps")]
        ViewDownloadedImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_technical_measurement_rate")]
        ViewTechnicalMeasurementRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_non_viewable_imps")]
        ViewNonViewableImps,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_undetermined_imps")]
        ViewUndeterminedImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_viewable_distribution")]
        ViewViewableDistribution,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_non_viewable_distribution")]
        ViewNonViewableDistribution,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_undetermined_distribution")]
        ViewUndeterminedDistribution,

    }
}