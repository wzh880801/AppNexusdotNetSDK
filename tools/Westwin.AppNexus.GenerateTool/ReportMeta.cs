using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westwin.AppNexus.GenerateTool
{
    public class ReportMeta
    {
        public Response response { get; set; }

        public class Response
        {
            public string status { get; set; }
            public Meta meta { get; set; }
            public Dbg_Info dbg_info { get; set; }
        }

        public class Meta
        {
            public Network_Analytics network_analytics { get; set; }
            public Advertiser_Analytics advertiser_analytics { get; set; }
            public Network_Advertiser_Analytics network_advertiser_analytics { get; set; }
            public Inventory_Daily_Uniques inventory_daily_uniques { get; set; }
            public Opt_Dash_Analytics opt_dash_analytics { get; set; }
            public Buyer_Platform_Billing buyer_platform_billing { get; set; }
            public Platform_Buyer platform_buyer { get; set; }
            public Platform_Seller platform_seller { get; set; }
            public Seller_Platform_Billing seller_platform_billing { get; set; }
            public Network_Publisher_Analytics network_publisher_analytics { get; set; }
            public Publisher_Analytics publisher_analytics { get; set; }
            public Content_Category_Volume content_category_volume { get; set; }
            public Site_Domain_Performance site_domain_performance { get; set; }
            public Advertiser_Analytics_Daily advertiser_analytics_daily { get; set; }
            public Network_Billing network_billing { get; set; }
            public Network_Analytics_Feed network_analytics_feed { get; set; }
            public Attributed_Conversions attributed_conversions { get; set; }
            public Network_Site_Domain_Performance network_site_domain_performance { get; set; }
            public Pixel_Fired pixel_fired { get; set; }
            public Network_Advertiser_Frequency_Recency network_advertiser_frequency_recency { get; set; }
            public Advertiser_Frequency_Recency advertiser_frequency_recency { get; set; }
            public Opt_Dash_Analytics_Test opt_dash_analytics_test { get; set; }
            public Advertiser_Analytics_Daily_Test2 advertiser_analytics_daily_test2 { get; set; }
            public Clicktrackers clicktrackers { get; set; }
            public Ttui_Platform_Seller ttui_platform_seller { get; set; }
            public Ttui_Seller_Platform_Billing ttui_seller_platform_billing { get; set; }
            public Seller_Site_Domain seller_site_domain { get; set; }
            public Segment_Load segment_load { get; set; }
            public Inventory_Source_Analytics inventory_source_analytics { get; set; }
            public Inventory_Domain_Analytics inventory_domain_analytics { get; set; }
            public Network_Device_Analytics network_device_analytics { get; set; }
            public Network_Carrier_Analytics network_carrier_analytics { get; set; }
            public Geo_Analytics geo_analytics { get; set; }
            public Network_Creative_Search network_creative_search { get; set; }
            public Publisher_Creative_Search publisher_creative_search { get; set; }
            public Buyer_Segment_Performance buyer_segment_performance { get; set; }
            public Platform_Mediation_Performance platform_mediation_performance { get; set; }
            public Dp_Segment_Usage dp_segment_usage { get; set; }
            public Rr_Buyer_Analytics_Daily rr_buyer_analytics_daily { get; set; }
            public Rr_Buyer_Analytics_Hourly rr_buyer_analytics_hourly { get; set; }
            public Rr_Targeted_Segment_Analytics_Daily rr_targeted_segment_analytics_daily { get; set; }
            public Rr_Targeted_Segment_Analytics_Hourly rr_targeted_segment_analytics_hourly { get; set; }
            public Partner_Center_Buy_Side partner_center_buy_side { get; set; }
            public Partner_Center_Sell_Side partner_center_sell_side { get; set; }
            public Seller_Monetization seller_monetization { get; set; }
            public Mediation_Adjustments mediation_adjustments { get; set; }
            public Completed_Creative_Audits completed_creative_audits { get; set; }
            public Seller_Detected_Site_Domain seller_detected_site_domain { get; set; }
            public Seller_Brand_Review seller_brand_review { get; set; }
            public Publisher_Brand_Review publisher_brand_review { get; set; }
            public Video_Analytics_Network video_analytics_network { get; set; }
            public Video_Analytics_Network_Advertiser video_analytics_network_advertiser { get; set; }
            public Video_Analytics_Network_Publisher video_analytics_network_publisher { get; set; }
            public Rr_Buyer_Analytics_Lifetime rr_buyer_analytics_lifetime { get; set; }
            public Rr_Buyer_Analytics_Billing_Period rr_buyer_analytics_billing_period { get; set; }
            public Spend_Protection_Analytics spend_protection_analytics { get; set; }
            public Forecast forecast { get; set; }
            public Rr_Forecast rr_forecast { get; set; }
            public Spend_Protection_Violations spend_protection_violations { get; set; }
            public Platform_Seller_Site_Domain_Performance platform_seller_site_domain_performance { get; set; }
            public Buyer_Data_Usage_Analytics buyer_data_usage_analytics { get; set; }
            public Tpas_Analytics tpas_analytics { get; set; }
            public Seller_Analytics_Hourly seller_analytics_hourly { get; set; }
            public Seller_Analytics_Daily seller_analytics_daily { get; set; }
            public Seller_Analytics_Lifetime seller_analytics_lifetime { get; set; }
            public Mrc_Analytics_Network_Advertiser mrc_analytics_network_advertiser { get; set; }
            public Mrc_Analytics_Network_Publisher mrc_analytics_network_publisher { get; set; }
            public Mrc_Analytics_Network_Publisher_BUG_Isac mrc_analytics_network_publisher_BUG_iSac { get; set; }
            public Periscope_Forecast periscope_forecast { get; set; }
            public Buyer_Untargeted_Segment_Performance buyer_untargeted_segment_performance { get; set; }
            public Advertiser_Frequency advertiser_frequency { get; set; }
            public Data_Usage_Analytics_For_Data_Providers data_usage_analytics_for_data_providers { get; set; }
            public Seller_Fill_And_Delivery_Network seller_fill_and_delivery_network { get; set; }
            public Seller_Fill_And_Delivery_Publisher seller_fill_and_delivery_publisher { get; set; }
            public Network_Attributed_Conversions network_attributed_conversions { get; set; }
            public Rr_Periscope_Forecast rr_periscope_forecast { get; set; }
            public Insertion_Order_Frequency insertion_order_frequency { get; set; }
            public Line_Item_Frequency line_item_frequency { get; set; }
            public Standard_Log_Level_Events standard_log_level_events { get; set; }
            public Standard_Log_Level_Events2 standard_log_level_events2 { get; set; }
            public Buyer_Pricing_Report buyer_pricing_report { get; set; }
            public Seller_Pricing_Report seller_pricing_report { get; set; }
            public Seller_Bid_Error_Report seller_bid_error_report { get; set; }
            public Hearst_Billing_Ll hearst_billing_ll { get; set; }
            public Buyer_Bid_Error_Report buyer_bid_error_report { get; set; }
            public PrebidAnalyticsHourly PrebidAnalyticsHourly { get; set; }
            public Prebid_Analytics prebid_analytics { get; set; }
            public Prebid_Analytics_Daily prebid_analytics_daily { get; set; }
            public Buyer_Data_Usage_Analytics_Advertiser buyer_data_usage_analytics_advertiser { get; set; }
            public Mrc_Analytics_Network mrc_analytics_network { get; set; }
            public Rr_Bid_Analyzer rr_bid_analyzer { get; set; }
            public Supplemental_Invoice_Activity supplemental_invoice_activity { get; set; }
            public Linkedin_Weekly linkedin_weekly { get; set; }
            [Newtonsoft.Json.JsonProperty("KeyValueAnalytics")]
            public KeyValuePairAnalytics KeyValuePairAnalytics { get; set; }
            public Key_Value_Analytics key_value_analytics { get; set; }
            public Audio_Analytics_Network audio_analytics_network { get; set; }
            public Buyer_Invoice_Report buyer_invoice_report { get; set; }
            public Seller_Invoice_Report seller_invoice_report { get; set; }
            public Network_Analytics_Provisional network_analytics_provisional { get; set; }
        }

        public class Network_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
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

        public class Advertiser_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Advertiser_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Inventory_Daily_Uniques
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Opt_Dash_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Platform_Billing
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Platform_Buyer
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Platform_Seller
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Platform_Billing
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Publisher_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Publisher_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Content_Category_Volume
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Site_Domain_Performance
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Advertiser_Analytics_Daily
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Billing
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Analytics_Feed
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Attributed_Conversions
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Site_Domain_Performance
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Pixel_Fired
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Advertiser_Frequency_Recency
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Advertiser_Frequency_Recency
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Opt_Dash_Analytics_Test
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Advertiser_Analytics_Daily_Test2
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Clicktrackers
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
        }

        public class Ttui_Platform_Seller
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Ttui_Seller_Platform_Billing
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Site_Domain
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Segment_Load
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Inventory_Source_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Inventory_Domain_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Device_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Carrier_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Geo_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Creative_Search
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Publisher_Creative_Search
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Segment_Performance
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Platform_Mediation_Performance
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
        }

        public class Dp_Segment_Usage
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Buyer_Analytics_Daily
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Buyer_Analytics_Hourly
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Targeted_Segment_Analytics_Daily
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Targeted_Segment_Analytics_Hourly
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Partner_Center_Buy_Side
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Partner_Center_Sell_Side
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Monetization
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Mediation_Adjustments
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Completed_Creative_Audits
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Detected_Site_Domain
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Brand_Review
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Publisher_Brand_Review
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Video_Analytics_Network
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Video_Analytics_Network_Advertiser
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Video_Analytics_Network_Publisher
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Buyer_Analytics_Lifetime
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Buyer_Analytics_Billing_Period
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Spend_Protection_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Forecast
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Forecast
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Spend_Protection_Violations
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Platform_Seller_Site_Domain_Performance
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Data_Usage_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Tpas_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Analytics_Hourly
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Analytics_Daily
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Analytics_Lifetime
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Mrc_Analytics_Network_Advertiser
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Mrc_Analytics_Network_Publisher
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Mrc_Analytics_Network_Publisher_BUG_Isac
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Periscope_Forecast
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Untargeted_Segment_Performance
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Advertiser_Frequency
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Data_Usage_Analytics_For_Data_Providers
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Fill_And_Delivery_Network
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Fill_And_Delivery_Publisher
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Attributed_Conversions
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Periscope_Forecast
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Insertion_Order_Frequency
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Line_Item_Frequency
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Standard_Log_Level_Events
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Standard_Log_Level_Events2
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Pricing_Report
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Pricing_Report
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Bid_Error_Report
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Hearst_Billing_Ll
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Bid_Error_Report
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class PrebidAnalyticsHourly
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Prebid_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Prebid_Analytics_Daily
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Data_Usage_Analytics_Advertiser
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Mrc_Analytics_Network
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Rr_Bid_Analyzer
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public Filter[] filters { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Supplemental_Invoice_Activity
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Linkedin_Weekly
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class KeyValuePairAnalytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Key_Value_Analytics
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Audio_Analytics_Network
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public string[] label_fields { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Buyer_Invoice_Report
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Seller_Invoice_Report
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Network_Analytics_Provisional
        {
            public string time_granularity { get; set; }
            public Column[] columns { get; set; }
            public int retention_days { get; set; }
            public Filter[] filters { get; set; }
            public Having[] havings { get; set; }
            public string[] time_intervals { get; set; }
        }

        public class Dbg_Info
        {
            public int userread_limit { get; set; }
            public int userwrite_limit { get; set; }
            public int read_limit { get; set; }
            public int write_limit { get; set; }
            public int userread_limit_seconds { get; set; }
            public int userwrite_limit_seconds { get; set; }
            public int read_limit_seconds { get; set; }
            public int write_limit_seconds { get; set; }
            public string userreads { get; set; }
            public string reads { get; set; }
            public string userwrites { get; set; }
            public string writes { get; set; }
            public string instance { get; set; }
            public string version { get; set; }
            public float time { get; set; }
            public int start_microtime { get; set; }
            public object[] warnings { get; set; }
            public string api_cache_hit { get; set; }
            public string output_term { get; set; }
        }
    }
}