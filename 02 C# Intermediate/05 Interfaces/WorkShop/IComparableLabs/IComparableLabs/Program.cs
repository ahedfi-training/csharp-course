using System;
using System.Collections.Generic;

namespace IComparableLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
                new Order { Created = new DateTime(2012, 12, 1 )},
                new Order { Created = new DateTime(2012, 1, 6 )},
                new Order { Created = new DateTime(2012, 7, 8 )},
                new Order { Created = new DateTime(2012, 2, 20 )},
                null,
            };
            orders.Sort();
        }
    }
}
