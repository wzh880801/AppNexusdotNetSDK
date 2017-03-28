using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportInterval : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("current_hour")]
        CurrentHour,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("last_hour")]
        LastHour,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("today")]
        Today,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("yesterday")]
        Yesterday,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("last_48_hours")]
        Last48Hours,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("last_2_days")]
        Last2Days,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("last_7_days")]
        Last7Days,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("last_14_days")]
        Last14Days,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("month_to_yesterday")]
        MonthToYesterday,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("month_to_date")]
        MonthToDate,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("quarter_to_date")]
        QuarterToDate,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("last_month")]
        LastMonth,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("lifetime")]
        Lifetime,

        [EnumDescription("custom")]
        Custom,
    }
}