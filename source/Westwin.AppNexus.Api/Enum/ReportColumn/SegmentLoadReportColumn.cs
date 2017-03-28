using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SegmentLoadReportColumn : int
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
        [EnumDescription("member_id")]
        MemberId,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_loads")]
        TotalLoads,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("daily_uniques")]
        DailyUniques,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("monthly_uniques")]
        MonthlyUniques,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("avg_daily_uniques")]
        AvgDailyUniques,

    }
}