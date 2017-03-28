using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum FlatfeeStatus : int
    {
        [EnumDescription("pending")]
        Pending,

        [EnumDescription("processing")]
        Processing,

        [EnumDescription("allocated")]
        Allocated,

        [EnumDescription("error")]
        Error
    }
}