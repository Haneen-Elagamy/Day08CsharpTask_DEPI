using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    internal class Student:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        //default Ctor
        public Student()
        {
            
        }

        //Copy Ctor
        public Student(Student Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name;
            Grade = Copy.Grade;
        }

        public object Clone()
        {
            return new Student(this)
            {
            };

        }

        public override string ToString()
        {
            return $"Student Id is {Id}, Name is {Name}, Grade is {Grade}";
        }
    }
}
