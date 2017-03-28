using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum KeyValuePairAnalyticsReportColumn : int
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
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("key_name")]
        KeyName,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("key_value")]
        KeyValue,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("key_name_label")]
        KeyNameLabel,

        /// <summary>
        /// Type is string. This column is not in havings
        /// </summary>
        [EnumDescription("key_value_label")]
        KeyValueLabel,

    }
}