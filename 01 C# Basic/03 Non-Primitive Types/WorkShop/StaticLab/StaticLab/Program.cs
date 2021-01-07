using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace StaticLab
{
    partial class Program
    {
        static void Main(string[] args)
        {

            decimal number = 100000000000000000000m + 0.00001m;

            // Class
            var calculator = new Calculator();
            //var result = Calculator.Result;
            //var result = calculator.Add(1, 2);
            var result = Calculator.Add(1, 2);
            System.Console.WriteLine(result);

            // Struct
            var point = new Point();
            point.Move(0, 1);

            //String
            var numbers = new int[3] { 1, 2, 3 };
            var list = string.Join(",", numbers);
            System.Console.WriteLine(list);

            //// Immutable
            var message = "Hello";  // Hello
            message += " World";    // Hello World

            //Verbatim String
            var path = @"C:\mypath\myfolder\";
            var firstName = "John";
            var lastName = "Smith";
            //var name = firstName + " " + lastName;
            //var name = string.Format("FullName = {0} {1}", firstName, lastName);

            var name = $"FullName {firstName} {lastName}"; // 4.6

            //Enums
            //var monday = Days.Monday;
            //System.Console.WriteLine((byte)monday);

            //var day1 = 1;
            //if (day1 == (byte)Days.Monday)
            //{
            //    System.Console.WriteLine("It is monday");
            //}

            var weekend = Days.Saturday | Days.Sunday; //1100000
                                                       //0100000
                                                       //0100000

            if ((weekend & Days.Saturday) == Days.Saturday)
                System.Console.WriteLine("It is Weekend");

            System.Console.WriteLine((byte)weekend);
        }
    }
}
