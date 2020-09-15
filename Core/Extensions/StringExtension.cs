using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.Extensions
{
    public static class StringExtension
    {
       
        public static string StripHtml(this string html)
        {
            if (string.IsNullOrWhiteSpace(html))
                return string.Empty;
            string val = Regex.Replace(html, "<.*?>", string.Empty);
            val = val.Trim('\n');
            return val;
        }
        public static bool IsValidEmail(this string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            email = email.Trim();
            var result = Regex.IsMatch(email, "^(?:[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+\\.)*[\\w\\!\\#\\$\\%\\&\\'\\*\\+\\-\\/\\=\\?\\^\\`\\{\\|\\}\\~]+@(?:(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!\\.)){0,61}[a-zA-Z0-9]?\\.)+[a-zA-Z0-9](?:[a-zA-Z0-9\\-](?!$)){0,61}[a-zA-Z0-9]?)|(?:\\[(?:(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\.){3}(?:[01]?\\d{1,2}|2[0-4]\\d|25[0-5])\\]))$", RegexOptions.IgnoreCase);
            return result;
        }
        public static bool IsValidIpAddress(this string ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress))
                return false;
            IPAddress ip;
            return IPAddress.TryParse(ipAddress, out ip);
        }
        public static string UnAccent(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;
            string value = s;
            while (value.Contains("  "))
            {
                value = value.Replace("  ", " ");
            }
            value = value.Trim();
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = value.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public static string TrimAll(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;
            string value = s;
            while (value.Contains("\t"))
            {
                value = value.Replace("\t", " ");
            }
            while (value.Contains("\n"))
            {
                value = value.Replace("\n", " ");
            }
            while (value.Contains("  "))
            {
                value = value.Replace("  ", " ");
            }

            value = value.Trim();
            return value;
        }
        public static string PersonalName(this string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return string.Empty;
            var value = "";
            int flag = 0;

            foreach (var item in name)
            {
                if (flag == 0 || flag == 2)
                {
                    value = value + item.ToString().ToUpper();
                    flag = 1;
                }
                else
                {
                    value = value + item.ToString().ToLower();
                }
                if (item == ' ')
                {
                    flag = 2;
                }
            }
            return value;
        }

        public static object To(this string value, Type type)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return DBNull.Value;
            }
            if (type.IsAssignableFrom(typeof(string)))
            {
                return value;
            }

            if (type.IsAssignableFrom(typeof(int)))
            {
                return Convert.ToInt32(value);
            }
            if (type.IsAssignableFrom(typeof(long)))
            {
                return Convert.ToInt64(value);
            }
            if (type.IsAssignableFrom(typeof(decimal)))
            {
                return Convert.ToDecimal(value);
            }
            if (type.IsAssignableFrom(typeof(float)))
            {
                return Convert.ToSingle(value);
            }
            if (type.IsAssignableFrom(typeof(double)))
            {
                return Convert.ToDouble(value);
            }
            if (type.IsAssignableFrom(typeof(DateTime)))
            {
                return DateTime.ParseExact(value, "yyyy-MM-dd", null);
            }
            if (type.IsAssignableFrom(typeof(byte[])))
            {
                return Encoding.UTF8.GetBytes(value);
            }
            if (type.IsAssignableFrom(typeof(Guid)))
            {
                return Guid.Parse(value);
            }
            if (type.IsAssignableFrom(typeof(TimeSpan)))
            {
                return TimeSpan.Parse(value);
            }
            return Convert.ChangeType(value, type);
        }
    }
}
