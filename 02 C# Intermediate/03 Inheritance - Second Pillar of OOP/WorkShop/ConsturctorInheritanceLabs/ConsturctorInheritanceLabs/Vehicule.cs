using System;

namespace ConsturctorInheritanceLabs
{
    public class Vehicule
    {
        private string _registrationNumber;

        public Vehicule(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }

        protected void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLongDateString()} : {message}");
        }
    }
}
