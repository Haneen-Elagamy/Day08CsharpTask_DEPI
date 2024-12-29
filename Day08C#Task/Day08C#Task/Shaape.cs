using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    /*o Create a class Shape with properties:
 string Name (e.g., "Square", "Circle").
 double Area.
o Implement IComparable for sorting shapes by area.
o Create a list of shapes with various types (Square, Circle, Rectangle) and areas.
o Sort and display the shapes by area in ascending order using Array.Sort().*/
    internal class Shaape:IComparable
    {
        public string Name { get; set; } 
        public double Area { get; set; }

        public Shaape(string Name, double Area)
        {
            this.Name = Name;
            this.Area = Area;
        }

        public int CompareTo(object obj)
        {
            Shaape PassedShape=( Shaape)obj;
            if(this.Area > PassedShape.Area )
                return 1;
            else if(this.Area < PassedShape.Area )
                return -1;
            else 
                return 0;
        }

        public override string ToString()
        {
            return $"Shape name is: {Name}, Shape area is: {Area}";
        }
    }
}
