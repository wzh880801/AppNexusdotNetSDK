using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportingDecimalType : int
    {
        [EnumDescription("comma")]
        Comma,

        [EnumDescription("period")]
        Decimal
    }
}