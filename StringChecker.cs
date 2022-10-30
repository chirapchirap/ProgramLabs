using ProgramLabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class StringChecker
    {
        public static void check_str_two_regex(string sCopy2)
        {

            if (Regex.IsMatch(sCopy2, pattern_phone_number, RegexOptions.IgnoreCase))
            {
                throw new ValidationException("The second string is phone number.");
            }

            else if (Regex.IsMatch(sCopy2, pattern_email, RegexOptions.IgnoreCase))
            {
                throw new ValidationException("The second string is email.");
            }

            else if (Regex.IsMatch(sCopy2, pattern_ip, RegexOptions.IgnoreCase))
            {
                throw new ValidationException("The second string is IP adress.");
            }

            else
            {
                throw new ValidationException("The second string doesn't match with email, ip or phone number.");
            }
        }
        public static void check_str_one_regex(string sCopy1)
        {

            if (Regex.IsMatch(sCopy1, pattern_phone_number, RegexOptions.IgnoreCase))
            {
                throw new ValidationException("The first string is phone number.");
            }
            else if (Regex.IsMatch(sCopy1, pattern_email, RegexOptions.IgnoreCase))
            {
                throw new ValidationException("The first string is email.");
            }
            else if (Regex.IsMatch(sCopy1, pattern_ip, RegexOptions.IgnoreCase))
            {
                throw new ValidationException("The first string is IP adress.");
            }
            else
            {
                throw new ValidationException("The first string doesn't match with email, ip or phone number.");
            }
        }
        public static void check_register_compared_strings(string str_one, string str_two)
        {
            str_one = str_one.Trim();
            str_two = str_two.Trim();
            str_one = str_one.ToLower();
            str_two = str_two.ToLower();
            str_one = str_one.Replace(" ", "");
            str_two = str_two.Replace(" ", "");
            if (str_one.CompareTo(str_two) == 0)
            {
                throw new ValidationException("2) Strings are equal(case-insensitive)");
            }
            else
            {
                throw new ValidationException("2) Strings are not equal(case-insensitive)");
            }
        }
        public static void check_compared_strings(string str_one, string str_two)
        {
            if (str_one.CompareTo(str_two) == 0)
            {
                throw new ValidationException("1) Strings are equal(case-sensitive)");
            }
            else
            {
                throw new ValidationException("1) Strings are not equal(case-sensitive)");
            }
        }
        public static void check_reversed_strings(string str_one, string str_two)
        {
            str_one = new string(str_one.Reverse().ToArray());

            if (str_one.CompareTo(str_two) == 0)
            {
                throw new ValidationException("3) One string is reversed to another");
            }
            else
            {
                throw new ValidationException("3) One string isn't reversed to another");
            }
        }
        private static string pattern_phone_number = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
        private static string pattern_email = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
        private static string pattern_ip = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
    }
}