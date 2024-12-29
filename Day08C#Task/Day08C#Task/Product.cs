using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    internal class Product:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int Id,string Name,double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"product Id is {Id}, Name is {Name}, Price is {Price}";
        }

        public int CompareTo(object obj)
        {
            Product passedProduct=(Product)obj;
            if(this.Price>passedProduct.Price)
            {
                return 1;
            }
            else if (this.Price<passedProduct.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
