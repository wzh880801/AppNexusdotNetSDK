using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum PartnerCenterSellSideReportColumn : int
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
        [EnumDescription("seller_member_id")]
        SellerMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_name")]
        SellerMemberName,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps")]
        Imps,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("clicks")]
        Clicks,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue_dollars")]
        ResellerRevenueDollars,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_convs")]
        TotalConvs,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("ctr")]
        Ctr,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_view_convs")]
        PostViewConvs,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_click_convs")]
        PostClickConvs,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_media_cost_dollars")]
        SellerMediaCostDollars,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_ppm")]
        SellerPpm,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_rpm")]
        SellerRpm,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_profit")]
        SellerProfit,

    }
}