using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    public static class Values
    {
        public static DateTime output_date, Beginning_1_date, End_1_date, Beginning_2_date, End_2_date;
        public static string str_one_copy, str_two_copy;
        public static string pattern_phone_number = "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$";
        public static string pattern_email = "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+";
        public static string pattern_ip = "(\\b25[0-5]|\\b2[0-4][0-9]|\\b[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
        public static double z, y, x;
        public static int command_number;
        public static string input_date_str, command_str, strZ, strY, strX, str_one = null, str_two = null;
        public static bool flag;
    }
}
