using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class GetSiphonRequest : AppNexusBaseRequest<GetSiphonResponse>
    {
        private static Dictionary<int, string> _dics = typeof(LogFeedType).ToDictionary();

        public override string ApiUrl
        {
            get
            {
                var api = string.Format("https://{0}/siphon", this.Host);
                if (SiphonType.HasValue && UpdateSince.HasValue)
                {
                    api = string.Format("{0}?siphon_name={1}&updated_since={2:yyyy_MM_dd_HH}",
                          api,
                          _dics[(int)this.SiphonType.Value],
                          UpdateSince.Value);
                }
                else if (SiphonType.HasValue)
                {
                    api = string.Format("{0}?siphon_name={1}", api, _dics[(int)SiphonType.Value]);
                }
                else if (Hour.HasValue)
                {
                    api = string.Format("{0}?hour={1:yyyy_MM_dd_HH}", api, Hour.Value);
                }
                return api;
            }
        }

        public override string QueryString
        {
            get
            {
                return null;
            }
        }

        public LogFeedType? SiphonType { get; set; }
        public DateTime? Hour { get; set; }
        public DateTime? UpdateSince = null;

        public GetSiphonRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.GET;
        }

        public GetSiphonRequest(LogFeedType siphonType)
            : this()
        {
            this.SiphonType = siphonType;
        }

        public GetSiphonRequest(DateTime hour)
            : this()
        {
            this.Hour = hour;
        }

        /// <summary>
        /// To filter only by hours of data that have been updated since the last time you polled the API for updates, you can use the "updated_since" filter. 
        /// Place a timestamp in the format of updated_since=YYYY_MM_DD_HH (in UTC) in the query string of the call. 
        /// </summary>
        /// <param name="siphonType"></param>
        /// <param name="updateSinceInUtc">Note that this filter will compare against the timestamp field and not the hour field</param>
        public GetSiphonRequest(LogFeedType siphonType, DateTime updateSinceInUtc)
            : this()
        {
            this.SiphonType = siphonType;
            this.UpdateSince = updateSinceInUtc;
        }
    }
}