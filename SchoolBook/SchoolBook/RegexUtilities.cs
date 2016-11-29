using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SchoolBook
{
    public class RegexUtilities
    {
        bool invalid = false;

        public bool IsValid(string strIn, string type)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                if (type.CompareTo("email") == 0)
                {
                    return Regex.IsMatch(strIn,
                          @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                          @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                          RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                else if (type.CompareTo("password") == 0)
                {
                    return Regex.IsMatch(strIn,
                          @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$",
                          RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                else if (type.CompareTo("time") == 0)
                {
                    return Regex.IsMatch(strIn,
                          @"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$",
                          RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                else
                {
                    return false;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}