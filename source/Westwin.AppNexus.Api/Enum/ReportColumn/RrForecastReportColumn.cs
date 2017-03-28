using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum RrForecastReportColumn : int
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
        [EnumDescription("member_id")]
        MemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("member_name")]
        MemberName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

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
        [EnumDescription("line_item_id")]
        LineItemId,

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
        [EnumDescription("campaign_code")]
        CampaignCode,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member")]
        Member,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_name")]
        InsertionOrderName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_name")]
        LineItemName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order")]
        InsertionOrder,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item")]
        LineItem,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_available")]
        ImpsAvailable,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_bid")]
        ImpsBid,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_won")]
        ImpsWon,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("bid_rate")]
        BidRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("win_rate")]
        WinRate,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("minute")]
        Minute,

    }
}