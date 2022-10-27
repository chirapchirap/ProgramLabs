using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class Command_Formula : Task
    {
        public override string Title { get { return "Formula"; } }
        public override void Execute()
        {
            Console.Write("(y - x) / sqrt(z) = " + Command2_method() + "\n\n");
        }
        public static double Command2_method()
        {
            while (true)
            {
                Console.WriteLine("(y - x) / sqrt(z) = ?" + "\n");
                Console.Write("z = ");
                Setters.set_Z();
                if (Check.check_value_Z())
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
                Console.WriteLine("(" + "y - x) / sqrt(z) = ?" + "\n");
                Console.WriteLine("z = " + Values.z);
                Console.Write("y = ");
                Setters.set_Y();
                if (Check.check_value_Y())
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
                Console.WriteLine("(y - x) / sqrt(z) = ?" + "\n");
                Console.WriteLine("z = " + Values.z);
                Console.WriteLine("y = " + Values.y);
                Console.Write("x = ");
                Setters.set_X();
                if (Check.check_value_X())
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            return (Values.y - Values.x) / Math.Sqrt(Values.z);
        }
    }
}
