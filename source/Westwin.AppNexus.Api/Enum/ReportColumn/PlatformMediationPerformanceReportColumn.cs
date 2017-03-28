using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum PlatformMediationPerformanceReportColumn : int
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
        [EnumDescription("placement_id")]
        PlacementId,

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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_recency_bucket_id")]
        CreativeRecencyBucketId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_frequency_bucket_id")]
        CreativeFrequencyBucketId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_id")]
        SiteId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_name")]
        SiteName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member")]
        SellerMember,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("width")]
        Width,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("height")]
        Height,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("buyer_member")]
        BuyerMember,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("geo_country")]
        GeoCountry,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_custom_request_template_id")]
        CreativeCustomRequestTemplateId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("creative_custom_request_template_name")]
        CreativeCustomRequestTemplateName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("status")]
        Status,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("os_family_id")]
        OsFamilyId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("os_family_name")]
        OsFamilyName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("latency_bucket")]
        LatencyBucket,

        /// <summary>
        /// Type is int. This column is in havings
        /// </summary>
        [EnumDescription("mediation_requests")]
        MediationRequests,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("fill_rate")]
        FillRate,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("revenue")]
        Revenue,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("latency_50_percentile")]
        LatencyC50Percentile,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("latency_95_percentile")]
        LatencyC95Percentile,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("device_type")]
        DeviceType,

    }
}