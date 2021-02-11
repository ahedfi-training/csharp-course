using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Singleton.Instance;
            s.Value = 3;
        }
    }
}
