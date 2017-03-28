using System;
using System.Linq;
using System.Collections.Generic;
using SimpleWebRequestHelper.Helper;

namespace Westwin.AppNexus.Api.Report
{
    public abstract class ReportRequest
    {
        public static Dictionary<int, string> ReportIntervalDic = typeof(ReportInterval).ToDictionary();

        /// <summary>
        /// Required - This determines which information will be returned. 
        /// </summary>
        public abstract ReportType ReportType { get; }

        /// <summary>
        /// Optional - This determines which timezone the data will be reported in. 
        /// </summary>
        public virtual ReportTimezone TimeZone { get; set; }

        /// <summary>
        /// The start date for the report.
        /// <para>For report types that offer hourly data, this must be formatted as "YYYY-MM-DD HH:MM:SS". However, note that MM:SS must be 00:00, as data is not available for minutes and seconds.</para>
        /// <para>For report types that do not offer hourly data, this must be formatted as "YYYY-MM-DD".</para>
        /// </summary>
        public virtual DateTime ReportStartDate { get; set; }

        /// <summary>
        /// The end date for the report.
        /// The end_date is non-inclusive. For example, if you start a report at "2012:07:01 00:00:00" and end the report at "2012:07:01 23:00:00", your report will not include data from the last hour of the day. The correct way to retrieve this data would be to end the report at "2012:07:02 00:00:00".
        /// <para>For report types that offer hourly data, this must be formatted as "YYYY-MM-DD HH:MM:SS". However, MM:SS must be 00:00, as data is not available for minutes and seconds. For example, "2012:07:01 00:00:00" to "2012:07:02 00:00:00" would retrieve an entire day's data.</para>
        /// <para>For reports aggregated across intervals longer than hourly (e.g., daily, weekly, etc.), the format must be "YYYY-MM-DD". For example, "2012:07:01" to "2012:07:02" would retrieve an entire day's data.</para>
        /// </summary>
        public virtual DateTime ReportEndDate { get; set; }

        public virtual ReportFormat Format { get; set; }

        /// <summary>
        /// If this field is passed, it overrides any reporting decimal preferences set at the user and member levels.
        /// </summary>
        public virtual ReportingDecimalType ReportingDecimalType { get; set; }

        /// <summary>
        /// When true, it adds quotes around each field in the report output to allow for safer import into Excel. This only applies to CSV and tab-delimited reports.
        /// </summary>
        public virtual bool EscapeFields { get; set; }

        /// <summary>
        /// The list of email addresses to which the reporting data will be sent. The reporting data is sent as an attachment, and the body of the email contains the information below.
        /// Report type | Member, Advertiser, or Publisher name and ID | Run date | Start date | End date | Timezone | User who generated the report
        /// <para>Report results larger than 15 MB will not be emailed. See Reporting Best Practices for ways to prevent results from being too large.</para>
        /// </summary>
        public virtual List<string> Emails { get; set; }

        /// <summary>
        /// The time range for the report. Not all reports accept all intervals. See each report's documentation and metadata for details. 
        /// </summary>
        public virtual ReportInterval ReportInterval { get; set; }

        /// <summary>
        /// The list of columns to sort by
        /// <para>JSON example: [{"order_by":"day", "direction":"ASC"},{"order_by":"imps", "direction":"DESC"}]</para>
        /// </summary>
        public virtual ReportOrderBy[] Orders { get; set; }

        /// <summary>
        /// The list of filter objects to apply to the report.
        /// <para>JSON example: [{"geo_country":"US"}]</para>
        /// </summary>
        public virtual ReportFilter[] Filters { get; set; }

        /// <summary>
        /// Allows you to specify an operation to perform on one or more filters. For example, if you're selecting total impressions grouped by campaign, you can use this field to filter out campaigns that don't have at least 10,000 impressions:
        /// <para>JSON example: {
        ///                         "group_filters": [
        ///                             {
        ///                             "imps": {
        ///                                 "value": 10000,
        ///                                 "operator": ">="
        ///                                 }
        ///                             }
        ///                         ]
        ///                      }</para>
        /// </summary>
        public virtual ReportGroupFilter[] GroupFilters { get; set; }

