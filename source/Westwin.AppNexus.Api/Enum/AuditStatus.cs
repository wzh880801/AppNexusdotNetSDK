using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// The audit status of the creative
    /// </summary>
    public enum AuditStatus : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("no_audit")]
        NoAudit,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("pending")]
        Pending,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rejected")]
        Rejected,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("audited")]
        Audited,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("unauditable")]
        Unauditable,
    }
}