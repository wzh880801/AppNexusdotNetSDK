using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class LineItem
    {
        public long id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public long advertiser_id { get; set; }
        public string state { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string timezone { get; set; }
        public decimal? revenue_value { get; set; }
        public string revenue_type { get; set; }
        public string goal_type { get; set; }
        public string last_modified { get; set; }
        public string click_url { get; set; }
        public string currency { get; set; }
        public bool require_cookie_for_tracking { get; set; }
        public long profile_id { get; set; }
        public long member_id { get; set; }
        public object flat_fee_type { get; set; }
        public string comments { get; set; }
        public int? remaining_days { get; set; }
        public int? total_days { get; set; }
        public bool manage_creative { get; set; }
        public string creative_distribution_type { get; set; }
        public string line_item_type { get; set; }
        public bool prefer_delivery_over_performance { get; set; }
        public AdvertiserInfo advertiser { get; set; }
        public FlatFee flat_fee { get; set; }
        public object delivery_goal { get; set; }
        public object labels { get; set; }
        public object broker_fees { get; set; }
        public Pixel[] pixels { get; set; }
        public Insertion_Orders[] insertion_orders { get; set; }
        public object goal_pixels { get; set; }
        public object imptrackers { get; set; }
        public object clicktrackers { get; set; }
        public object campaigns { get; set; }
        public Valuation valuation { get; set; }
        public Creative[] creatives { get; set; }
        public Budget_Intervals1[] budget_intervals { get; set; }
        public object click_model { get; set; }
        public object expected_value_model { get; set; }
        public Custom_Models[] custom_models { get; set; }
        public Inventory_Discovery inventory_discovery { get; set; }
        public object inventory_discovery_budget { get; set; }
        public object incrementality { get; set; }
        public Auction_Event auction_event { get; set; }
        public object custom_optimization_note { get; set; }
        public object lifetime_budget { get; set; }
        public object lifetime_budget_imps { get; set; }
        public object daily_budget { get; set; }
        public object daily_budget_imps { get; set; }
        public object enable_pacing { get; set; }
        public object allow_safety_pacing { get; set; }
        public object lifetime_pacing { get; set; }
        public object lifetime_pacing_span { get; set; }
        public object lifetime_pacing_pct { get; set; }
        public object payout_margin { get; set; }
        public string inventory_type { get; set; }
        public string priority { get; set; }

        public class Inventory_Discovery
        {
            public bool use_ranked_discovery { get; set; }
            public string fail_criteria_type { get; set; }
            public float fail_criteria_amount { get; set; }
        }

        public class Auction_Event
        {
            public string payment_auction_event_type { get; set; }
            public string revenue_auction_event_type { get; set; }
            public string kpi_auction_event_type { get; set; }
            public object kpi_value { get; set; }
        }

        public class Pixel
        {
            public int id { get; set; }
            public object post_view_revenue { get; set; }
            public object post_click_revenue { get; set; }
            public string state { get; set; }
            public string trigger_type { get; set; }
            public string name { get; set; }
        }

        public class Insertion_Orders
        {
            public int id { get; set; }
            public string state { get; set; }
            public object code { get; set; }
            public string name { get; set; }
            public int advertiser_id { get; set; }
            public object start_date { get; set; }
            public object end_date { get; set; }
            public string timezone { get; set; }
            public string last_modified { get; set; }
            public string currency { get; set; }
            public Budget_Intervals[] budget_intervals { get; set; }
        }

        public class Budget_Intervals
        {
            public int id { get; set; }
            public int object_id { get; set; }
            public string object_type { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public string timezone { get; set; }
            public int lifetime_budget { get; set; }
            public object lifetime_budget_imps { get; set; }
            public bool lifetime_pacing { get; set; }
            public bool enable_pacing { get; set; }
            public object daily_budget_imps { get; set; }
            public object daily_budget { get; set; }
        }

        public class Budget_Intervals1
        {
            public int id { get; set; }
            public int object_id { get; set; }
            public string object_type { get; set; }
            public string start_date { get; set; }
            public string end_date { get; set; }
            public string timezone { get; set; }
            public int parent_interval_id { get; set; }
            public int lifetime_budget { get; set; }
            public object lifetime_budget_imps { get; set; }
            public bool lifetime_pacing { get; set; }
            public bool enable_pacing { get; set; }
            public int lifetime_pacing_pct { get; set; }
        }

        public class Custom_Models
        {
            public string type { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string active { get; set; }
        }

    }
}
