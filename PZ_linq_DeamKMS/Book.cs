using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_linq_DeamKMS
{
    class Book
    {
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public Book(string Author, int Year, int Pages)
        {
            this.Author = Author;
            this.Year = Year;
            this.Pages = Pages;
        }
    }
}
