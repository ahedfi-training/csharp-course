using System;

namespace ComposionLabs
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            //var logger = new Logger(); // coupling
            //logger.Log
            _logger.Log($"Migrate starts {DateTime.Now}");
            //......
            Console.WriteLine("Migrate Done");
            _logger.Log($"Migrate ends {DateTime.Now}");
        }
    }
}
