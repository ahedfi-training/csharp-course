using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLabs
{
    class Program
    {
        public static void Start(IService service)
        {
            service.Process();
        }
        static void Main(string[] args)
        {
            var serviceA = new ServiceA();
            var serviceB = new ServiceB();
            var serviceC = new ServiceC();

            serviceA.Handle();
            serviceA.Process();

            IService iservice = serviceA;
            iservice.Process();
            iservice = serviceB;
            iservice.Process();
            //iservice = serviceC; Error: ServiceC does not implement IService 
            Start(serviceA);
            Start(serviceB);
            //Start(serviceC);

            var serviceManager = new ServiceManager(serviceA);
            serviceManager.Start();

            //IService service = serviceA;
            IService service = serviceB;
            //var serviceImpl = (ILog) service;
            var serviceImplV2 = service as ILog;
            if (serviceImplV2 != null)
                serviceImplV2.Log("hello");
            if (service is ILog)
            {
                var serviceImplv2 = (ILog)service;
                serviceImplv2.Log("hi");
            }

            //serviceImpl.Log("ididi");
            //IService serviceImpl2 = service;
            //serviceImpl2.Process();
            //service.Process();
            //service.CustomProcess();
        }
    }
}
