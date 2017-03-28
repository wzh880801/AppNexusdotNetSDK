using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum CreativeStatus : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("active")]
        Active,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("inactive")]
        Inactive,
    }
}