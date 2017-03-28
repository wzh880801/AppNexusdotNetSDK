using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Entity
{
    public class Creative
    {
        public long id { get; set; }
        public object weight { get; set; }
        public string name { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string format { get; set; }
        public string audit_status { get; set; }
        public bool is_expired { get; set; }
        public bool is_prohibited { get; set; }
        public bool is_self_audited { get; set; }
        public object pop_window_maximize { get; set; }
        public string state { get; set; }
        public object code { get; set; }
    }
}