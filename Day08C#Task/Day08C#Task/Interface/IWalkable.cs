using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task.Interface
{
    /*Problem:
Create an interface IWalkable with a method Walk().
Implement explicit interface methods in a class Robot to handle IWalkable methods differently
than its own methods.*/
    internal interface IWalkable
    {
        public void Walk();
    }

    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot is walking using its own method");
        }
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking using the IWaikable Interface method");
        }
    }

}
