using System;

namespace InterfaceLabs
{
    public class ServiceB : IService
    {
        public void Handle()
        {
            throw new NotImplementedException();
        }

        //public void Log(string message)
        //{
        //    Console.WriteLine(message);
        //}

        public void Process()
        {
            Console.WriteLine("Service B : Process done");
        }
    }
}
