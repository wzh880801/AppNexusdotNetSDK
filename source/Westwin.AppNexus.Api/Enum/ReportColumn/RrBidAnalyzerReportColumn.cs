using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum RrBidAnalyzerReportColumn : int
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
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("line_item_id")]
        LineItemId,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_available")]
        ImpsAvailable,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_bid")]
        ImpsBid,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("imps_won")]
        ImpsWon,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("total_ineligible_pct")]
        TotalIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("country_ineligible_pct")]
        CountryIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("non_country_ineligible_pct")]
        NonCountryIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("inventory_ineligible_pct")]
        InventoryIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("segment_ineligible_pct")]
        SegmentIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("geo_ineligible_pct")]
        GeoIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_ineligible_pct")]
        CreativeIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_size_ineligible_pct")]
        CreativeSizeIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("creative_targeted_ineligible_pct")]
        CreativeTargetedIneligiblePct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("lost_internal_auction_pct")]
        LostInternalAuctionPct,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("lost_external_auction_pct")]
        LostExternalAuctionPct,

        /// <summary>
        /// Type is double. This column is not in havings
        /// </summary>
        [EnumDescription("avg_bpp_multiplier")]
        AvgBppMultiplier,

        /// <summary>
        /// Type is int. This column is not in havings
        /// </summary>
        [EnumDescription("is_sleeping")]
        IsSleeping,

    }
}