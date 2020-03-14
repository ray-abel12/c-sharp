using System;

namespace Composition
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
            Console.WriteLine("we are migrating bla blabla");
        }
    }
}