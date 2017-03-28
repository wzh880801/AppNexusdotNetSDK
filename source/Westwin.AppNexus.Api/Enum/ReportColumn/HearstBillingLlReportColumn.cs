using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum HearstBillingLlReportColumn : int
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
        [EnumDescription("buyer_member_id")]
        BuyerMemberId,

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
        [EnumDescription("hearst_basc_charged")]
        HearstBascCharged,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_type")]
        InventoryType,

    }
}