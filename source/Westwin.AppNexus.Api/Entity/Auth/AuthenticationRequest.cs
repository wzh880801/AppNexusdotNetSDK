using System;
using Newtonsoft.Json;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    /// <summary>
    /// Before you can make calls to any AppNexus API service or report, you must use your username and password to get an authorization token. 
    /// The token remains active for 2 hours, during which you do not need to re-authenticate. 
    /// Furthermore, there is a 24 hour hard expiry. When an API session reaches the 24 hour mark, regardless of when the most recent API call was made, that session will expire.
    /// </summary>
    public class AuthenticationRequest : AppNexusBaseRequest<AuthenticationResponse>
    {
        public override string ApiUrl
        {
            get
            {
                return string.Format("https://{0}/auth", this.Host);
            }
        }

        public override string QueryString
        {
            get
            {
                return SerializationHelper.SerializeObjectToJson(new _AuthProfile
                {
                    AuthProfile = new AuthenticationProfile
                    {
                        UserName = this.UserName,
                        Password = this.Password
                    }
                });
            }
        }

        public override string AuthorizationToken
        {
            set
            {
                //do nothing
            }
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public AuthenticationRequest()
            : base()
        {
            this.HttpMethod = SimpleWebRequestHelper.Enum.HttpMethods.POST;
        }

        public AuthenticationRequest(string username, string password)
            : this()
        {
            this.UserName = username;
            this.Password = password;
        }

        internal class _AuthProfile
        {
            [JsonProperty("auth")]
            public AuthenticationProfile AuthProfile { get; set; }
        }
    }

    internal class AuthenticationProfile
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}