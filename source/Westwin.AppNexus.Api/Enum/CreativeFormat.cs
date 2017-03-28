using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum CreativeFormat : int
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("url-html")]
        UrlHtml,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("url-js")]
        UrlJs,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("flash")]
        Flash,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("image")]
        Image,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("raw-js")]
        RawJs,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("raw-html")]
        RawHtml,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("iframe-html")]
        IframeHtml,

        /// <summary>
        /// 
        /// </summary>
        [EnumDescription("text")]
        Text,
    }
}