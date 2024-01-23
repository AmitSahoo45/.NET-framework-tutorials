using System;

namespace CompositionEg
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log(string.Format("We are Migrating............"));
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger log)
        {
            _logger = log;
        }

        public void Install()
        {
            _logger.Log(string.Format("Installing the application.........."));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMig = new DBMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMig.Migrate();

            installer.Install();
        }
    }
}