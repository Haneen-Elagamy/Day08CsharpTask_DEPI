using Day08C_Task.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task.Interface
{
    internal interface IShape
    {
        public double GetArea();
        public void Display();
    }

    internal class RectangleWithInterface : IShape
    {
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }
        public RectangleWithInterface(double Dim1, double Dim2)
        {
            this.Dim1 = Dim1;
            this.Dim2 = Dim2;
        }

        public double GetArea()
        {
            return Dim1 * Dim2;
        }

        public void Display()
        {
            Console.WriteLine($"The area is : {GetArea()}");
        }
    }

    internal class CircleWithInterface : IShape
    {
        public double R { get; set; }
        public CircleWithInterface(double R)
        {
            this.R = R;
        }
        public double GetArea()
        {
            return Math.PI * R * R;
        }
        public void Display()
        {
            Console.WriteLine($"The area is : {GetArea()}");
        }

    }

}
