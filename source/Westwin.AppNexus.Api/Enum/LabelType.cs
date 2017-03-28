using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// 
    /// </summary>
    public enum LabelType : int
    {
        [EnumDescription("Trafficker")]
        Trafficker,

        [EnumDescription("Sales Rep")]
        SalesRep,

        [EnumDescription("Campaign Type")]
        CampaignType
    }
}