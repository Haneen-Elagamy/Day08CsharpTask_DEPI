using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task.Abstract
{
    internal abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        public GeometricShape(double Dimension1, double Dimension2)
        {
            this.Dimension1 = Dimension1;
            this.Dimension2 = Dimension2;
        }
        public abstract double Perimeter { get; }

       public abstract double CalculateArea();
       public override string ToString()
       {
           return $"Shape with dimensions: {Dimension1}, {Dimension2}";
       }

    }

    internal class Triangle : GeometricShape
    {
        //Constructor chaining using base keyword
        public Triangle(double baseLength, double height) : base(baseLength, height) { }
        public override double Perimeter
        {
            get
            {
                // Assuming an isosceles triangle for simplicity: Perimeter = 2 * Side + Base
                double side = Math.Sqrt(Math.Pow(Dimension1 / 2, 2) + Math.Pow(Dimension2, 2));
                return Dimension1 + 2 * side;
            }
        }
        public override double CalculateArea()
        {
            return 0.5*Dimension1*Dimension2;
        }

        public override string ToString()
        {
            return $"Triangle: Base = {Dimension1}, Height = {Dimension2}, Area = {CalculateArea()}";
        }
    }

    internal class Rectanglee : GeometricShape
    {
        public Rectanglee(double length, double width) : base(length, width) { }

        public override double Perimeter => (Dimension1+Dimension2)*2;

        public override double CalculateArea()
        {
            return Dimension1*Dimension2;
        }

        public override string ToString()
        {
            return $"Rectangle: Length = {Dimension1}, Width = {Dimension2}, Area = {CalculateArea()}";
        }
    }
}
