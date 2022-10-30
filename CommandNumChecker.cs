using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class CommandNumChecker
    {
        public static bool check_command_number(ref int iNum, ref string sNum)
        {
            try
            {
                iNum = int.Parse(sNum);
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Setters.PrintError();
                Console.Clear();
                return false;
            }
        }
    }
}
