namespace InterfaceLabs
{
    public class ServiceManager
    {
        private readonly IService _service;

        public ServiceManager(IService service)
        {
            _service = service;
        }

        public void Start()
        {
            _service.Process();
        }
    }
}
