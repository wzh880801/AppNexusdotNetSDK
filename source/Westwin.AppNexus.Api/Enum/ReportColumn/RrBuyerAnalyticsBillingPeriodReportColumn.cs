using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum RrBuyerAnalyticsBillingPeriodReportColumn : int
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
        [EnumDescription("booked_revenue")]
        BookedRevenue,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("total_convs")]
        TotalConvs,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_view_convs")]
        PostViewConvs,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("post_view_revenue")]
        PostViewRevenue,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("post_click_convs")]
        PostClickConvs,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("post_click_revenue")]
        PostClickRevenue,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("media_cost")]
        MediaCost,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("profit_ecpm")]
        ProfitEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpc")]
        RevenueEcpc,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpa")]
        RevenueEcpa,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpc")]
        CostEcpc,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpa")]
        CostEcpa,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("profit_margin")]
        ProfitMargin,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpm_adv_curr")]
        RevenueEcpmAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpc_adv_curr")]
        RevenueEcpcAdvCurr,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpa_adv_curr")]
        RevenueEcpaAdvCurr,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_id")]
        InsertionOrderId,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("campaign_group_id")]
        CampaignGroupId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("pixel_id")]
        PixelId,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("booked_revenue_adv_curr")]
        BookedRevenueAdvCurr,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("conv_rate_pct")]
        ConvRatePct,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("ctr_pct")]
        CtrPct,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("revenue_ecpm")]
        RevenueEcpm,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("cost_ecpm")]
        CostEcpm,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("imps_viewed")]
        ImpsViewed,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("view_measured_imps")]
        ViewMeasuredImps,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_rate")]
        ViewRate,

        /// <summary>
        /// Type is double. This column is in havings
        /// </summary>
        [EnumDescription("view_measurement_rate")]
        ViewMeasurementRate,

        /// <summary>
        /// Type is datetime. This column is not in havings
        /// </summary>
        [EnumDescription("billing_period_start_date")]
        BillingPeriodStartDate,

        /// <summary>
        /// Type is datetime. This column is not in havings
        /// </summary>
        [EnumDescription("billing_period_end_date")]
        BillingPeriodEndDate,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("billing_period_id")]
        BillingPeriodId,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("third_party_costs")]
        ThirdPartyCosts,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit")]
        Profit,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("profit_new")]
        ProfitNew,

    }
}