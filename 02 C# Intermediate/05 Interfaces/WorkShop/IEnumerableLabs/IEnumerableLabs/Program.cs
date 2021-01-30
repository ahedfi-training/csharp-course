using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IEnumerableLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3 };
            var arrays = new int[] { 1, 2, 3 };
            DisplayItems(list);
            DisplayItems(arrays);

            IEnumerable<string> s = new List<string>();
            IEnumerable<object> o;

            foreach (var item in GetItems())
            {
                Console.WriteLine(item);
            }

            var people = new People(new Person[] { new Person("ahmed", "hedfi"), new Person("cherif", "benriche") });
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

        }

        private static void  DisplayItems(IEnumerable<int> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> GetItems()
        {
            //var a = 0;
            //yield return 1;
            //a = 1;
            //yield return 2;
            //a = 3;
            //yield return 3;
            return new int[] { 1, 2, 3 };

        }


        static void DisplayItems(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            //{
            //    while (enumerator.MoveNext()) Console.WriteLine(enumerator.Current);
            //}
        }
    }
}
