using System;
using Unity.Interfaces;

namespace Unity.Implementations
{

    public class HelloService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello !");
        }
    }

    public class HelloServiceV2 : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello 2!");
        }
    }
}
