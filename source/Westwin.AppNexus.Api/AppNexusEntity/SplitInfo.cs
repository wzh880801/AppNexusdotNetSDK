using System;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class SplitInfo
    {
        private static Dictionary<int, string> _dics = typeof(SplitStatus).ToDictionary();

        /// <summary>
        /// The status of the file. Please note that status reflects the download activity only for the last 4 hours. 
        /// </summary>
        public SplitStatus Status { get; set; } = SplitStatus.New;

        [JsonProperty("status")]
        internal string _SplitStatus
        {
            get
            {
                return _dics[(int)this.Status];
            }
            set
            {
                foreach(var c in _dics)
                {
                    if (c.Value == value)
                    {
                        this.Status = (SplitStatus)c.Key;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// The MD5 checksum of the file. 
        /// After you download the file, you can calculate the MD5 checksum on your end and check it against our checksum; 
        /// if they do not match, then an error may have occurred during download and you should try again.
        /// </summary>
        [JsonProperty("checksum")]
        public string CheckSum { get; set; }

        /// <summary>
        /// Part number
        /// </summary>
        [JsonProperty("part")]
        public int PartNumber { get; set; }
    }
}