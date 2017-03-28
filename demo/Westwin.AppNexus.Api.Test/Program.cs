using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWebRequestHelper;
using Westwin.AppNexus.Api.Entity;
using System.IO;

namespace Westwin.AppNexus.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Report.SiteDomainPerformanceReportRequest
            {
                AdvertiserId = 1609099,
                Columns = new SiteDomainPerformanceReportColumn[]
                {
                    SiteDomainPerformanceReportColumn.Day,
                    SiteDomainPerformanceReportColumn.SiteDomain,
                    SiteDomainPerformanceReportColumn.Imps,
                    SiteDomainPerformanceReportColumn.Clicks,
                    SiteDomainPerformanceReportColumn.Cpm,
                    SiteDomainPerformanceReportColumn.CpmBuyingCurrency,
                    SiteDomainPerformanceReportColumn.AdvertiserId,
                    SiteDomainPerformanceReportColumn.AdvertiserName,
                    SiteDomainPerformanceReportColumn.AdvertiserCode,
                    SiteDomainPerformanceReportColumn.AdvertiserCurrency,
                    SiteDomainPerformanceReportColumn.BuyerMemberId,
                    SiteDomainPerformanceReportColumn.BuyerMemberName,
                    SiteDomainPerformanceReportColumn.BuyingCurrency,
                    SiteDomainPerformanceReportColumn.DealId,
                    SiteDomainPerformanceReportColumn.DealCode,
                    SiteDomainPerformanceReportColumn.DealName,
                    SiteDomainPerformanceReportColumn.Ctr
                },
                Format = ReportFormat.CSV,
                //Emails = new List<string>() { "zhongwang@westwin.com" },
                EscapeFields = false,
                Orders = new Report.ReportOrderBy[]
                {
                        new Report.ReportOrderBy
                        {
                            OrderBy = "day",
                            Direction = OrderDirection.ASC
                        },
                        new Report.ReportOrderBy
                        {
                            OrderBy = "imps",
                            Direction = OrderDirection.DESC
                        }
                },
                ReportInterval = ReportInterval.Custom,
                ReportStartDate = new DateTime(2017, 3, 13),
                ReportEndDate = new DateTime(2017, 3, 17),
                ReportingDecimalType = ReportingDecimalType.Decimal,
                TimeZone = ReportTimezone.AsiaHongKong,
                //Filters = new Report.ReportFilter[]
                //{
                //    new Report.ReportFilter
                //    {
                //        Name = "gender",
                //        Value = "male"
                //    },
                //    new Report.ReportFilter
                //    {
                //        Name = "day",
                //        Value = 20
                //    }
                //},
                //GroupFilters = new Report.ReportGroupFilter[]
                //{
                //    new Report.ReportGroupFilter
                //    {
                //        Name = "imps",
                //        Value = 1000,
                //        Operaor = Operator.LessThan
                //    }
                //}
            };
            var sr = new SubmitReportRequest
            {
                ReportRequest = r,
            };

            //replace username & password with yours
            using (var _client = new PremiumAppNexusApiClient("username", "password"))
            {
                _client.AcquireTokenByUserName += AcquireTokenByUserName;
                _client.TokenRefreshedCallback += TokenRefreshedCallback;
                _client.TokenGrantedCallback += TokenGrantedCallback;

                var response = _client.Execute(sr);
                if (response == null || response.Response == null)
                {
                    Console.WriteLine("network communication error");
                    return;
                }
                if (response.Response.Status != "OK")
                {
                    Console.WriteLine("submit report error: {0}", response.Response.ErrorMessage);
                }

                File.WriteAllText(response.GetType().Name + ".json", Encoding.UTF8.GetString(Convert.FromBase64String(response.ResponseBase64String)));

                Console.WriteLine("report id: {0}", response.Response.ReportId);

                var url = "";
                while (true)
                {
                    var pollRequest = new PollReportStatusRequest(response.Response.ReportId);
                    var pollResponse = _client.Execute(pollRequest);
                    if (pollResponse.Response.ExecutionStatus == "ready")
                    {
                        url = pollResponse.Response.ReportInfo.Url;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(url))
                {
                    Console.WriteLine("url is null");
                    return;
                }

                var downloadRequest = new DownloadReportFileRequest(url);
                var downloadResponse = _client.ExecuteDownload(downloadRequest, @"d:\123.csv");
                if (downloadResponse.Success)
                {
                    Console.WriteLine("File was downloaded at {0}", downloadResponse.ReportFilePath);
                }
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void TokenGrantedCallback(string username, string newToken)
        {
            Console.WriteLine("User {0} 's token was successfully granted. Token: {1}", username, newToken);

            TokenHelper.UpdateToken(new Token
            {
                UserName = username,
                AuthenticationToken = newToken,
                ExpiresTime = DateTime.Now.AddHours(2).AddMinutes(-5)
            });
        }

        private static void TokenRefreshedCallback(string username, string oldToken, string newToken)
        {
            Console.WriteLine("User {0} 's token was successfully refreshed. New Token: {1}", username, newToken);

            TokenHelper.UpdateToken(new Token
            {
                UserName = username,
                AuthenticationToken = newToken,
                ExpiresTime = DateTime.Now.AddHours(2).AddMinutes(-5)
            });
        }

        private static string AcquireTokenByUserName(string username)
        {
            var token = TokenHelper.ReadToken();
            if (token == null || string.IsNullOrWhiteSpace(token.AuthenticationToken))
            {
                return "hbapi:203599:58c272f34c5e3:nym2";
            }
            return token.AuthenticationToken;
        }
    }
}