using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum CompletedCreativeAuditsReportColumn : int
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
        [EnumDescription("advertiser_id")]
        AdvertiserId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("advertiser_name")]
        AdvertiserName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id")]
        MemberId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("audit_reason_id")]
        AuditReasonId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("audit_reason")]
        AuditReason,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("audit_type_id")]
        AuditTypeId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("audit_type")]
        AuditType,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("num_audits_completed")]
        NumAuditsCompleted,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("total_audit_fee")]
        TotalAuditFee,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("member_name")]
        MemberName,

        /// <summary>
        /// Type is date. This column is not in havings
        /// </summary>
        [EnumDescription("audit_completion_date")]
        AuditCompletionDate,

    }
}