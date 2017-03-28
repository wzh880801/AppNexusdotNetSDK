using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum TimeGranularity : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("hourly")]
        Hourly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("daily")]
        Daily,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("monthly")]
        Monthly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("yearly")]
        Yearly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("lifetime")]
        Lifetime,

        [EnumDescription("minutely")]
        Minutely,
    }
}