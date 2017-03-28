using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SellerBidErrorReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("placement_id")]
        PlacementId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_name")]
        PlacementName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement")]
        Placement,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_size")]
        CreativeSize,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_id")]
        CreativeId,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("bidder")]
        Bidder,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("brand_id")]
        BrandId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("brand_name")]
        BrandName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("brand")]
        Brand,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member")]
        BuyerMember,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_name")]
        PublisherName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher")]
        Publisher,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("deal_id")]
        DealId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal_name")]
        DealName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("deal")]
        Deal,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("ad_profile_id")]
        AdProfileId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_category_id")]
        CreativeCategoryId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("error_id")]
        ErrorId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("language_id")]
        LanguageId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("technical_attribute_id")]
        TechnicalAttributeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_category_name")]
        CreativeCategoryName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_category")]
        CreativeCategory,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("language")]
        Language,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("technical_attribute_name")]
        TechnicalAttributeName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("technical_attribute")]
        TechnicalAttribute,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("logged_error_message")]
        LoggedErrorMessage,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("error_count")]
        ErrorCount,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("language_name")]
        LanguageName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("error_message")]
        ErrorMessage,

    }
}