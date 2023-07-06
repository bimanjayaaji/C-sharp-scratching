using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken
{
    class Book
    {
        // ----------- 24.object and class -----------
        public string? title;
        public string? author;
        public int pages;

        public Book() // overloading
        {

        }

        // ----------- 25.constructor -----------
        public Book(string title, string author, int pages)
        {
            //Console.WriteLine(name);
            this.title = title;
            this.author = author;
            this.pages = pages;
            Console.WriteLine($"Book with title {title} was created");
        }

    }
}
