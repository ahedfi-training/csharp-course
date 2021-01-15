using System.Collections.Generic;

namespace ReadOnlyLab
{
    public class Customer
    {
        //public readonly int maxOrders = 10;
        public const int maxOrders = 10;
        public readonly List<Order> Orders = new List<Order>();
        public void Promote()
        {
            // ... 
            //Orders = new List<Order>();
            maxOrders = 5;
        }
    }
}
