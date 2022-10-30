using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class DateChecker
    {
        public static bool check_date(ref DateTime output_date, string sInputDate)
        {
            if (!DateTime.TryParse(sInputDate, out output_date  ))
            {
                return false;
            }
            return true;
        }
        public static long Time_Check(in long N)
        {
            long our_N = N;
            var sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            Command_Dates.PowerOfTwo(our_N);
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
        public static string coinciding_dates_num(int N)
        {
            if (N > 0)
            {
                if (Time_Check(N) > 3000)
                {
                    return "Programm runtime > 3 seconds.";                    
                }
                else
                {
                    if (Command_Dates.PowerOfTwo(N) == true)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
            else
            {
                return "N должен быть больше 0!!";
            }
        }
    }
}
