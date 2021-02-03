using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionLabs
{
    class Program
    {
        public static int value;
        static void Main(string[] args)
        {
            // args => expression
            // () => expression
            // x => expression
            // (x,y)=> expression
            var factor = 5;



            var result = Square(5);
            Func<int, int> squareFn = x => x * x;
            var resultFn = squareFn(5);//raise
            Action<int> logInt = x => Console.WriteLine(x);
            logInt(5);
            Func<int, decimal, decimal> multiply = (x, y) => x * y;
            Func<int, int> multiplyByFactor = x => x * factor;

            var resultMultiplyByFactor = multiplyByFactor(factor);

            var resultMultiply = multiply(2, 2.5m);

            ////Func<int,int> squareFn = x => { return x * x; };
            ////Func<int,decimal,int> squareFn = (x,y) => x * x;

            //Func<int, int> squareFn = x => x * x + value;
            //Action<int> logInt = x => Console.WriteLine(x);
            //logInt(5);
            //var result = squareFn(5);
            //Console.WriteLine(result);



            #region
            var bookRepository = new BookRepository();
            var books = bookRepository.GetBooks();

            //foreach (var book in books)
            //{
            //    if (book.Price < 30)
            //        Console.WriteLine(book.Title);
            //}

            //var booksCheaperThan30 = books.FindAll(CheaperThan30);
            var booksCheaperThan30 = books.FindAll(book => book.Price < 30);

            foreach (var book in booksCheaperThan30)
            {
                Console.WriteLine(book.Title);
            }
            #endregion
        }

        static bool CheaperThan30(Book book)
        {
            return book.Price < 30;
        }
        static int Square(int number)
        {
            return number * number;
        }
    }
}
