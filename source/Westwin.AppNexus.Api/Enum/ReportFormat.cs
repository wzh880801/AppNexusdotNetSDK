using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportFormat : int
    {
        [EnumDescription("csv")]
        CSV,

        [EnumDescription("excel")]
        EXCEL,

        [EnumDescription("html")]
        HTML,

        [EnumDescription("xlsx")]
        XLSX
    }
}