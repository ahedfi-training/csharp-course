using System;
using System.Diagnostics;
using System.Threading;

namespace IDisposableLabs
{
    public class Container : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Container is disposed");
            Debug.WriteLine("Container is disposed");
            Thread.Sleep(3000);
        }
    }
}
