using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum StandardLogLevelEvents2ReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_id")]
        SellerMemberId,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type_id")]
        ImpTypeId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_id")]
        SiteId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_name")]
        SiteName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("payment_type")]
        PaymentType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type")]
        RevenueType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("width")]
        Width,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("height")]
        Height,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain")]
        SiteDomain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("media_type")]
        MediaType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("fold_position_id")]
        FoldPositionId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("fold_position")]
        FoldPosition,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("browser")]
        Browser,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_region_code")]
        GeoRegionCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country")]
        GeoCountry,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("payment_type_id")]
        PaymentTypeId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id_ll")]
        MemberIdLl,

    }
}