using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public abstract class Task
    {
        public abstract string Title { get; }
        public abstract void Execute();
    }
}
