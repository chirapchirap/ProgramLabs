using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class Command_Strings : Task
    {

        public Command_Strings()
        {
            while (true)
            {
                Console.Write("str1 = ");
                Setters.set_sStr(ref str_one);
                if (str_one == null || str_one == String.Empty)
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
                Setters.set_sStr(ref str_two);
                if (str_two == null || str_two == String.Empty)
                {
                    Console.Clear();
                    Console.WriteLine("Enter str2 again");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"str1 = {str_one}");
                    continue;
                }
                else { break; }
            }
        }
        public override string Title { get { return "Strings"; } }
        public override void Execute()
        {
            str1_regex(ref str_one);
            str2_regex(ref str_two);
            cmp_strs(ref str_one, ref str_two);
            reg_cmp_strs(ref str_one, ref str_two);
            rev_strs(ref str_one, ref str_two);
        }
        public static void str1_regex(ref string str)
        {
            try
            {
                StringChecker.check_str_one_regex(str);
            }
            catch (ValidationException)
            {
                return;
            }
        }
        public static void str2_regex(ref string str)
        {
            try
            {
                StringChecker.check_str_two_regex(str);
            }
            catch (ValidationException)
            {
                return;
            }
        }
        public static void reg_cmp_strs(ref string str1, ref string str2)
        {
            try
            {
                StringChecker.check_register_compared_strings(str1, str2);
            }
            catch (ValidationException)
            {
                return;
            }
        }
        public static void cmp_strs(ref string str1, ref string str2)
        {
            try
            {
                StringChecker.check_compared_strings(str1, str2);
            }
            catch (ValidationException) { return; }
        }
        public static void rev_strs(ref string str1, ref string str2)
        {
            try
            {
                StringChecker.check_reversed_strings(str1, str2);

            }
            catch (ValidationException)
            {
                return;
            }
        }
        private static string str_one = null, str_two = null;
    }
}
