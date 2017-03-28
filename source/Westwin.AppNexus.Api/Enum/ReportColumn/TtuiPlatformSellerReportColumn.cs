using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum TtuiPlatformSellerReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("gender")]
        Gender,

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
        /// Type is boolean. This column is not in havings
        /// </summary>
        [EnumDescription("is_dw")]
        IsDw,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_delivered")]
        ImpsDelivered,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_not_delivered")]
        ImpsNotDelivered,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_revenue")]
        SellerRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend")]
        BuyerSpend,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("creative_overage_fees")]
        CreativeOverageFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_fees")]
        AuctionServiceFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("clear_fees")]
        ClearFees,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("discrepancy_allowance")]
        DiscrepancyAllowance,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("forex_allowance")]
        ForexAllowance,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_deduction")]
        AuctionServiceDeduction,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("price_bucket_id")]
        PriceBucketId,

        /// <summary>
        /// Type is boolean. This column is not in havings
        /// </summary>
        [EnumDescription("is_delivered")]
        IsDelivered,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("cleared_direct")]
        ClearedDirect,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_ecpm")]
        SellerEcpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_currency")]
        SellerCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_revenue_seller_curr")]
        SellerRevenueSellerCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("seller_ecpm_seller_curr")]
        SellerEcpmSellerCurr,

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

    }
}