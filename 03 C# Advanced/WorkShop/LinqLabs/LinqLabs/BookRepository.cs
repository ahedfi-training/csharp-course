using System.Collections.Generic;

namespace LinqLabs
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{ Title = "Title 1", Price = 5},
                new Book{ Title = "Title 2", Price = 15},
                new Book{ Title = "Title 3", Price = 25},
                new Book{ Title = "Title 4", Price = 35},
            }; 
        }
    }
}
