using System;
using System.Globalization;

namespace Core.Extensions
{
    public static class DateTimeExtension
    {
        public static int ToInt(this DateTime date)
        {
            return Convert.ToInt32(date.ToString("yyyyMMdd"));
        }
        public static int? ToInt(this DateTime? date)
        {
            if (date == null || !date.HasValue)
                return null;
            return date.Value.ToInt();
        }
        public static int? WeekOfYear(this DateTime? date)
        {
            if (date == null || !date.HasValue)
                return null;
            return date.Value.WeekOfYear();
        }
        public static int WeekOfYear(this DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
        public static bool HasDate(this int value)
        {
            DateTime date;
            return DateTime.TryParseExact(value.ToString(), "yyyyMMdd", null, DateTimeStyles.None, out date);
        }


        public static DateTime? ToDateTime(this int value)
        {
            if (value.HasDate())
            {
                try
                {
                    return DateTime.ParseExact(value.ToString(), "yyyyMMdd", null);
                }
                catch (FormatException)
                {
                    return null;
                }
            }
            return null;
        }
        public static int ToTimestamp(this DateTime dateTime)
        {
            TimeSpan span = (dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return unchecked((int)span.TotalSeconds);
        }
        public static int? ToTimestamp(this DateTime? dateTime)
        {
            if (dateTime == null)
                return null;
            TimeSpan span = (dateTime.Value - new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return unchecked((int)span.TotalSeconds);
        }
        public static DateTime IntToDateTime(this int TimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(TimeStamp);
            return dtDateTime;
        }
        public static DateTime? IntToDateTime(this int? TimeStamp)
        {
            if (TimeStamp == null)
                return null;
            // DateTimeOffset localTime = new DateTimeOffset()
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddSeconds(TimeStamp.Value);
            return dtDateTime;
        }
        public static string ToString(this DateTime? value, string format)
        {
            if (value == null)
                return "";
            return value.Value.ToString(format);
        }
        public static DateTime FirstDateOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }
        public static DateTime LastDateOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1).AddMonths(1).AddDays(-1);
        }
    }
}
