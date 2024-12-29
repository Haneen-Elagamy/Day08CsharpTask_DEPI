using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    internal class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("The Car Engine has been started");
        }

        public void StopEngine()
        {
            Console.WriteLine("The Car Engine has been stopped");
        }
    }
}
