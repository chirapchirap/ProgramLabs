using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Runtime;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Windows.Input;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ProgramLabs
{
    class Program
    {
        private static  string sMenuNum = null;
        private static int iMenuNum;
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.show_menu();
                Setters.set_command_number(ref sMenuNum);
                if (CommandNumChecker.check_command_number(ref iMenuNum, ref sMenuNum) == false) continue;
                Console.Clear();
                Menu.Choice(iMenuNum);
                Console.Clear();
            }
        }
    }
}