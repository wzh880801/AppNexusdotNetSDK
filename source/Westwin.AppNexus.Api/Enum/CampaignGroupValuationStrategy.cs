using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// This field or feature is part of functionality currently in either Alpha or Beta phase. It is therefore subject to change.
    /// <para>For line items with revenue_type “cpm”, “cpc” or “cpa”, determines which performance goal optimization strategy will be applied.</para>
    /// </summary>
    public enum CampaignGroupValuationStrategy : int
    {
        /// <summary>
        /// To use AppNexus’ standard optimization.
        /// </summary>
        [EnumDescription("prospecting")]
        Prospecting,

        /// <summary>
        /// To optimize to a user retargeting segment. If you select this setting, you must also associate a user retargeting segment with the line item. To create user segments, see the Segment service. To associate user retargeting segments with the line item, see the Profile service.
        /// </summary>
        [EnumDescription("retargeting")]
        ReTargeting,
    }
}