using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task.Interface
{
    internal interface IShapeSeries
    {
        public int CurrentShapeArea { get; set; }

        public void GetNextArea();
        public void ResetSeries()
        {
            CurrentShapeArea = 0;
        }
    }

    internal class SquareSeries : IShapeSeries
    {
        public int CurrentDimension = 1;//start with dimesion 1
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            CurrentShapeArea=CurrentDimension*CurrentDimension;//Area of the square
            CurrentDimension++;
        }

    }

    internal class CircleSeries : IShapeSeries
    {
        public int CurrentRadius = 1;//start with radius 1
        public int CurrentShapeArea { get; set; }
        public void GetNextArea()
        {
            CurrentShapeArea=(int)(Math.PI* CurrentRadius * CurrentRadius);
            CurrentRadius++;
        }
    }

}
