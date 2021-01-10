using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 1, 3, 4 };
            list.Add(1);

            list.AddRange(new int[3] { 5, 6, 7 });
            list.AddRange(new List<int>() { 10, 12, 1 });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count :" + list.Count);

            Console.WriteLine("index of 1 :" + list.IndexOf(1));
            Console.WriteLine("last index of 1 :" + list.LastIndexOf(1));

            //foreach (var item in list)
            //{
            //    if (item == 1)
            //        list.Remove(item);
            //}

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                    list.Remove(list[i]);
            }

            //while (list.Contains(1))
            while (list.IndexOf(1) != -1)
            {
                list.RemoveAt(list.IndexOf(1));
            }



            list.RemoveAll(e => e == 1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
