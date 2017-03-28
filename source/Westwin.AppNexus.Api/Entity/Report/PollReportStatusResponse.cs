using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class PollReportStatusResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public _PollReportStatusResponse Response { get; set; }

        public class _PollReportStatusResponse : AppNexusApiBaseResponse
        {
            private static Dictionary<int, string> _dics = typeof(ReportStatus).ToDictionary();

            [JsonProperty("report")]
            public ReportDetail ReportInfo { get; set; }

            /// <summary>
            /// when the value becomes 'ready', it means that the report is ready fro download
            /// </summary>
            [JsonProperty("execution_status")]
            public string ExecutionStatus { get; set; }

            public ReportStatus ReportStatus
            {
                get
                {
                    if (string.IsNullOrWhiteSpace(this.ExecutionStatus))
                        return ReportStatus.UnKnown;

                    foreach (var s in _dics)
                    {
                        if (s.Value == this.ExecutionStatus)
                            return (ReportStatus)s.Key;
                    }

                    return ReportStatus.UnKnown;
                }
            }

            public int _was_this_status_cached_ { get; set; }
        }

        public class ReportDetail
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("id")]
            public string Id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("created_on")]
            public string CreatedOn { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("cache_hit")]
            public bool CacheHit { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("fact_cache_hit")]
            public bool FactCacheHit { get; set; }

            [JsonProperty("fact_cache_error")]
            public string FactCacheError { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("json_request")]
            public string JsonRequest { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("header_info")]
            public string HeaderInfo { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("report_size")]
            public long? ReportSize { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("row_count")]
            public long? RowCount { get; set; }

            /// <summary>
            /// The report file url.
            /// <para>e.g. report-download?id=ca9955709eade9a0e89f5cda5345c12r</para>
            /// </summary>
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("user_id")]
            public long? UserId { get; set; }

            /// <summary>
            /// e.g. http://10.3.113.19:8080//20170316/b930b4521446ddf1586c08ade095208f.csv
            /// </summary>
            [JsonProperty("file")]
            public string File { get; set; }
        }
    }
}