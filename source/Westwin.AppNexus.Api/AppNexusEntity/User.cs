using System;
using Newtonsoft.Json;

namespace Westwin.AppNexus.Api.Entity
{
    public class User
    {
        /// <summary>
        /// The internal ID associated with the user. e.g. 203599
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }


        /// <summary>
        /// The user's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }


        /// <summary>
        /// The user's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }


        /// <summary>
        /// The user's contact phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }


        /// <summary>
        /// The login name of the user. Note: After a user is created, the username cannot be changed.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The password used to authenticate the user. Not shown on GET requests.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }


        /// <summary>
        /// The email address of the user.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }


        /// <summary>
        /// The type of user. This field cannot be modified on PUT. To change a user's user_type, you must add a new user.
        /// <para>member: Network-level user with access to all aspects of the member's account (Advertisers, Publishers, Apps, etc.).</para>
        /// <para>member_advertiser: Somewhat limited network-level user with access to a subset of advertisers. No API access by AppNexus policy.</para>
        /// <para>member_publisher: Somewhat limited network-level user with access to a subset of publishers. No API access by AppNexus policy.</para>
        /// <para>advertiser: Very limited user with access to one advertiser (mainly for reporting, available in both the UI and API). You must specify an advertiser_id when you create this user.</para>
        /// <para>publisher: Very limited user with access to one publisher (mainly for reporting, available in both the UI and API). You must specify a publisher_id when you create this user.</para>
        /// <para>bidder: </para>
        /// </summary>
        [JsonProperty("user_type")]
        public string UserType { get; set; }


        /// <summary>
        /// If true, the user is not allowed to make changes via the API.
        /// </summary>
        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }


        /// <summary>
        /// Admin-only. If true, the user can access and use the API.
        /// </summary>
        [JsonProperty("api_login")]
        public bool ApiLogin { get; set; }


        /// <summary>
        /// The ID of the entity (member or bidder) to which the user belongs. Note that the entity_id is the same as the member_id, which is used in other services.
        /// </summary>
        [JsonProperty("entity_id")]
        public long? EntityId { get; set; }


        /// <summary>
        /// The ID of the publisher with which the user is associated, if user_type is "publisher".
        /// </summary>
        [JsonProperty("publisher_id")]
        public long? PublisherId { get; set; }


        /// <summary>
        /// The ID of the advertiser with which the user is associated, if user_type is "advertiser".
        /// </summary>
        [JsonProperty("advertiser_id")]
        public long? AdvertiserId { get; set; }


        /// <summary>
        /// Any information relevant to the user can be entered here.
        /// </summary>
        [JsonProperty("custom_data")]
        public string CustomData { get; set; }


        /// <summary>
        /// If true, the user will receive email notifications when the daily safety budget threshold is approached. For more details, see the daily_budget field on the Member Service.
        /// </summary>
        [JsonProperty("send_safety_budget_notifications")]
        public bool SendSafetyBudgetNotifications { get; set; }


        /// <summary>
        /// The name of the entity (member or bidder) to which the user belongs.
        /// </summary>
        [JsonProperty("entity_name")]
        public string EntityName { get; set; }


        /// <summary>
        /// The user's timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("entity_reporting_decimal_type")]
        public string EntityReportingDecimalType { get; set; }


        /// <summary>
        /// The character used for decimals in reporting. Possible values:
        /// => "comma"
        /// => "decimal" (period)
        /// This setting can be overridden at the report level(see reporting_decimal_type in the Report Service).
        /// </summary>
        [JsonProperty("reporting_decimal_type")]
        public string ReportingDecimalType { get; set; }


        /// <summary>
        /// The character separating the integer part from the fractional part of a number. Possible values:
        /// => "period"
        /// => "comma"
        /// This character must be different than the character used for thousand_separator.
        /// Note: This field controls how the user enters and views numbers in the UI only.It does not affect numbers in the API.
        /// </summary>
        [JsonProperty("decimal_mark")]
        public string DecimalMark { get; set; }


        /// <summary>
        /// The character separating digit groups in a number. Possible values:
        /// => "comma"
        /// => "space"
        /// => "period"
        /// This character must be different than the character used for decimal_mark.
        /// Note: This setting controls how the user enters and views digit groups in the UI only.It does not affect digit groups in the API.
        /// </summary>
        [JsonProperty("thousand_separator")]
        public string ThousandSeparator { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }


        /// <summary>
        /// The date and time when the user was last modified.
        /// </summary>
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }


        /// <summary>
        /// Read-only. This flag gives a user rights to access certain developer-focused services such as the Plugin and Plugin Instance services, which are used by apps. It is set to true by an AppNexus admin on a case-by-case basis.
        /// </summary>
        [JsonProperty("is_developer")]
        public bool IsDeveloper { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("role_id")]
        public object RoleId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }


        /// <summary>
        /// When the user's password expires.
        /// </summary>
        [JsonProperty("password_expires_on")]
        public string PasswordExpiresOn { get; set; }


        /// <summary>
        /// The advertiser(s) that the user can access, if user_type is "member_advertiser".
        /// </summary>
        [JsonProperty("advertiser_access")]
        public object AdvertiserAccess { get; set; }


        /// <summary>
        /// The publisher(s) that the user can access, if user_type is "member_publisher".
        /// </summary>
        [JsonProperty("publisher_access")]
        public object PublisherAccess { get; set; }
    }
}