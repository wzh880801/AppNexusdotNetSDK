using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// The name of the log-level data feed
    /// </summary>
    public enum LogFeedType : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("standard_feed")]
        StandardFeed,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("bid_landscape_feed")]
        BidLandscapeFeed,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("segment_feed")]
        SegmentFeed,

        /// <summary>
        /// Query String feed
        /// </summary>
        [EnumDescription("custom_data_feed")]
        CustomDataFeed,
    }
}