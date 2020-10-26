using System.Data.Entity.Migrations;

namespace OnlineStore.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<OnlineStoreContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }
    }
}
