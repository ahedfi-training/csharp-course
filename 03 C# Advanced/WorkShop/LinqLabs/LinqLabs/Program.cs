using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLabs
{
    public class BookLite
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 25)
            //        cheapBooks.Add(book);
            //}

            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title + " " + book.Price);
            //}

            //var anonymsInstance = new { Title = "title" };
            //anonymsInstance.Title
            #region Syntax
            // Linq Query operators
            var titles = from b in books
                         where b.Price < 25
                         orderby b.Title
                         select new { b.Title, b.Price };

            // Linq Extension Methods
            var filteredValues = books
                .Where(b => b.Price < 25)
                .OrderBy(b => b.Title)
                //.Select(b => new BookLite { Title = b.Title, Price = b.Price });
                //.Select(b => new { Title = b.Title, Price = b.Price });
                .Select(b => new { b.Title, b.Price });

            //var obj = new { Name = "Alex", Age = 30 };
            //Console.WriteLine(obj.Name);
            //Console.WriteLine(obj.Age);
            foreach (var b in filteredValues)
            {
                Console.WriteLine($"{b.Title} - {b.Price}");
            }
            #endregion
        }
    }
}
