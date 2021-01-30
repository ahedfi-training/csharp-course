using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Implementations;
using Unity.Interfaces;

namespace Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            //var serviceHello = new HelloService();
            //var greetingService = new GreetingService(serviceHello);
            //var shell = new Shell(greetingService);
            //shell.Start();
            // IOC : Inversion of control -> 
            // IOC Container : Unity, Autofac, Ninja,casltle windsor



            var unityContainer = new UnityContainer();

            var container = new Container(unityContainer);
            container.RegisterTypes();

            var shell = unityContainer.Resolve<IShell>();
            var greetingservice = unityContainer.Resolve<IGreetingService>();
            shell.Start();
        }
    }
}
