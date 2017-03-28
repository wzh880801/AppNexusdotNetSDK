using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportTimezone : int
    {

        /// <summary>
        /// U.S. Eastern Time -4/-5 UTC depending on daylight savings
        /// </summary>
        [EnumDescription("EST5EDT")]
        EST5EDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("CST6CDT")]
        CST6CDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("MST7MDT")]
        MST7MDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("PST8PDT")]
        PST8PDT,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("CET")]
        CET,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("UTC")]
        UTC,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Apia")]
        PacificApia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Pacific/Honolulu")]
        PacificHonolulu,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Juneau")]
        AmericaJuneau,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Los_Angeles")]
        AmericaLosAngeles,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Denver")]
        AmericaDenver,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Chicago")]
        AmericaChicago,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/New_York")]
        AmericaNewYork,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Halifax")]
        AmericaHalifax,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/South_Georgia")]
        AtlanticSouthGeorgia,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Atlantic/Cape_Verde")]
        AtlanticCapeVerde,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/London")]
        EuropeLondon,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Amsterdam")]
        EuropeAmsterdam,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Berlin")]
        EuropeBerlin,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Helsinki")]
        EuropeHelsinki,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Africa/Cairo")]
        AfricaCairo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Jerusalem")]
        AsiaJerusalem,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Europe/Moscow")]
        EuropeMoscow,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dubai")]
        AsiaDubai,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Indian/Maldives")]
        IndianMaldives,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Dhaka")]
        AsiaDhaka,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Bangkok")]
        AsiaBangkok,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Hong_Kong")]
        AsiaHongKong,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Tokyo")]
        AsiaTokyo,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Australia/Sydney")]
        AustraliaSydney,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("Asia/Magadan")]
        AsiaMagadan,
    }
}