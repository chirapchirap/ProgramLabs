using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
     public class Setters
        {
        public static string set_sValue()
        {
            return Console.ReadLine();
        }
        public static void set_sInputDate(ref string sValue)
        {
            sValue = Console.ReadLine();
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
        public static void set_sStr(ref string str)
        {
            str = Console.ReadLine();
        }
        public static void set_command_number(ref string value)
        {
            value = Console.ReadLine();
        }
        public static void set_4mula_argument(ref string argument)
        {
            argument = Console.ReadLine();
        }
    }
}
