using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum OrderDirection : int
    {
        [EnumDescription("ASC")]
        ASC,

        [EnumDescription("DESC")]
        DESC
    }
}