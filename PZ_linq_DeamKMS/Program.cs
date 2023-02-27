using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_linq_DeamKMS
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> list = new List<Book>()
            {
                new Book("Шишкин",2002,213),
                new Book("Плюшкин",3001,213),
                new Book("Соснов",1991,213),
                new Book("Куршанашвили",1900,213),
                new Book("Пупкин",1969,213),
                new Book("Свисток",2013,213)

            };
            var listbook = list.Where(u=>u.Year<=1994 && u.Pages>200).ToList();
            listbook.ForEach(book =>Console.WriteLine(book.Author+" " + book.Year +" " + book.Pages));
            Console.ReadKey();

        }
            
        }
    }

