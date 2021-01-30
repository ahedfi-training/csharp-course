using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interfaces;

namespace Unity.Implementations
{
    //public class Message
    //{
    //    public string Content { get; set; }
    //}
    public class GreetingService : IGreetingService
    {
        private readonly IHelloService _service;

        //public TimeSpan Expiration { get; set; }
        public GreetingService([Dependency("v2")] IHelloService service)
        {
            _service = service;
        }
        public void DisplayGreetingMsg()
        {
            //var serviceHello = new HelloService();
            //serviceHello.SayHello();
            _service.SayHello();
        }
    }
}