        /// <summary>
        /// The <see cref="TimeGranularity"/> that the specified type of report could accept
        /// </summary>
        public abstract TimeGranularity AcceptTimeGranularity { get; }

        /// <summary>
        /// The <see cref="ReportInterval"/> array that the specified type of report could accept
        /// </summary>
        public abstract ReportInterval[] AcceptTimeIntervals { get; }

        /// <summary>
        /// The filters that the specified type of report could accept
        /// </summary>
        public abstract string[] AcceptFilters { get; }

        internal abstract string GetColumns();

        public ReportRequest()
        {
            //default values
            this.TimeZone = ReportTimezone.EST5EDT;
            this.Format = ReportFormat.CSV;
            this.ReportingDecimalType = ReportingDecimalType.Comma;
            this.EscapeFields = false;
        }

        internal virtual string GetFilters()
        {
            if (this.Filters != null && this.Filters.Length > 0)
            {
                var filters = "";
                foreach (var _filter in this.Filters)
                {
                    if (!this.AcceptFilters.Contains(_filter.Name))
                        throw new Exception(string.Format("report '{0}' does not support filter : '{1}'", this.GetType().Name, _filter.Name));

                    filters += string.Format("{0},", _filter.ToString());
                }
                return string.Format("\r\n\t\"filters\": [{0}],", filters.TrimEnd(','));
            }

            return "";
        }

        internal virtual string GetGroupFilters()
        {
            if (this.GroupFilters != null && this.GroupFilters.Length > 0)
            {
                var filters = "";
                foreach (var _filter in this.GroupFilters)
                {
                    //if (!this.AcceptFilters.Contains(_filter.Name))
                    //throw new Exception(string.Format("report '{0}' does not support filter : '{1}'", this.GetType().Name, _filter.Name));

                    filters += string.Format("{0},", _filter.ToString());
                }
                return string.Format("\r\n\t\"group_filters\": [{0}],", filters.TrimEnd(','));
            }

            return "";
        }

        internal virtual string GetOrderBys()
        {
            if (this.Orders != null && this.Orders.Length > 0)
            {
                var orders = "";
                foreach (var _order in this.Orders)
                {
                    orders += string.Format("{0},", _order.ToString());
                }
                return string.Format("\r\n\t\"orders\": [{0}],", orders.TrimEnd(','));
            }

            return "";
        }

        internal virtual string GetEmails()
        {
            if (this.Emails != null && this.Emails.Count > 0)
            {
                var email = "";
                foreach (var e in this.Emails)
                {
                    email += string.Format("\"{0}\",", e);
                }
                return string.Format("\r\n\t\"emails\":[{0}],", email.TrimEnd(','));
            }

            return "";
        }

        internal string _GetColumns(Dictionary<int, string> _reportColumnDic, dynamic _columns)
        {
            if (_columns == null || _columns.Length == 0)
                throw new Exception("Columns can not be null! Report type is " + this.ReportType);

            var columns = "";
            for (int i = 0; i < _columns.Length; i++)
            {
                if (i == _columns.Length - 1)
                    columns += string.Format("\"{0}\"", _reportColumnDic[(int)_columns[i]]);
                else
                    columns += string.Format("\"{0}\",", _reportColumnDic[(int)_columns[i]]);
            }

            return columns;
        }

        internal ReportInterval[] _ParseIntervals(string[] acceptIntervals)
        {
            return (from n in ReportIntervalDic
                    where acceptIntervals.Contains(n.Value)
                    select (ReportInterval)n.Key)
                        .ToArray();
        }

        public long? AdvertiserId { get; set; }

        public long? PublisherId { get; set; }
    }
}