using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Alice";
            //customer.Orders = new List<Order>();
            Console.WriteLine(customer.Orders.Count);
            foreach (var order in customer.Orders)
            {
                // ...
            }

            var secondCustomer = new Customer(1,"Bob");
        }
    }
}
