using System;

namespace ComposionLabs
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Setup()
        {
            _logger.Log($"Setup starts {DateTime.Now}");
            //......
            Console.WriteLine("Setup Done");
            _logger.Log($"Setup ends {DateTime.Now}");
        }
    }
}
