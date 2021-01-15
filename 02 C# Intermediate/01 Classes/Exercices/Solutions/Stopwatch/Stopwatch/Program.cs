using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Method();
            stopwatch.Stop();
            stopwatch.Start();
            Method();
            stopwatch.Stop();
            var duration = stopwatch.Duration;
            Console.WriteLine(duration.TotalSeconds);
        }
        static void Method()
        {
            Thread.Sleep(2000);
        }
    }
}
