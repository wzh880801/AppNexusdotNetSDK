using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SellerMonetizationReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member_name")]
        BuyerMemberName,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_id")]
        AdvertiserId,

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
        [EnumDescription("advertiser_name")]
        AdvertiserName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_media_cost_dollars")]
        SellerMediaCostDollars,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("channel_type")]
        ChannelType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("channel_type_name")]
        ChannelTypeName,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_filled")]
        ImpsFilled,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("fill_rate")]
        FillRate,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_revenue_ecpm")]
        SellerRevenueEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_revenue_dollars")]
        SellerRevenueDollars,

    }
}