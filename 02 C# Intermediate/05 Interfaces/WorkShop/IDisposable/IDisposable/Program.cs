using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = new Container();
            ////....
            //throw new Exception();

            using (var container = new Container())
            {
                //...
                System.Console.WriteLine("Inside Using Block");
                throw new Exception("error");
            }
        }
    }
}
