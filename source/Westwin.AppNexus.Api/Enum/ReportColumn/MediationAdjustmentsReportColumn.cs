using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum MediationAdjustmentsReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("currency")]
        Currency,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("member_id")]
        MemberId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("mediated_network_id")]
        MediatedNetworkId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediated_network_name")]
        MediatedNetworkName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("mediated_bid_id")]
        MediatedBidId,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("mediated_bid_name")]
        MediatedBidName,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("appnexus_mediation_imp_requests")]
        AppnexusMediationImpRequests,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("appnexus_mediation_imp_requests_filled")]
        AppnexusMediationImpRequestsFilled,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("appnexus_mediation_revenue")]
        AppnexusMediationRevenue,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("external_mediation_imp_requests_filled")]
        ExternalMediationImpRequestsFilled,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("external_mediation_revenue")]
        ExternalMediationRevenue,

        /// <summary>
        /// Type is datetime. This column is not in havings
        /// </summary>
        [EnumDescription("start_ymdh")]
        StartYmdh,

        /// <summary>
        /// Type is datetime. This column is not in havings
        /// </summary>
        [EnumDescription("end_ymdh")]
        EndYmdh,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("appnexus_mediation_fill_rate")]
        AppnexusMediationFillRate,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("mediation_discrepency_rate")]
        MediationDiscrepencyRate,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("external_ecpm")]
        ExternalEcpm,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("appnexus_mediation_booked_revenue")]
        AppnexusMediationBookedRevenue,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("external_mediation_revenue_curr")]
        ExternalMediationRevenueCurr,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("external_ecpm_curr")]
        ExternalEcpmCurr,

    }
}