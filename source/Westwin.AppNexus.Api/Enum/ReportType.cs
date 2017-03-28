using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportType : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_analytics")]
        NetworkAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("advertiser_analytics")]
        AdvertiserAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_advertiser_analytics")]
        NetworkAdvertiserAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("inventory_daily_uniques")]
        InventoryDailyUniques,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("opt_dash_analytics")]
        OptDashAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_platform_billing")]
        BuyerPlatformBilling,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("platform_buyer")]
        PlatformBuyer,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("platform_seller")]
        PlatformSeller,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_platform_billing")]
        SellerPlatformBilling,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_publisher_analytics")]
        NetworkPublisherAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("publisher_analytics")]
        PublisherAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("content_category_volume")]
        ContentCategoryVolume,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("site_domain_performance")]
        SiteDomainPerformance,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("advertiser_analytics_daily")]
        AdvertiserAnalyticsDaily,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_billing")]
        NetworkBilling,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_analytics_feed")]
        NetworkAnalyticsFeed,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("attributed_conversions")]
        AttributedConversions,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_site_domain_performance")]
        NetworkSiteDomainPerformance,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("pixel_fired")]
        PixelFired,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_advertiser_frequency_recency")]
        NetworkAdvertiserFrequencyRecency,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("advertiser_frequency_recency")]
        AdvertiserFrequencyRecency,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("opt_dash_analytics_test")]
        OptDashAnalyticsTest,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("advertiser_analytics_daily_test2")]
        AdvertiserAnalyticsDailyTest2,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("clicktrackers")]
        Clicktrackers,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("ttui_platform_seller")]
        TtuiPlatformSeller,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("ttui_seller_platform_billing")]
        TtuiSellerPlatformBilling,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_site_domain")]
        SellerSiteDomain,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("segment_load")]
        SegmentLoad,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("inventory_source_analytics")]
        InventorySourceAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("inventory_domain_analytics")]
        InventoryDomainAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_device_analytics")]
        NetworkDeviceAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_carrier_analytics")]
        NetworkCarrierAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("geo_analytics")]
        GeoAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_creative_search")]
        NetworkCreativeSearch,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("publisher_creative_search")]
        PublisherCreativeSearch,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_segment_performance")]
        BuyerSegmentPerformance,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("platform_mediation_performance")]
        PlatformMediationPerformance,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("dp_segment_usage")]
        DpSegmentUsage,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_buyer_analytics_daily")]
        RrBuyerAnalyticsDaily,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_buyer_analytics_hourly")]
        RrBuyerAnalyticsHourly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_targeted_segment_analytics_daily")]
        RrTargetedSegmentAnalyticsDaily,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_targeted_segment_analytics_hourly")]
        RrTargetedSegmentAnalyticsHourly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("partner_center_buy_side")]
        PartnerCenterBuySide,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("partner_center_sell_side")]
        PartnerCenterSellSide,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_monetization")]
        SellerMonetization,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("mediation_adjustments")]
        MediationAdjustments,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("completed_creative_audits")]
        CompletedCreativeAudits,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_detected_site_domain")]
        SellerDetectedSiteDomain,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_brand_review")]
        SellerBrandReview,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("publisher_brand_review")]
        PublisherBrandReview,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("video_analytics_network")]
        VideoAnalyticsNetwork,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("video_analytics_network_advertiser")]
        VideoAnalyticsNetworkAdvertiser,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("video_analytics_network_publisher")]
        VideoAnalyticsNetworkPublisher,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_buyer_analytics_lifetime")]
        RrBuyerAnalyticsLifetime,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_buyer_analytics_billing_period")]
        RrBuyerAnalyticsBillingPeriod,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("spend_protection_analytics")]
        SpendProtectionAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("forecast")]
        Forecast,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_forecast")]
        RrForecast,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("spend_protection_violations")]
        SpendProtectionViolations,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("platform_seller_site_domain_performance")]
        PlatformSellerSiteDomainPerformance,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_data_usage_analytics")]
        BuyerDataUsageAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("tpas_analytics")]
        TpasAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_analytics_hourly")]
        SellerAnalyticsHourly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_analytics_daily")]
        SellerAnalyticsDaily,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_analytics_lifetime")]
        SellerAnalyticsLifetime,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("mrc_analytics_network_advertiser")]
        MrcAnalyticsNetworkAdvertiser,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("mrc_analytics_network_publisher")]
        MrcAnalyticsNetworkPublisher,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("mrc_analytics_network_publisher_BUG_iSac")]
        MrcAnalyticsNetworkPublisherBUGISac,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("periscope_forecast")]
        PeriscopeForecast,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_untargeted_segment_performance")]
        BuyerUntargetedSegmentPerformance,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("advertiser_frequency")]
        AdvertiserFrequency,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("data_usage_analytics_for_data_providers")]
        DataUsageAnalyticsForDataProviders,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_fill_and_delivery_network")]
        SellerFillAndDeliveryNetwork,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_fill_and_delivery_publisher")]
        SellerFillAndDeliveryPublisher,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_attributed_conversions")]
        NetworkAttributedConversions,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_periscope_forecast")]
        RrPeriscopeForecast,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("insertion_order_frequency")]
        InsertionOrderFrequency,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("line_item_frequency")]
        LineItemFrequency,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("standard_log_level_events")]
        StandardLogLevelEvents,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("standard_log_level_events2")]
        StandardLogLevelEvents2,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_pricing_report")]
        BuyerPricingReport,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_pricing_report")]
        SellerPricingReport,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_bid_error_report")]
        SellerBidErrorReport,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("hearst_billing_ll")]
        HearstBillingLl,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_bid_error_report")]
        BuyerBidErrorReport,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("PrebidAnalyticsHourly")]
        PrebidAnalyticsHourly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("prebid_analytics")]
        PrebidAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("prebid_analytics_daily")]
        PrebidAnalyticsDaily,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_data_usage_analytics_advertiser")]
        BuyerDataUsageAnalyticsAdvertiser,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("mrc_analytics_network")]
        MrcAnalyticsNetwork,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("rr_bid_analyzer")]
        RrBidAnalyzer,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("supplemental_invoice_activity")]
        SupplementalInvoiceActivity,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("linkedin_weekly")]
        LinkedinWeekly,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("KeyValuePairAnalytics")]
        KeyValuePairAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("key_value_analytics")]
        KeyValueAnalytics,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("audio_analytics_network")]
        AudioAnalyticsNetwork,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("buyer_invoice_report")]
        BuyerInvoiceReport,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("seller_invoice_report")]
        SellerInvoiceReport,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("network_analytics_provisional")]
        NetworkAnalyticsProvisional,
    }
}