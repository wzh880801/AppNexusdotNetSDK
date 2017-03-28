using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum BuyerPricingReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_code")]
        LineItemCode,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("cleared_direct")]
        ClearedDirect,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_id")]
        LineItemId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_name")]
        LineItemName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_name")]
        CampaignName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_id")]
        CampaignId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_code")]
        CampaignCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_code")]
        AdvertiserCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member_name")]
        BuyerMemberName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_code")]
        InsertionOrderCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_name")]
        InsertionOrderName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_delivered")]
        IsDelivered,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_valid_buyer")]
        IsValidBuyer,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buying_currency")]
        BuyingCurrency,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_valid_buying_imp_type")]
        IsValidBuyingImpType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("selling_currency")]
        SellingCurrency,

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
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("creative_overage_fees")]
        CreativeOverageFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_media_cost_buying_currency")]
        BuyerMediaCostBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_buying_currency")]
        BookedRevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_dollars_buying_currency")]
        BookedRevenueDollarsBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("creative_overage_fees_buying_currency")]
        CreativeOverageFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("net_media_cost_buying_currency")]
        NetMediaCostBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("booked_revenue")]
        BookedRevenue,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_media_cost")]
        BuyerMediaCost,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("net_media_cost")]
        NetMediaCost,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_buy_side_billing_trx_type")]
        IsBuySideBillingTrxType,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("buying_imp_type_id")]
        BuyingImpTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buying_imp_type")]
        BuyingImpType,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_fees_buying_currency")]
        AuctionServiceFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_deduction_buying_currency")]
        AuctionServiceDeductionBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_fees")]
        AuctionServiceFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_deduction")]
        AuctionServiceDeduction,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("fx_margin_fees")]
        FxMarginFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("fx_margin_deductions")]
        FxMarginDeductions,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("service_fees")]
        ServiceFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("service_deductions")]
        ServiceDeductions,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ad_serving_fees")]
        AdServingFees,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_ad_serving_fees")]
        BuyerAdServingFees,

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
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("fx_margin_fees_buying_currency")]
        FxMarginFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("fx_margin_deductions_buying_currency")]
        FxMarginDeductionsBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("service_fees_buying_currency")]
        ServiceFeesBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("service_deductions_buying_currency")]
        ServiceDeductionsBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ad_serving_fees_buying_currency")]
        AdServingFeesBuyingCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("member_id_str")]
        MemberIdStr,

    }
}