using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    static public class Setters
    {
        public static string set_sValue()
        {
            return Console.ReadLine();
        }
        public static void set_date()
        {
            Values.input_date_str = Console.ReadLine();
        }
        public static void set_strings()
        {
            Values.str_one_copy = Values.str_one;
            Values.str_two_copy = Values.str_two;
        }
        public static void Get_command_name(dynamic Command)
        {
            Console.WriteLine(Command.Title);
        }
        public static void PrintError()
        {
            Console.WriteLine("Error. No such command.");
            Console.ReadLine();
        }
        public static void set_command4_str_one()
        {
            Values.str_one = Console.ReadLine();
        }
        public static void set_command4_str_two()
        {
            Values.str_two = Console.ReadLine();
        }
        public static void set_command_number()
        {
            Values.command_str = Console.ReadLine();
        }
        public static void set_Z()
        {
            Values.strZ = Console.ReadLine();
        }
        public static void set_Y()
        {
            Values.strY = Console.ReadLine();
        }
        public static void set_X()
        {
            Values.strX = Console.ReadLine();
        }
    }
}
