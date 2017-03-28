using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ContentCategoryVolumeReportColumn : int
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
        [EnumDescription("seller_member_id")]
        SellerMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("size")]
        Size,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country")]
        GeoCountry,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country_name")]
        GeoCountryName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("top_level_category_id")]
        TopLevelCategoryId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("top_level_category_name")]
        TopLevelCategoryName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("top_level_category")]
        TopLevelCategory,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("second_level_category_id")]
        SecondLevelCategoryId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("second_level_category_name")]
        SecondLevelCategoryName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("second_level_category")]
        SecondLevelCategory,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("domain_id")]
        DomainId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("domain_name")]
        DomainName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("domain")]
        Domain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_name")]
        SellerMemberName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member")]
        SellerMember,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("platform_audited_imps")]
        PlatformAuditedImps,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("seller_audited_imps")]
        SellerAuditedImps,

    }
}