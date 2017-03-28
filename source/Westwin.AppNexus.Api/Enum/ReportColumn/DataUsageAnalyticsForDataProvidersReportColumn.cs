using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum DataUsageAnalyticsForDataProvidersReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_currency")]
        AdvertiserCurrency,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_name")]
        AdvertiserName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country_code")]
        GeoCountryCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_name")]
        InsertionOrderName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("insertion_order_code")]
        InsertionOrderCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_name")]
        LineItemName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_code")]
        LineItemCode,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("targeted_segment_ids")]
        TargetedSegmentIds,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("data_provider_name")]
        DataProviderName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("data_provider")]
        DataProvider,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("data_costs")]
        DataCosts,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("data_clearing_fee_usd")]
        DataClearingFeeUsd,

        /// <summary>
        /// Type is money. This column is in havings
        /// </summary>
        [EnumDescription("data_provider_payout_usd")]
        DataProviderPayoutUsd,

        /// <summary>
        /// Type is money. This column is not in havings
        /// </summary>
        [EnumDescription("cpm_usd")]
        CpmUsd,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("data_provider_id")]
        DataProviderId,

    }
}