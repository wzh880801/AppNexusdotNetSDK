using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    /// <summary>
    /// The status of the file
    /// </summary>
    public enum SplitStatus : int
    {

        /// <summary>
        /// File location has not been requested within the last 4 hours
        /// </summary>
        [EnumDescription("new")]
        New,

        /// <summary>
        /// File location has been requested within the last 4 hours, but the file has not been downloaded
        /// </summary>
        [EnumDescription("pending")]
        Pending,

        /// <summary>
        /// File is being downloaded
        /// </summary>
        [EnumDescription("in_progress")]
        InProgress,

        /// <summary>
        /// File has been downloaded successfully within the last 4 hours
        /// </summary>
        [EnumDescription("completed")]
        Completed,

        /// <summary>
        /// Location request or file download failed within the last 4 hours.
        /// The "error" status usually indicates that connection or timeout issues caused the file download to fail. AppNexus gives you 20 minutes to download a single file. If your connection is slow and you exceed this limit, the download will fail. The timeout interval on your end can cause problems as well, especially if your timeout interval is less than 20 minutes. 
        /// When you receive this status for a file, we recommend requesting a new download location(step 2) and downloading the file again(step 3). If the download continues to fail, please submit a support request.
        /// </summary>
        [EnumDescription("error")]
        Error
    }
}