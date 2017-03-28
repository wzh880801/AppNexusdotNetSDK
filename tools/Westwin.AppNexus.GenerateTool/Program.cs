using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Westwin.AppNexus.GenerateTool
{
    class Program
    {
        static string _appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        static void Main(string[] args)
        {
            var file = Path.Combine(_appPath, "GetReportMetadataResponse.json");
            var json = File.ReadAllText(file);

            var report = JsonConvert.DeserializeObject<ReportMeta>(json);

            var meta = report.response.meta;
            var metaType = meta.GetType();
            var reports = metaType.GetProperties();

            List<string> _reportTypes = new List<string>();

            foreach(var reportPro in reports)
            {
                Console.WriteLine(reportPro.Name);
                _reportTypes.Add(reportPro.Name);

                var _reportType = Parse(reportPro.Name);

                //BuyerInvoiceReportRequest
                var _reportRequestName = _reportType + (_reportType.EndsWith("eport") ? "Request" : "ReportRequest");
                var _reportColumnEnumName = _reportType + (_reportType.EndsWith("eport") ? "Column" : "ReportColumn");

                string time_granularity = null;
                ReportMeta.Column[] columns = null;
                string[] label_fields = null;
                ReportMeta.Filter[] filters = null;
                ReportMeta.Having[] havings = null;
                string[] time_intervals = null;

                var _report = reportPro.GetValue(meta);
                if (_report == null)
                    Console.Read();

                var ps = reportPro.PropertyType.GetProperties();
                foreach(var p in ps)
                {
                    if(p.Name == "time_granularity")
                    {
                        time_granularity = p.GetValue(_report).ToString();
                    }
                    if(p.Name == "columns")
                    {
                        columns = p.GetValue(_report) as ReportMeta.Column[];
                    }
                    if(p.Name== "label_fields")
                    {
                        label_fields = p.GetValue(_report) as string[];
                    }
                    if(p.Name== "filters")
                    {
                        filters = p.GetValue(_report) as ReportMeta.Filter[];
                    }
                    if (p.Name == "havings")
                    {
                        havings = p.GetValue(_report) as ReportMeta.Having[];
                    }
                    if(p.Name== "time_intervals")
                    {
                        time_intervals = p.GetValue(_report) as string[];
                    }
                }

                BuildReportColumnEnumFile(_reportColumnEnumName, columns, havings);
                BuildReportRequestFile(_reportType, _reportRequestName, _reportColumnEnumName, time_granularity, filters, time_intervals);

                //Console.WriteLine(JsonConvert.SerializeObject(_report));
                //Console.ReadLine();
            }

            //Console.ReadLine();

            //Build ReportTypes
            BuildReportTypeEnumFile(_reportTypes);
        }

        /// <summary>
        /// network_performance_report => NetworkPerformanceReport
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static string Parse(string name)
        {
            var array = name.Split('_');
            var s = "";
            foreach (var _s in array)
            {
                var a = _s.Substring(0, 1).ToUpper();
                long l;
                if (long.TryParse(a, out l))
                    s += "C" + a + _s.Substring(1, _s.Length - 1);
                else
                    s += a + _s.Substring(1, _s.Length - 1);
            }
            return s;
        }

        static void BuildReportTypeEnumFile(List<string> _reportTypes)
        {
            var _reportTypeEnumFile = Path.Combine(_appPath, "ReportType.cs");
            var cs =
@"using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{
    public enum ReportType : int
    {";

            foreach (var _type in _reportTypes)
            {
                cs +=
@"
        /// <summary>
        /// 
        /// </summary>
        [EnumDescription(""" + _type + @""")]
        " + Parse(_type) + @",";
            }

            cs += @"
    }
}";

            File.WriteAllText(_reportTypeEnumFile, cs, Encoding.UTF8);
        }

        static void BuildReportRequestFile(string reportType, string reportRequestName, string reportColumnEnumName, 
            string time_granularity, ReportMeta.Filter[] filters, string[] time_intervals)
        {
            var reportRequestFile = Path.Combine(_appPath, "report_request", reportRequestName + ".cs");
            var file = new FileInfo(reportRequestFile);
            if (!file.Directory.Exists)
                file.Directory.Create();

            var cs =
@"using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{";

            cs += @"
    public class " + reportRequestName + @" : ReportRequest";

            cs += @"
    {";

            cs += @"
        public override ReportType ReportType
        {
            get
            {
                return ReportType." + reportType + @";
            }
        }";

            cs += @"

        public " + reportColumnEnumName + @"[] Columns { get; set; }";

            var _filters = string.Join(",", (from f in filters select "\"" + f.column + "\""));

            cs += @"

        public override string[] AcceptFilters
        {
            get
            {
                return new string[]{ " + _filters + @" };
            }
        }";

            cs += @"

        public override TimeGranularity AcceptTimeGranularity
        {
            get
            {
                return TimeGranularity." + Parse(time_granularity) + @";
            }
        }";

            var _intervals = time_intervals != null && time_intervals.Length > 0 ?
                string.Join(",", (from i in time_intervals select "\"" + i + "\"")) : "\"custom\"";

            cs += @"

        private static string[] _intervals = new string[] { " + _intervals + @" };";

            cs += @"

        public override ReportInterval[] AcceptTimeIntervals
        {
            get
            {
                return _ParseIntervals(_intervals);
            }
        }";

            cs += @"

        private static Dictionary<int, string> _reportColumns = typeof(" + reportColumnEnumName + @").ToDictionary();";

            cs += @"

        internal override string GetColumns()
        {
            return _GetColumns(_reportColumns, this.Columns);
        }";

            cs += @"
    }
}";

            File.WriteAllText(reportRequestFile, cs, Encoding.UTF8);
        }

        static void BuildReportColumnEnumFile(string reportColumnEnumName, ReportMeta.Column[] columns, ReportMeta.Having[] havings)
        {
            var reportColumnEnumFile = Path.Combine(_appPath, "report_column_enum", reportColumnEnumName + ".cs");
            var file = new FileInfo(reportColumnEnumFile);
            if (!file.Directory.Exists)
                file.Directory.Create();

            var cs =
@"using System;
using SimpleWebRequestHelper;

namespace Westwin.AppNexus.Api
{";

            cs += @"
    public enum " + reportColumnEnumName + @" : int
    {";

            string[] _havings = havings == null || havings.Length == 0 ? null : (from n in havings select n.column).ToArray();
            foreach (var c in columns)
            {
                cs += @"
        /// <summary>
        /// Type is " + c.type + @". This column is " + (_havings != null && _havings.Length > 0 && _havings.Contains(c.column) ? "in havings" : "not in havings") + @"
        /// </summary>
        [EnumDescription(""" + c.column + @""")]
        " + Parse(c.column) + @",
";
            }

            cs += @"
    }
}";

            File.WriteAllText(reportColumnEnumFile, cs, Encoding.UTF8);
        }
    }
}