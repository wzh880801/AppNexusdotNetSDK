using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum BuyerPlatformBillingReportColumn : int
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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_appnexus_cleared")]
        ImpsAppnexusCleared,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_direct_cleared")]
        ImpsDirectCleared,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend")]
        BuyerSpend,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_appnexus_cleared")]
        BuyerSpendAppnexusCleared,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_direct_cleared")]
        BuyerSpendDirectCleared,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_ecpm")]
        BuyerEcpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_currency")]
        SellerCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_buyer_curr")]
        BuyerSpendBuyerCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_appnexus_cleared_buyer_curr")]
        BuyerSpendAppnexusClearedBuyerCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_direct_cleared_buyer_curr")]
        BuyerSpendDirectClearedBuyerCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_spend_direct_cleared_seller_curr")]
        BuyerSpendDirectClearedSellerCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("buyer_ecpm_buyer_curr")]
        BuyerEcpmBuyerCurr,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_currency")]
        BuyerCurrency,

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

    }
}