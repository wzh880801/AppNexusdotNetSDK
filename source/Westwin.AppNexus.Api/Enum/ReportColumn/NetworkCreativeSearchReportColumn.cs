using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkCreativeSearchReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_id")]
        CreativeId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_id")]
        SiteId,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("tag_id")]
        TagId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_subtype_id")]
        MediaSubtypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("audit_status")]
        AuditStatus,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("format")]
        Format,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("brand_id")]
        BrandId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps")]
        Imps,

    }
}