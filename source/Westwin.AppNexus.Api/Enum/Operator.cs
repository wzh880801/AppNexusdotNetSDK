using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum Operator : int
    {
        [EnumDescription(">=")]
        GreaterOrEqual,

        [EnumDescription("=")]
        Equals,

        [EnumDescription(">")]
        GreaterThan,

        [EnumDescription("<=")]
        LessOrEqual,

        [EnumDescription("<")]
        LessThan,
    }
}