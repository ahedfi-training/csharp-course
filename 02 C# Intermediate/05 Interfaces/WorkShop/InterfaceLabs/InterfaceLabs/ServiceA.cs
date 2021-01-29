using System;

namespace InterfaceLabs
{
    //public class ServiceA : IService, ILog , IBaseService
    public class ServiceA : IService, ILog
    {
        public void Process()
        {
            Console.WriteLine("Service A : Process done");
        }

        public void CustomProcess()
        {
            Console.WriteLine("Custom Process");
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Handle()
        {
            throw new NotImplementedException();
        }
    }
}
