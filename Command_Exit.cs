using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    class Command_Exit : Task
    {
        public override string Title { get { return "Exit..."; } }
        public override void Execute()
        {
            Environment.Exit(0);
        }
    }
}
