using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum SellerDetectedSiteDomainReportColumn : int
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
        [EnumDescription("seller_member_id")]
        SellerMemberId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement")]
        Placement,

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
        [EnumDescription("site")]
        Site,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("seller_member_name")]
        SellerMemberName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("placement_id")]
        PlacementId,

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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("auction_site_domain")]
        AuctionSiteDomain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain_audit_status")]
        SiteDomainAuditStatus,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("site_domain_audit_status_id")]
        SiteDomainAuditStatusId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("detected_site_domain")]
        DetectedSiteDomain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("detected_site_domain_audit_status")]
        DetectedSiteDomainAuditStatus,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("detected_site_domain_audit_status_id")]
        DetectedSiteDomainAuditStatusId,

        /// <summary>
        /// Type is boolean. This column is not in havings
        /// </summary>
        [EnumDescription("is_blacklisted")]
        IsBlacklisted,

        /// <summary>
        /// Type is boolean. This column is not in havings
        /// </summary>
        [EnumDescription("detected_top_domain")]
        DetectedTopDomain,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("placement_name")]
        PlacementName,

    }
}