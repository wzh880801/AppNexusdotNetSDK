using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class AuthenticationResponse : AppNexusBaseResponse
    {
        [JsonProperty("response")]
        public AuthResponse Response { get; set; }

        public class AuthResponse : AppNexusApiBaseResponse
        {
            [JsonProperty("token")]
            public string Token { get; set; }

            public AuthResponse()
                : base()
            {
                this._refreshTime = DateTime.Now;
            }

            private DateTime _refreshTime = DateTime.Now;

            public DateTime ExpiresTime
            {
                get
                {
                    return _refreshTime.AddHours(2);
                }
            }

            public DateTime ViolenceExpiresTime
            {
                get
                {
                    return this._refreshTime.AddHours(24);
                }
            }
        }
    }
}