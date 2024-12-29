using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task.Abstract
{
    internal abstract class Shape
    {
        
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine($"The Area is : {GetArea()}");
        }
    }

    internal class RectangleWithAbstract : Shape
    {
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }
        public RectangleWithAbstract(double Dim1, double Dim2)
        {
            this.Dim1 = Dim1;
            this.Dim2 = Dim2;
        }

        public override double GetArea()
        {
            return Dim1 * Dim2;
        }

    }

    internal class CircleWithAbstract : Shape
    {
        public double R { get; set; }
        public CircleWithAbstract(double R)
        {
            this.R = R;
        }
        public override double GetArea()
        {
            return Math.PI * R * R;
        }

    }
}
