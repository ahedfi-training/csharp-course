
using System;

namespace IComparableLabs
{
    class Order : IComparable
    {
        public int value;
        public DateTime Created { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1; // check obj is null : obj -- this
            Order order = obj as Order;
            if (order == null)
            {
                throw new ArgumentException("Object is not an Order");
            }

            //if (this.Created > order.Created)
            //    return 1;  // value greater than 0 : obj --- this
            //else if (this.Created < order.Created)
            //    return -1; // value less than 0 : this -- obj
            //else
            //    return 0; // value equal to 0 : this/obj

            var result = this.Created.CompareTo(order.Created);
            return result;
        }
    }
}
