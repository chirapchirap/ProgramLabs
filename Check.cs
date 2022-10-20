using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LABS
{
    class Check
    {
        public static bool check_date()
        {
            if (!DateTime.TryParse(Values.input_date_str, out Values.output_date))
            {
                return false;
            }
            return true;
        }
        public static void check_str_one_regex()
        {
            bool flag = false;
            Values.str_one_copy = Values.str_one;
            try
            {
                if (Regex.IsMatch(Values.str_one_copy, Values.pattern_phone_number, RegexOptions.IgnoreCase))
                {
                    flag = true;
                    throw new ValidationException("The first string is phone number.");
                }
                if (Regex.IsMatch(Values.str_one_copy, Values.pattern_email, RegexOptions.IgnoreCase))
                {
                    flag = true;
                    throw new ValidationException("The first string is email");
                }
                if (Regex.IsMatch(Values.str_one_copy, Values.pattern_ip, RegexOptions.IgnoreCase))
                {
                    flag = true;
                    throw new ValidationException("The first string is ip adress");
                }
                if (!flag)
                {
                    throw new ValidationException("The first string doesn't match with email, ip or phone number");
                }
            }
            catch (ValidationException) { }
        }
        public static void check_str_two_regex()
        {
            bool flag = false;
            Values.str_two_copy = Values.str_two;
            try
            {
                if (Regex.IsMatch(Values.str_two_copy, Values.pattern_phone_number, RegexOptions.IgnoreCase))
                {
                    flag = true;
                    throw new ValidationException("The second string is phone number.");
                }
                if (Regex.IsMatch(Values.str_two_copy, Values.pattern_email, RegexOptions.IgnoreCase))
                {
                    flag = true;
                    throw new ValidationException("The second string is email");
                }
                if (Regex.IsMatch(Values.str_two_copy, Values.pattern_ip, RegexOptions.IgnoreCase))
                {
                    flag = true;
                    throw new ValidationException("The second string is ip adress");
                }
                if (!flag)
                {
                    throw new ValidationException("The second string doesn't match with email, ip or phone number");
                }
            }
            catch (ValidationException) { }
        }
        public static void check_register_compared_strings()
        {
            Values.str_one_copy = Values.str_one.Trim();
            Values.str_two_copy = Values.str_two.Trim();
            Values.str_one_copy = Values.str_one_copy.ToLower();
            Values.str_two_copy = Values.str_two_copy.ToLower();
            Values.str_one_copy = Values.str_one_copy.Replace(" ", "");
            Values.str_two_copy = Values.str_two_copy.Replace(" ", "");
            try
            {
                if (Values.str_one_copy.CompareTo(Values.str_two_copy) == 0)
                {
                    throw new ValidationException("2) Strings are equal(case-insensitive)");
                }
                else
                {
                    throw new ValidationException("2) Strings are not equal(case-insensitive)");
                }
            }
            catch (ValidationException) { }
        }
        public static void check_reversed_strings()
        {
            var str_one_copy1 = Values.str_one;
            Values.str_two_copy = Values.str_two;
            Values.str_one_copy = new string(str_one_copy1.Reverse().ToArray());
            try
            {
                if (Values.str_one_copy.CompareTo(Values.str_two_copy) == 0)
                {
                    throw new ValidationException("3) One string is reversed to another");
                }
                else
                {
                    throw new ValidationException("3) One string isn't reversed to another");
                }
            }
            catch (ValidationException) { }
        }
        public static void check_compared_strings()
        {
            try
            {
                if (Values.str_one_copy.CompareTo(Values.str_two_copy) == 0)
                {
                    throw new ValidationException("1) Strings are equal(case-sensitive)");
                }
                else
                {
                    throw new ValidationException("1) Strings are not equal(case-sensitive)");
                }
            }
            catch (ValidationException) { }

        }
        static public void check_strings()
        {
            while (true)
            {
                Console.Write("str1 = ");
                Setters.set_command4_str_one();
                if (Values.str_one == null || Values.str_one == String.Empty)
                {
                    Console.Clear();
                    Console.WriteLine("Enter str1 again");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else { break; }
            }
            while (true)
            {

                Console.Write("str2 = ");
                Setters.set_command4_str_two();
                if (Values.str_two == null || Values.str_two == String.Empty)
                {
                    Console.Clear();
                    Console.WriteLine("Enter str2 again");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"str1 = {Values.str_one}");
                    continue;
                }
                else { break; }
            }
        }
        static public long Time_Check(in long N)
        {
            long our_N = N;
            var sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            Command_Dates.PowerOfTwo(our_N);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static bool check_value_Z()
        {
            try
            {
                Values.z = Convert.ToDouble(Values.strZ);
                if (Values.z == 0 || Values.z == -1)
                {
                    Console.Clear();
                    Console.WriteLine("This value of z isn't suitable for the formula. Type another value of z");
                    Console.ReadLine();
                    Console.Clear();
                    return false;
                }
                Console.Clear();

                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error. You've entered a letter");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public static bool check_value_Y()
        {
            try
            {
                Console.Clear();
                Values.y = Convert.ToDouble(Values.strY);
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error. You've entered a letter");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public static bool check_value_X()
        {
            try
            {
                Console.Clear();
                Values.x = Convert.ToDouble(Values.strX);
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error. You've entered a letter");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public static void check_command_number()
        {
            try
            {
                Values.command_number = int.Parse(Values.command_str);
                Values.flag = true;
            }
            catch (Exception)
            {
                Console.Clear();
                Setters.PrintError();
                Console.Clear();
                Values.flag = false;
            }
        }
    }
}
