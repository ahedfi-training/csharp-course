using Unity.Interfaces;

namespace Unity.Implementations
{
    public class Shell : IShell
    {
        private readonly IGreetingService _greetingService;

        public Shell(IGreetingService serviceManager)
        {
            _greetingService = serviceManager;
        }
        public void Start()
        {
            _greetingService.DisplayGreetingMsg();
        }
    }
}
