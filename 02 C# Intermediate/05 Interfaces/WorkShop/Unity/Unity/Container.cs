using Unity.Implementations;
using Unity.Interfaces;

namespace Unity
{
    public class Container
    {
        private readonly UnityContainer _unityContainer;

        public Container(UnityContainer unityContainer)
        {
           _unityContainer = unityContainer;
        }

        public void RegisterTypes()
        {
            _unityContainer.RegisterType<IHelloService, HelloService>();
            _unityContainer.RegisterType<IHelloService, HelloServiceV2>("v2");
            _unityContainer.RegisterType<IGreetingService, GreetingService>();
            _unityContainer.RegisterType<IShell, Shell>();
        }
    }
}
