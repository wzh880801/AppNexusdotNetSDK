using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum PlatformBuyerReportColumn : int
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
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("year")]
        Year,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("tag_id")]
        TagId,

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
        [EnumDescription("publisher")]
        Publisher,

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
        [EnumDescription("content_category_id")]
        ContentCategoryId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("content_category_name")]
        ContentCategoryName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("content_category")]
        ContentCategory,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("clicks")]
        Clicks,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type")]
        ImpType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type_id_DEPRECATED")]
        ImpTypeIdDEPRECATED,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_id")]
        CreativeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_name")]
        CreativeName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative")]
        Creative,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend")]
        BuyerSpend,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_bought")]
        ImpsBought,

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
        [EnumDescription("site")]
        Site,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("click_rate_sold")]
        ClickRateSold,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("tag_name")]
        TagName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("tag")]
        Tag,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_ecpm")]
        BuyerEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_buyer_curr")]
        BuyerSpendBuyerCurr,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_currency")]
        BuyerCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("supply_type")]
        SupplyType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_code")]
        PublisherCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_code")]
        SiteCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member_name")]
        BuyerMemberName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member")]
        BuyerMember,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source_id")]
        InventorySourceId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source")]
        InventorySource,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_source_name")]
        InventorySourceName,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_measured_imps")]
        ViewMeasuredImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_rate")]
        ViewRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_viewed")]
        ImpsViewed,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_measurement_rate")]
        ViewMeasurementRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("quality_imps")]
        QualityImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("quality_cpm")]
        QualityCpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_group")]
        SellerMemberGroup,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_payment")]
        SellerPayment,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("seller_payment_pct")]
        SellerPaymentPct,

    }
}