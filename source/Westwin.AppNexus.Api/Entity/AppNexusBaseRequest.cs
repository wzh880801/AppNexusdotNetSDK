using System;
using SimpleWebRequestHelper.Entity;
using SimpleWebRequestHelper.Enum;

namespace Westwin.AppNexus.Api.Entity
{
    public abstract class AppNexusBaseRequest<T> : SimpleWebRequest<T>
        where T : AppNexusBaseResponse
    {
        public AppNexusBaseRequest() 
            : base()
        {
            
        }

        private ContentTypes _contentType = ContentTypes.JSON;
        public override ContentTypes ContentType
        {
            get
            {
                return _contentType;
            }

            set
            {
                _contentType = value;
            }
        }

        public virtual string Host { get; set; }

        public virtual string AuthorizationToken
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (!this.Headers.ContainsKey("Authorization"))
                        this.Headers.Add("Authorization", value);
                    else
                        this.Headers["Authorization"] = value;
                }
            }
        }
    }
}