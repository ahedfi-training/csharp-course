using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value = null;
            //Program x;
            
            //int number = Convert.ToInt32(value);
            ////number = null;
            //var number2 = int.Parse(value);
            string fullName = "Ahmed Hedfi ";
            //fullName = fullName.Trim();
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());
            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("firstName : '{0}'", firstName);
            Console.WriteLine("lastName : '{0}'", lastName);
            var replacedString = fullName.Replace("ahmed", "hello");
            Console.WriteLine(fullName.Replace("Ahmed", "hello"));
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");
            string str = "100";
            decimal ammount = Convert.ToDecimal(str);
            var formattedAmmount = ammount.ToString("C",new CultureInfo("ja-JP"));
            Console.WriteLine(formattedAmmount);

        }
    }
}
