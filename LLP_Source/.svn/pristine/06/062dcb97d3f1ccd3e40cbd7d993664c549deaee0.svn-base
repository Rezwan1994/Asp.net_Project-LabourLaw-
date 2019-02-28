using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LLP.Framework
{
    public static class DateTimeExtension
    {
        public static DateTime ClientToUTCTime(this DateTime datetime)
        {
            var CurrentTimeZone = "";
            var CurrentDate = "";
            var CurrentTime = "";
            TimeZoneInfo currentTimeZone = TimeZoneInfo.Local;
            var CookieCurrentUser = HttpContext.Current.Request.Cookies[CookieKeys.CurrentUser].Value;
            if (CookieCurrentUser != null)
            {
                string[] splitCurrentUser = CookieCurrentUser.Split('&');
                CurrentTimeZone = splitCurrentUser[0];
                CurrentDate = splitCurrentUser[1];
                CurrentTime = splitCurrentUser[2];
                var TimeZoneId = currentTimeZone.Id;
                currentTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId);
            }
            if(datetime.Kind != DateTimeKind.Utc)
            {
                string[] splitCurrentTime = CurrentTime.Split('=');
                CurrentTime = splitCurrentTime[1];
                var ExactDateTime = datetime.Date.ToString("MM/dd/yyyy") + " " + CurrentTime;
                DateTime EDateTime = Convert.ToDateTime(ExactDateTime);
                datetime = TimeZoneInfo.ConvertTimeToUtc(EDateTime, currentTimeZone);
            }
            else
            {
                datetime = TimeZoneInfo.ConvertTimeToUtc(datetime, currentTimeZone);
            }
            return datetime;
        }

        public static DateTime UTCToClientTime(this DateTime datetime)
        {
            var CurrentTimeZone = "";
            var CurrentDate = "";
            var CurrentTime = "";
            TimeZoneInfo currentTimeZone = TimeZoneInfo.Local;
            var CookieCurrentUser = HttpContext.Current.Request.Cookies[CookieKeys.CurrentUser].Value;
            if (CookieCurrentUser != null)
            {
                string[] splitCurrentUser = CookieCurrentUser.Split('&');
                CurrentTimeZone = splitCurrentUser[0];
                CurrentDate = splitCurrentUser[1];
                CurrentTime = splitCurrentUser[2];
                var TimeZoneId = currentTimeZone.Id;
                currentTimeZone = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId);
            }
            if(datetime.Kind == DateTimeKind.Utc)
            {
                datetime = TimeZoneInfo.ConvertTimeFromUtc(datetime, currentTimeZone);
            }
            return datetime;
        }
    }
}
