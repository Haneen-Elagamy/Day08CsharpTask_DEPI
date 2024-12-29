using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_Task
{
    /*Create a class Book with attributes Title and Author.
Provide multiple constructors: a default constructor, one that takes only Title, and another that
takes both Title and Author.
Write a program to demonstrate constructor overloading.*/
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book()
        {
            
        }

        public Book(string Title)
        {
            this.Title = Title;
        }

        public Book(string Title, string Author)
        {
            this.Title= Title;
            this.Author = Author;
        }

        public override string ToString()
        {
            return $"Book title is {Title},Author is {Author}";
        }
    }
}
