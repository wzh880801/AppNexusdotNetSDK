using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkBillingReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member")]
        SellerMember,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser")]
        Advertiser,

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
        [EnumDescription("line_item")]
        LineItem,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_revenue")]
        NetworkRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue")]
        ResellerRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_profit")]
        NetworkProfit,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("ecpm")]
        Ecpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("ctr")]
        Ctr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_rpm")]
        NetworkRpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_ppm")]
        NetworkPpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_type")]
        BuyerType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_type")]
        SellerType,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("spend")]
        Spend,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_adv_curr")]
        BookedRevenueAdvCurr,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("booked_revenue")]
        BookedRevenue,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesperson_for_advertiser")]
        SalespersonForAdvertiser,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesperson_for_publisher")]
        SalespersonForPublisher,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("account_manager_for_advertiser")]
        AccountManagerForAdvertiser,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("account_manager_for_publisher")]
        AccountManagerForPublisher,

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
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("auction_service_deduction")]
        AuctionServiceDeduction,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("cleared_direct")]
        ClearedDirect,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("payment_type")]
        PaymentType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("adjustment_id")]
        AdjustmentId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_currency")]
        PublisherCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("ecpm_pub_curr")]
        EcpmPubCurr,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_currency")]
        BuyerCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_pub_curr")]
        MediaCostPubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_roi")]
        NetworkRoi,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_revenue")]
        AdvertiserRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_profit")]
        AdvertiserProfit,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_rpm")]
        AdvertiserRpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_ppm")]
        AdvertiserPpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("advertiser_roi")]
        AdvertiserRoi,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("entity_member_id")]
        EntityMemberId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_id")]
        CampaignId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_name")]
        CampaignName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("campaign")]
        Campaign,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("convs")]
        Convs,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("convs_rate")]
        ConvsRate,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("trafficker_for_line_item")]
        TraffickerForLineItem,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("salesrep_for_line_item")]
        SalesrepForLineItem,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type_id")]
        RevenueTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_type")]
        RevenueType,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("click_thru_pct")]
        ClickThruPct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_priority")]
        CampaignPriority,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_code")]
        LineItemCode,

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
        [EnumDescription("publisher_code")]
        PublisherCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_code")]
        PlacementCode,

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
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

        /// <summary>
        /// Type is . This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_name")]
        InsertionOrderName,

        /// <summary>
        /// Type is . This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order")]
        InsertionOrder,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("net_media_cost")]
        NetMediaCost,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_adv_curr")]
        MediaCostAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("auction_service_fees_adv_curr")]
        AuctionServiceFeesAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("auction_service_deduction_adv_curr")]
        AuctionServiceDeductionAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("creative_overage_fees_adv_curr")]
        CreativeOverageFeesAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue_pub_curr")]
        ResellerRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("net_media_cost_adv_curr")]
        NetMediaCostAdvCurr,

    }
}