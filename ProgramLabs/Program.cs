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
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu.show_menu();
                Setters.set_command_number();
                Check.check_command_number();
                if (Values.flag == false) continue;
                Console.Clear();
                Menu.Choice(Values.command_number);
                Console.Clear();
            }
        }
    }
}