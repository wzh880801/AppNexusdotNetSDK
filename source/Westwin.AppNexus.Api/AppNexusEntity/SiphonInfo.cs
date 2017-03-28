using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class SiphonInfo
    {
        private Dictionary<int, string> _dics = typeof(LogFeedType).ToDictionary();

        /// <summary>
        /// The name of the log-level data feed
        /// </summary>
        public LogFeedType Type { get; set; } = LogFeedType.StandardFeed;

        /// <summary>
        /// The name of the log-level data feed.
        /// Possible values: "standard_feed", "bid_landscape_feed", "segment_feed", or "custom_data_feed" (Query String feed)
        /// </summary>
        [JsonProperty("name")]
        internal string Name
        {
            get
            {
                return _dics[(int)this.Type];
            }
            set
            {
                foreach(var c in _dics)
                {
                    if(c.Value == value)
                    {
                        this.Type = (LogFeedType)(c.Key);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// The hour when the feed was generated. The format is YYYY_MM_DD_HH, i.e., "2012_02_19_19".
        /// </summary>
        [JsonProperty("hour")]
        public string Hour { get; set; }

        /// <summary>
        /// The date and time when the feed was generated. The format is YYYYMMDDHHMMSS, i.e., "20120209134931".
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// The file parts into which the log-level data feed is split. Each part includes a status and checksum. 
        /// See Split below for more details.
        /// </summary>
        [JsonProperty("splits")]
        public SplitInfo[] Splits { get; set; }
    }
}