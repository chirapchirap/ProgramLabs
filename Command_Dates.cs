using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class Command_Dates : Task
    {
        public override string Title { get { return "Dates"; } }
        public override void Execute()
        {
            print_dates();
            Console.WriteLine(DateChecker.coinciding_dates_num(dates_processing(Beginning_1_date, End_1_date, Beginning_2_date, End_2_date)));
            Console.ReadLine();
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
        void print_dates()
        {
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the beginning of the first date in the format dd.mm.yyyy");
                    //Setters.set_date();
                    Setters.set_sInputDate(ref sInputDate);
                    if (DateChecker.check_date(ref output_date, sInputDate))
                    {
                        Beginning_1_date = output_date;
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
                    Setters.set_sInputDate(ref sInputDate);
                    if (DateChecker.check_date(ref output_date, sInputDate))
                    {
                        End_1_date = output_date;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input date. Enter the date in the format dd.mm.yyyy");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("Wrong period. Try again");
                if (Beginning_1_date.CompareTo(End_1_date) <= 0)
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
                    Setters.set_sInputDate(ref sInputDate);
                    if (DateChecker.check_date(ref output_date, sInputDate))
                    {
                        Beginning_2_date = output_date;
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
                    Setters.set_sInputDate(ref sInputDate);
                    if (DateChecker.check_date(ref output_date, sInputDate))
                    {
                        End_2_date = output_date;
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Wrong input date. Enter the date in the format dd.mm.yyyy");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("Wrong period. Try again");
                if (Beginning_2_date.CompareTo(End_2_date) <= 0)
                {
                    Console.Clear();
                    break;
                }
                Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine(Beginning_1_date.ToString("Первый промежуток dd.MM.yyyy - ") + (End_1_date.ToString("dd.MM.yyyy")));
            Console.WriteLine(Beginning_2_date.ToString("Второй промежуток dd.MM.yyyy - ") + End_2_date.ToString("dd.MM.yyyy"));
        }
        public static int dates_processing(DateTime d1b, DateTime d1e, DateTime d2b, DateTime d2e)
        {
            TimeSpan timeA = d1b - d1b;
            TimeSpan timeB = d2e - d2b;
            TimeSpan N = timeB - timeB;
            if (d1b == d2b && d1e == d2e)
            {
                N = d1e - d1b;
                Console.WriteLine($"N = {N.Days + 1}");
            }
            if (d2e < d1b || d2b > d1e)
            {
                Console.WriteLine($"N = {N.Days}");
            }
            if (d2b > d1b && d2b < d1e)
            {
                if (d2e > d1e)
                {
                    N = d1e - d2b;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
                else
                {
                    N = d2e - d2b;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
            }
            if (d2b < d1b && d2e > d1b)
            {
                if (d2e > d1e)
                {
                    N = d1e - d1b;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
                else
                {
                    N = d2e - d1b;
                    Console.WriteLine($"N = {N.Days + 1}");
                }
            }
            return N.Days + 1;
        }
        private DateTime output_date, Beginning_1_date, End_1_date, Beginning_2_date, End_2_date;
        private string sInputDate;
    }
}
