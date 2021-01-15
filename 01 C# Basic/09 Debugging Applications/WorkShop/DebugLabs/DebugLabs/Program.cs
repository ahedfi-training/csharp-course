using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugLabs
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 4);

//#if DEBUG
//            Console.WriteLine("Debug version");
//#endif
            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));

            Trace.Listeners.Add(tr2);

            Debug.Listeners.Add(tr1);
            Debug.Listeners.Add(tr2);

            Debug.WriteLine("Debug: Main method");
            Debug.Flush();
            Trace.WriteLine($"Trace- {DateTime.Now:yyyy-mm-dd HH:mm:ss}: Main method");
            Trace.Flush();

            foreach (var number in smallests)
                Console.WriteLine(number);

            // ....
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            //Defense Programming
            if (list == null)
                throw new ArgumentNullException("list should be not null", nameof(list));
            if (list.Count < count || count <= 0)
                throw new ArgumentException("The size of smallest number should between 1 and n elements of the list", nameof(count));

            var smallests = new List<int>();
            //var copyOfElements = new List<int>();
            //foreach (var number in list)
            //{
            //    copyOfElements.Add(number);
            //}
            var copyOfElements = new List<int>(list);
            while (smallests.Count < count)
            {
                var min = GetSmallest(copyOfElements);
                smallests.Add(min);
                copyOfElements.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //if (list == null)
            //    throw new ArgumentNullException("list should not be null");
            //if (list.Count == 0)
            //    throw new ArgumentException("list should not be empty");
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }

}
