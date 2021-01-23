namespace ComposionLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var installer = new Installer(logger);
            var dbMigrator = new DbMigrator(logger);
            installer.Setup();
            dbMigrator.Migrate();
        }
    }
}
