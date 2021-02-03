using System.Collections.Generic;

namespace LambdaExpressionLabs
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "Title 1", Price = 10},
                new Book(){Title = "Title 2", Price = 20},
                new Book(){Title = "Title 3", Price = 30},
            };
        }
    }
}
