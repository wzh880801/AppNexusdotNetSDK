using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class DbgInfo
    {
        /// <summary>
        /// The API machine which processed the request.
        /// </summary>
        [JsonProperty("instance")]
        public string Instance { get; set; }

        /// <summary>
        /// Whether or not the API machine ran SQL queries on a database slave.
        /// </summary>
        [JsonProperty("slave_hit")]
        public bool SlaveHit { get; set; }

        /// <summary>
        /// The database the query was executed on.
        /// </summary>
        [JsonProperty("db")]
        public string DbName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_dbg_info")]
        public DbgInfo ParentDbgInfo { get; set; }

        [JsonProperty("awesomesauce_cache_used")]
        public bool AwesomesauceCacheUsed { get; set; }

        [JsonProperty("count_cache_used")]
        public bool CountCacheUsed { get; set; }

        [JsonProperty("uuid")]
        public string UuId { get; set; }

        [JsonProperty("warnings")]
        public object[] Warnings { get; set; }

        /// <summary>
        /// The amount of time it took to process the API request, expressed in milliseconds.
        /// </summary>
        [JsonProperty("time")]
        public double TimeCost { get; set; }

        /// <summary>
        /// The UNIX timestamp of the start time of processing, including milliseconds (listed on the right side of the decimal point).
        /// </summary>
        [JsonProperty("start_microtime")]
        public double StartMicrotime { get; set; }

        /// <summary>
        /// The version of the API.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("slave_lag")]
        public int SlaveLag { get; set; }

        [JsonProperty("output_term")]
        public string OutputTerm { get; set; }

        /// <summary>
        /// The number of reads made.
        /// </summary>
        [JsonProperty("reads")]
        public int Reads { get; set; }

        /// <summary>
        /// The limit on the number of reads.
        /// </summary>
        [JsonProperty("read_limit")]
        public int ReadLimit { get; set; }

        /// <summary>
        /// The time period over which the read_limit is enforced.
        /// </summary>
        [JsonProperty("read_limit_seconds")]
        public int ReadLimitSeconds { get; set; }

        /// <summary>
        /// The number of writes made.
        /// </summary>
        [JsonProperty("writes")]
        public int Writes { get; set; }

        /// <summary>
        /// The number of writes made.
        /// </summary>
        [JsonProperty("write_limit")]
        public int WriteLimit { get; set; }

        /// <summary>
        /// The time period over which the write_limit is enforced.
        /// </summary>
        [JsonProperty("write_limit_seconds")]
        public int WriteLimitSeconds { get; set; }

        [JsonProperty("user::reads")]
        public int UserReads { get; set; }

        [JsonProperty("user::read_limit")]
        public int UserReadLimit { get; set; }

        [JsonProperty("user::read_limit_seconds")]
        public int UserReadLimitSeconds { get; set; }

        [JsonProperty("user::writes")]
        public int UserWrites { get; set; }

        [JsonProperty("user::write_limit")]
        public int UserWriteLimit { get; set; }

        [JsonProperty("user::write_limit_seconds")]
        public int UserWriteLimitSeconds { get; set; }
    }
}