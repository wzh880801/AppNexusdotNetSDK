using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum PlatformSellerSiteDomainPerformanceReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("bidder_id")]
        BidderId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("bidder_name")]
        BidderName,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_revenue")]
        SellerRevenue,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_bought")]
        ImpsBought,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain")]
        SiteDomain,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_name")]
        PublisherName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_name")]
        DealName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_id")]
        DealId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("mobile_application_id")]
        MobileApplicationId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mobile_application_name")]
        MobileApplicationName,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_measured_imps")]
        ViewMeasuredImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_measurable_rate")]
        ViewMeasurableRate,

    }
}