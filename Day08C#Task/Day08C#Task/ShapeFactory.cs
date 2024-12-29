using Day08C_Task.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    internal class ShapeFactory
    {
        public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    return new Rectanglee(dim1, dim2);
                case "triangle":
                    return new Triangle(dim1, dim2);
                default:
                    throw new ArgumentException("Invalid shape type provided");
            }
        }
    }
}
