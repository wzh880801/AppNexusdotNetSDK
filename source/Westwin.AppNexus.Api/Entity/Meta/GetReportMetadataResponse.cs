using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetReportMetadataResponse : AppNexusBaseResponse
    {
        public _GetReportMetadataResponse response { get; set; }

        public class _GetReportMetadataResponse
        {
            public string status { get; set; }
            public Meta meta { get; set; }
            public DbgInfo dbg_info { get; set; }
        }

        public class Meta
        {
            public ReportMeta network_analytics { get; set; }
            public ReportMeta advertiser_analytics { get; set; }
            public ReportMeta network_advertiser_analytics { get; set; }
            public ReportMeta inventory_daily_uniques { get; set; }
            public ReportMeta opt_dash_analytics { get; set; }
            public ReportMeta buyer_platform_billing { get; set; }
            public ReportMeta platform_buyer { get; set; }
            public ReportMeta platform_seller { get; set; }
            public ReportMeta seller_platform_billing { get; set; }
            public ReportMeta network_publisher_analytics { get; set; }
            public ReportMeta publisher_analytics { get; set; }
            public ReportMeta content_category_volume { get; set; }
            public ReportMeta site_domain_performance { get; set; }
            public ReportMeta advertiser_analytics_daily { get; set; }
            public ReportMeta network_billing { get; set; }
            public ReportMeta network_analytics_feed { get; set; }
            public ReportMeta attributed_conversions { get; set; }
            public ReportMeta network_site_domain_performance { get; set; }
            public ReportMeta pixel_fired { get; set; }
            public ReportMeta network_advertiser_frequency_recency { get; set; }
            public ReportMeta advertiser_frequency_recency { get; set; }
            public ReportMeta opt_dash_analytics_test { get; set; }
            public ReportMeta advertiser_analytics_daily_test2 { get; set; }
            public ReportMeta clicktrackers { get; set; }
            public ReportMeta ttui_platform_seller { get; set; }
            public ReportMeta ttui_seller_platform_billing { get; set; }
            public ReportMeta seller_site_domain { get; set; }
            public ReportMeta segment_load { get; set; }
            public ReportMeta inventory_source_analytics { get; set; }
            public ReportMeta inventory_domain_analytics { get; set; }
            public ReportMeta network_device_analytics { get; set; }
            public ReportMeta network_carrier_analytics { get; set; }
            public ReportMeta geo_analytics { get; set; }
            public ReportMeta network_creative_search { get; set; }
            public ReportMeta publisher_creative_search { get; set; }
            public ReportMeta buyer_segment_performance { get; set; }
            public ReportMeta platform_mediation_performance { get; set; }
            public ReportMeta dp_segment_usage { get; set; }
            public ReportMeta rr_buyer_analytics_daily { get; set; }
            public ReportMeta rr_buyer_analytics_hourly { get; set; }
            public ReportMeta rr_targeted_segment_analytics_daily { get; set; }
            public ReportMeta rr_targeted_segment_analytics_hourly { get; set; }
            public ReportMeta partner_center_buy_side { get; set; }
            public ReportMeta partner_center_sell_side { get; set; }
            public ReportMeta seller_monetization { get; set; }
            public ReportMeta mediation_adjustments { get; set; }
            public ReportMeta completed_creative_audits { get; set; }
            public ReportMeta seller_detected_site_domain { get; set; }
            public ReportMeta seller_brand_review { get; set; }
            public ReportMeta publisher_brand_review { get; set; }
            public ReportMeta video_analytics_network { get; set; }
            public ReportMeta video_analytics_network_advertiser { get; set; }
            public ReportMeta video_analytics_network_publisher { get; set; }
            public ReportMeta rr_buyer_analytics_lifetime { get; set; }
            public ReportMeta rr_buyer_analytics_billing_period { get; set; }
            public ReportMeta spend_protection_analytics { get; set; }
            public ReportMeta forecast { get; set; }
            public ReportMeta rr_forecast { get; set; }
            public ReportMeta spend_protection_violations { get; set; }
            public ReportMeta platform_seller_site_domain_performance { get; set; }
            public ReportMeta buyer_data_usage_analytics { get; set; }
            public ReportMeta tpas_analytics { get; set; }
            public ReportMeta seller_analytics_hourly { get; set; }
            public ReportMeta seller_analytics_daily { get; set; }
            public ReportMeta seller_analytics_lifetime { get; set; }
            public ReportMeta mrc_analytics_network_advertiser { get; set; }
            public ReportMeta mrc_analytics_network_publisher { get; set; }
            public ReportMeta mrc_analytics_network_publisher_BUG_iSac { get; set; }
            public ReportMeta periscope_forecast { get; set; }
            public ReportMeta buyer_untargeted_segment_performance { get; set; }
            public ReportMeta advertiser_frequency { get; set; }
            public ReportMeta data_usage_analytics_for_data_providers { get; set; }
            public ReportMeta seller_fill_and_delivery_network { get; set; }
            public ReportMeta seller_fill_and_delivery_publisher { get; set; }
            public ReportMeta network_attributed_conversions { get; set; }
            public ReportMeta rr_periscope_forecast { get; set; }
            public ReportMeta insertion_order_frequency { get; set; }
            public ReportMeta line_item_frequency { get; set; }
            public ReportMeta standard_log_level_events { get; set; }
            public ReportMeta standard_log_level_events2 { get; set; }
            public ReportMeta buyer_pricing_report { get; set; }
            public ReportMeta seller_pricing_report { get; set; }
            public ReportMeta seller_bid_error_report { get; set; }
            public ReportMeta hearst_billing_ll { get; set; }
            public ReportMeta buyer_bid_error_report { get; set; }
            public ReportMeta PrebidAnalyticsHourly { get; set; }
            public ReportMeta prebid_analytics { get; set; }
            public ReportMeta prebid_analytics_daily { get; set; }
            public ReportMeta buyer_data_usage_analytics_advertiser { get; set; }
            public ReportMeta mrc_analytics_network { get; set; }
            public ReportMeta rr_bid_analyzer { get; set; }
            public ReportMeta supplemental_invoice_activity { get; set; }
            public ReportMeta linkedin_weekly { get; set; }
            [Newtonsoft.Json.JsonProperty("KeyValueAnalytics")]
            public ReportMeta KeyValuePairAnalytics { get; set; }
            public ReportMeta key_value_analytics { get; set; }
            public ReportMeta audio_analytics_network { get; set; }
            public ReportMeta buyer_invoice_report { get; set; }
            public ReportMeta seller_invoice_report { get; set; }
            public ReportMeta network_analytics_provisional { get; set; }
        }

        public class Column
        {
            public string column { get; set; }
            public string type { get; set; }
        }

        public class Filter
        {
            public string column { get; set; }
            public string type { get; set; }
        }

        public class Having
        {
            public string column { get; set; }
        }

        public class ReportMeta
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
            public int retention_days { get; set; }
        }
    }
}