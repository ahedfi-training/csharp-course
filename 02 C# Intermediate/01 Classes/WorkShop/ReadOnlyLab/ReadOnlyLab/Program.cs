using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var order = new Order();
            customer.Orders.Add(order);

            customer.Promote();
            customer.Orders.Add(order);

            var totalOrders = customer.Orders.Count;
        }
    }
}
