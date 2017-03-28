using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum DpSegmentUsageReportColumn : int
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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps")]
        Imps,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_id")]
        CampaignId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("segment_id")]
        SegmentId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("segment_name")]
        SegmentName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("segment")]
        Segment,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("segment_code")]
        SegmentCode,

    }
}