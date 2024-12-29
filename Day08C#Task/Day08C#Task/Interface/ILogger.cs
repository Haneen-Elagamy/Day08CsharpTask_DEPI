using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task.Interface
{
    internal interface ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log method default implementation");
        }
    }

    internal class ConsoleLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Custom implementation for Log method in ConsoleLogger Class");
        }
    }

}
