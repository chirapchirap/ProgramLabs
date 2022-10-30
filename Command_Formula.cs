using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class Command_Formula : Task
    {
        public Command_Formula() {}
        public Command_Formula(bool flag)
        {
            while (true)
            {
                Console.WriteLine($"(y - x) / sqrt(z) = ?" + "\n");
                Console.Write("z = ");
                Setters.set_4mula_argument(ref strZ);
                if (FormulaChecker.check_value_Z(ref strZ, ref Z))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine($"(y - x) / sqrt(z) = ?" + "\n");
                Console.WriteLine("z = " + Z);
                Console.Write("y = ");
                Setters.set_4mula_argument(ref strY);
                if (FormulaChecker.check_value_Y(ref strY, ref Y))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            while (true)
            {
                Console.WriteLine($"(y - x) / sqrt(z) = ?" + "\n");
                Console.WriteLine("z = " + Z);
                Console.WriteLine("y = " + Y);
                Console.Write("x = ");
                Setters.set_4mula_argument(ref strX);
                if (FormulaChecker.check_value_X(ref strX, ref X))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        public override string Title { get { return "Formula:"; } }
        public override void Execute()
        {
            double res = formula_count(ref Y, ref X, ref Z);
            Console.WriteLine($"(y - x) / sqrt(z) = { res }");
        }
        public static double formula_count(ref double Y, ref double X, ref double Z)
        {
            return (Y - X) / Math.Sqrt(Z);
        }
        private double X, Y, Z;
        private string strX = null, strY = null, strZ = null;
    }
}
