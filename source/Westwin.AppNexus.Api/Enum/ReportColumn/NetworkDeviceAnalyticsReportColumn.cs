using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum NetworkDeviceAnalyticsReportColumn : int
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
        [EnumDescription("pub_rule_id")]
        PubRuleId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule_name")]
        PubRuleName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("pub_rule")]
        PubRule,

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
        [EnumDescription("publisher_id")]
        PublisherId,

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
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost")]
        Cost,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue")]
        Revenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue")]
        BookedRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue")]
        ResellerRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit")]
        Profit,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cpm")]
        Cpm,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_convs")]
        TotalConvs,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("convs_rate")]
        ConvsRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("ctr")]
        Ctr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("rpm")]
        Rpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("ppm")]
        Ppm,

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
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_blank")]
        ImpsBlank,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_psa")]
        ImpsPsa,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_default_error")]
        ImpsDefaultError,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_default_bidder")]
        ImpsDefaultBidder,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_kept")]
        ImpsKept,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_resold")]
        ImpsResold,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_rtb")]
        ImpsRtb,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("entity_member_id")]
        EntityMemberId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type_id")]
        ImpTypeId,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_view_convs")]
        PostViewConvs,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_click_convs")]
        PostClickConvs,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("spend_adv_curr")]
        SpendAdvCurr,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("pixel_id")]
        PixelId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_name")]
        InsertionOrderName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order")]
        InsertionOrder,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("sold_network_rpm")]
        SoldNetworkRpm,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("sold_publisher_rpm")]
        SoldPublisherRpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("total_publisher_rpm")]
        TotalPublisherRpm,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("payment_type")]
        PaymentType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_currency")]
        PublisherCurrency,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("convs_per_mm")]
        ConvsPerMm,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_code")]
        InsertionOrderCode,

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
        [EnumDescription("pub_rule_code")]
        PubRuleCode,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediatype")]
        Mediatype,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("media_type")]
        MediaType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("media_type_id")]
        MediaTypeId,

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
        [EnumDescription("device_model_id")]
        DeviceModelId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("device_model")]
        DeviceModel,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("device_model_name")]
        DeviceModelName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("device_make_id")]
        DeviceMakeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("device_make")]
        DeviceMake,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("device_make_name")]
        DeviceMakeName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("connection_type")]
        ConnectionType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("device_type")]
        DeviceType,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("operating_system")]
        OperatingSystem,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("operating_system_id")]
        OperatingSystemId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("operating_system_name")]
        OperatingSystemName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("browser")]
        Browser,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("browser_id")]
        BrowserId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("browser_name")]
        BrowserName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("bid_type")]
        BidType,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_insertion")]
        ImpsInsertion,

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
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("booked_revenue_buying_currency")]
        BookedRevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_buying_currency")]
        RevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("revenue_selling_currency")]
        RevenueSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("reseller_revenue_buying_currency")]
        ResellerRevenueBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("reseller_revenue_selling_currency")]
        ResellerRevenueSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_buying_currency")]
        ProfitBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_selling_currency")]
        ProfitSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_buying_currency")]
        CostBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cost_selling_currency")]
        CostSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm_selling_currency")]
        CpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm_buying_currency")]
        CpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("rpm_buying_currency")]
        RpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("rpm_selling_currency")]
        RpmSellingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ppm_buying_currency")]
        PpmBuyingCurrency,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("ppm_selling_currency")]
        PpmSellingCurrency,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediatype_id")]
        MediatypeId,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_selling_currency")]
        BookedRevenueSellingCurrency,

    }
}