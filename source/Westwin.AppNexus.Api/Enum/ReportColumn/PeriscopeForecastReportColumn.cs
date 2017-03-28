using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum PeriscopeForecastReportColumn : int
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
        [EnumDescription("buyer_member")]
        BuyerMember,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("forecast_id")]
        ForecastId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("bid_bucket_percent")]
        BidBucketPercent,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("bid_bucket_price")]
        BidBucketPrice,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cumulative_cost")]
        CumulativeCost,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("hours_recorded")]
        HoursRecorded,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("hours_recorded_start_time")]
        HoursRecordedStartTime,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("cumulative_imps_available")]
        CumulativeImpsAvailable,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("forecast_name")]
        ForecastName,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm_bid")]
        CpmBid,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("win_rate")]
        WinRate,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("daily_winnable_imps")]
        DailyWinnableImps,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("forecast")]
        Forecast,

    }
}