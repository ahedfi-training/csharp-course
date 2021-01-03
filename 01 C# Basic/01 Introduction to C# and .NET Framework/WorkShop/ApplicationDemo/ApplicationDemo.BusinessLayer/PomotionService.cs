using System;

namespace ApplicationDemo.BusinessLayer
{
    public class PomotionService
    {
        public double Reduce(double amount)
        {
            Console.WriteLine("Reduce is starting ...");
            return amount - (amount * 0.1);
        }
    }
}
