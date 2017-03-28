using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public abstract class AppNexusApiBaseResponse
    {
        /// <summary>
        /// e.g. SYSTEM、NOAUTH
        /// </summary>
        [JsonProperty("error_id")]
        public virtual string ErrorId { get; set; }

        /// <summary>
        /// e.g. Invalid parameters
        /// </summary>
        [JsonProperty("error")]
        public virtual string ErrorMessage { get; set; }

        /// <summary>
        /// e.g. rate limit has been exceeded
        /// </summary>
        [JsonProperty("error_description")]
        public virtual string ErrorDescription { get; set; }

        [JsonProperty("service")]
        public virtual string Service { get; set; }

        [JsonProperty("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// e.g. RATE_EXCEEDED
        /// </summary>
        [JsonProperty("error_code")]
        public virtual string ErrorCode { get; set; }

        [JsonProperty("dbg_info")]
        public virtual DbgInfo DbgInfo { get; set; }

        private string _status = "error";

        [JsonProperty("status")]
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("start_element")]
        public int? StartElement { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("num_elements")]
        public int? NumElements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}