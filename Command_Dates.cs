using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    public class Command_Dates : Task
    {
        public override string Title { get { return "Dates"; } }
        public override void Execute()
        {
            dates_processing();
        }
        public static bool PowerOfTwo(long n)
        {
            if (n == 1)
                return true;
            else
               if (n > 1 && n < 2 || n % 2 != 0)
                return false;
            else
                return PowerOfTwo(n / 2);
        }
        public static void print_dates()
        {
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the beginning of the first date in the format dd.mm.yyyy");
                    Setters.set_date();
                    if (Check.check_date())
                    {
                        Values.Beginning_1_date = Values.output_date;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input date. Enter the date in the format dd.mm.yyyy");
                    Console.ReadLine();
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the end of the first date in the format dd.mm.yyyy");
                    Setters.set_date();
                    if (Check.check_date())
                    {
                        Values.End_1_date = Values.output_date;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input date. Enter the date in the format dd.mm.yyyy");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("Wrong period. Try again");
                if (Values.Beginning_1_date.CompareTo(Values.End_1_date) <= 0)
                {
                    Console.Clear();
                    break;
                }
                Console.ReadLine();
            }
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the beginning of the second date in the format dd.mm.yyyy");
                    Setters.set_date();
                    if (Check.check_date())
                    {
                        Values.Beginning_2_date = Values.output_date;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input date. Enter the date in the format dd.mm.yyyy");
                    Console.ReadLine();
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the end of the second date in the format dd.mm.yyyy");
                    Setters.set_date();
                    if (Check.check_date())
                    {
                        Values.End_2_date = Values.output_date;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input date. Enter the date in the format dd.mm.yyyy");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("Wrong period. Try again");
                if (Values.Beginning_2_date.CompareTo(Values.End_2_date) <= 0)
                {
                    Console.Clear();
                    break;
                }
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine(Values.Beginning_1_date.ToString("Первый промежуток dd.MM.yyyy - ") + (Values.End_1_date.ToString("dd.MM.yyyy")));
            Console.WriteLine(Values.Beginning_2_date.ToString("Второй промежуток dd.MM.yyyy - ") + Values.End_2_date.ToString("dd.MM.yyyy"));
        }

        public static void dates_processing()
        {
            print_dates();
            TimeSpan timeA = Values.End_1_date - Values.Beginning_1_date;
            TimeSpan timeB = Values.End_2_date - Values.Beginning_2_date;
            TimeSpan N = timeB - timeB;
            if (Values.Beginning_1_date == Values.Beginning_2_date && Values.End_1_date == Values.End_2_date)
            {
                N = Values.End_1_date - Values.Beginning_1_date;
                Console.WriteLine($"N = {N.Days + 1}");
            }
            if (Values.End_2_date < Values.Beginning_1_date || Values.Beginning_2_date > Values.End_1_date)
            {
                Console.WriteLine($"N = {N.Days}");
            }
            if (Values.Beginning_2_date > Values.Beginning_1_date && Values.Beginning_2_date < Values.End_1_date)
            {
                if (Values.End_2_date > Values.End_1_date)
                {
                    N = Values.End_1_date - Values.Beginning_2_date;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
                else
                {
                    N = Values.End_2_date - Values.Beginning_2_date;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
            }
            if (Values.Beginning_2_date < Values.Beginning_1_date && Values.End_2_date > Values.Beginning_1_date)
            {
                if (Values.End_2_date > Values.End_1_date)
                {
                    N = Values.End_1_date - Values.Beginning_1_date;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
                else
                {
                    N = Values.End_2_date - Values.Beginning_1_date;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
            }
            if (N.Days > 0)
            {
                if ((Check.Time_Check(N.Days + 1)) > 3000)
                {
                    Console.Clear();
                    Console.WriteLine("Programm runtime > 3 seconds.");
                }
                else
                {
                    if (PowerOfTwo(N.Days + 1) == true)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            else
            {
                Console.WriteLine("N должен быть больше 0!!");
            }
        }
    }
}
