using System;
using SimpleWebRequestHelper.Entity;
using SimpleWebRequestHelper.Enum;

namespace Westwin.AppNexus.Api.Entity
{
    public abstract class AppNexusBaseResponse : SimpleWebResponse
    {
        public override ResponseType ResponseType
        {
            get
            {
                return ResponseType.JSON;
            }
        }
    }
}