using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class FormulaChecker
    {
        public static bool check_value_Z(ref string strZ, ref double Z)
        {
            try
            {
                Z = Convert.ToDouble(strZ);
                if (Z == 0 || Z == -1)
                {
                    Console.Clear();
                    Console.WriteLine("This value of z isn't suitable for the formula. Type another value of z");
                    Console.ReadLine();
                    Console.Clear();
                    return false;
                }
                Console.Clear();
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error. You've entered a letter");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public static bool check_value_Y(ref string strY, ref double Y)
        {
            try
            {
                Console.Clear();
                Y = Convert.ToDouble(strY);
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error. You've entered a letter");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
        public static bool check_value_X(ref string strX, ref double X)
        {
            try
            {
                Console.Clear();
                X = Convert.ToDouble(strX);
                return true;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Error. You've entered a letter");
                Console.ReadLine();
                Console.Clear();
                return false;
            }
        }
    }
}
