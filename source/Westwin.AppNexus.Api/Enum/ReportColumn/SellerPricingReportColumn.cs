using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SellerPricingReportColumn : int
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
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_name")]
        AdvertiserName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id_filter")]
        MemberIdFilter,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("cleared_direct")]
        ClearedDirect,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_delivered")]
        IsDelivered,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_code")]
        PublisherCode,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_valid_seller")]
        IsValidSeller,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("selling_currency")]
        SellingCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buying_currency")]
        BuyingCurrency,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("convs")]
        Convs,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue")]
        ResellerRevenue,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("seller_media_cost")]
        SellerMediaCost,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("seller_media_cost_selling_currency")]
        SellerMediaCostSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("reseller_revenue_selling_currency")]
        ResellerRevenueSellingCurrency,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_sell_side_billing_trx_type")]
        IsSellSideBillingTrxType,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_filtered")]
        ImpsFiltered,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type")]
        ImpType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type_id")]
        ImpTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("selling_imp_type")]
        SellingImpType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("total_imps")]
        TotalImps,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ad_serving_fees")]
        AdServingFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ad_serving_fees_selling_currency")]
        AdServingFeesSellingCurrency,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("billing_transaction_type_id")]
        BillingTransactionTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("is_deal")]
        IsDeal,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("member_id_str")]
        MemberIdStr,

    }
}