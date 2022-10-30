using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs
{
    public class ValidationException : Exception
    {
        public ValidationException() : base() { }
        public ValidationException(string message) : base(message)
        {
            Message = message;
            Console.WriteLine(Message);
        }
        public override string Message { get; }
    }
}
