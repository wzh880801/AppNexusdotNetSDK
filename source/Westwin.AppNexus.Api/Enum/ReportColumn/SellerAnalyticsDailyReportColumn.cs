using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SellerAnalyticsDailyReportColumn : int
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
        [EnumDescription("seller_member_id")]
        SellerMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_name")]
        PlacementName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_id")]
        PublisherId,

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
        [EnumDescription("network_revenue")]
        NetworkRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue")]
        Revenue,

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
        [EnumDescription("imps_kept")]
        ImpsKept,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_resold")]
        ImpsResold,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("booked_revenue_dollars")]
        BookedRevenueDollars,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_default")]
        ImpsDefault,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_currency")]
        PublisherCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_pub_curr")]
        MediaCostPubCurr,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("tag_id")]
        TagId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_filled")]
        ImpsFilled,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("imp_type")]
        ImpType,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("ymd")]
        Ymd,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_viewed")]
        ImpsViewed,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("fill_rate")]
        FillRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_rate")]
        ViewRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_measurable_imps")]
        ViewMeasurableImps,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("publisher_ecpm")]
        PublisherEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("deal_reseller_revenue")]
        DealResellerRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("nondeal_reseller_revenue")]
        NondealResellerRevenue,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("publisher_exchange_rate")]
        PublisherExchangeRate,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("filtered_imps")]
        FilteredImps,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("ad_requests")]
        AdRequests,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("network_revenue_pub_curr")]
        NetworkRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("reseller_revenue_pub_curr")]
        ResellerRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cpm_pub_curr")]
        CpmPubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("rpm_pub_curr")]
        RpmPubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("ppm_pub_curr")]
        PpmPubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_pub_curr")]
        BookedRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("publisher_ecpm_pub_curr")]
        PublisherEcpmPubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("deal_reseller_revenue_pub_curr")]
        DealResellerRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("nondeal_reseller_revenue_pub_curr")]
        NondealResellerRevenuePubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_pub_curr")]
        ProfitPubCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost_pub_currency")]
        MediaCostPubCurrency,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("ad_responses")]
        AdResponses,

    }
}