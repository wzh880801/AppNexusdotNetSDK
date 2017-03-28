using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportStatus : int
    {
        [EnumDescription("ready")]
        Completed,

        [EnumDescription("pending")]
        Pending,

        UnKnown
    }
}