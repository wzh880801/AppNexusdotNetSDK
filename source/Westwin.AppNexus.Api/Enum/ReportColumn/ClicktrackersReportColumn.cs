using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ClicktrackersReportColumn : int
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
        [EnumDescription("tag_id")]
        TagId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_group_id")]
        CampaignGroupId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_id")]
        LineItemId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("auction_id")]
        AuctionId,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("datetime")]
        Datetime,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("user_id")]
        UserId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("tracker_id")]
        TrackerId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id")]
        MemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain")]
        SiteDomain,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_value")]
        RevenueValue,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("commission_cpm")]
        CommissionCpm,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("commission_revshare")]
        CommissionRevshare,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pricing_type")]
        PricingType,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("media_buy_cost")]
        MediaBuyCost,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("media_buy_rev_share_pct")]
        MediaBuyRevSharePct,

    }
}