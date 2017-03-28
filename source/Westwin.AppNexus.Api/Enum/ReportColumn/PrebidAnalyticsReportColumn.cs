using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum PrebidAnalyticsReportColumn : int
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
        [EnumDescription("bidder_code")]
        BidderCode,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("estimated_seller_revenue")]
        EstimatedSellerRevenue,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("avg_bid_price")]
        AvgBidPrice,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("header_auction_impressions")]
        HeaderAuctionImpressions,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm")]
        Cpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("win_rate_pct")]
        WinRatePct,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("participation_rate_pct")]
        ParticipationRatePct,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("avg_latency")]
        AvgLatency,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("timeout_pct")]
        TimeoutPct,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_impressions")]
        TotalImpressions,

    }
}