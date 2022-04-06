using System.Data.Entity.Migrations;

namespace SysPerson.Repository.Migrations
{
    public class Configuration : DbMigrationsConfiguration<SysPersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}
