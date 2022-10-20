using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    static class Menu
    {
        public static void show_menu()
        {
            Console.WriteLine("Menu\n0: Exit\n1: Hello world!\n2: Calc (Y - X) / sqrt(Z)\n3: Recursion date\n4: Strings\n\nEnter a number: ");
        }
        public static void Choice(in int number)
        {
            switch (number)
            {
                case 0:
                    {
                        Setters.Get_command_name(new Command_Exit());
                        new Command_Exit().Execute();
                        break;
                    }
                case 1:
                    {
                        Setters.Get_command_name(new Command_Hello_World());
                        new Command_Hello_World().Execute();
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Setters.Get_command_name(new Command_Formula());
                        new Command_Formula().Execute();
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Setters.Get_command_name(new Command_Dates());
                        new Command_Dates().Execute();
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Setters.Get_command_name(new Command_Strings());
                        new Command_Strings().Execute();
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Setters.PrintError();
                        return;
                    }
            }
        }
    }
}
