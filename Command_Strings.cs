using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LABS
{
    public class Command_Strings : Task
    {
        public override string Title { get { return "Strings"; } }
        public override void Execute()
        {
            Check.check_strings();
            Setters.set_strings();
            Check.check_compared_strings();
            Check.check_register_compared_strings();
            Setters.set_strings();
            Check.check_reversed_strings();
            Check.check_str_one_regex();
            Check.check_str_two_regex();
        }
        public static void Compare_Reversed_string()
        {
            var str_one_copy1 = Values.str_one;
            Values.str_two_copy = Values.str_two;
            Values.str_one_copy = new string(str_one_copy1.Reverse().ToArray());
            Check.check_compared_strings();
        }
        public static void str_one_regex()
        {
            bool flag = false;
            Values.str_one_copy = Values.str_one;
            if (Regex.IsMatch(Values.str_one_copy, Values.pattern_phone_number, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The first string is phone number.");
                flag = true;
            }
            if (Regex.IsMatch(Values.str_one_copy, Values.pattern_email, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The first string is email");
                flag = true;
            }
            if (Regex.IsMatch(Values.str_one_copy, Values.pattern_ip, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The first string is ip adress");
                flag = true;
            }
            if (!flag)
            {
                Console.WriteLine("The first string doesn't match with email, ip or phone number");
            }
        }
        public static void str_two_regex()
        {
            bool flag = false;
            Values.str_two_copy = Values.str_two;
            if (Regex.IsMatch(Values.str_two_copy, Values.pattern_phone_number, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The second string is phone number.");
                flag = true;
            }
            if (Regex.IsMatch(Values.str_two_copy, Values.pattern_email, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The second string is email");
                flag = true;
            }
            if (Regex.IsMatch(Values.str_two_copy, Values.pattern_ip, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("The second string is ip adress");
                flag = true;
            }
            if (!flag)
            {
                Console.WriteLine("The first string doesn't match with email, ip or phone number");
            }
        }

    }
}
