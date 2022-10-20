using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    public class Command_Hello_World : Task
    {
        public override string Title { get { return "Print \"Hello world!\""; } }
        public override void Execute()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
