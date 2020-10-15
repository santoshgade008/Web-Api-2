namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.WebApplication2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.WebApplication2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Contacts.AddOrUpdate(new Contact[] {

              new Contact {Id=0, FirstName = "Andrew",LastName="Peters" },
              new Contact { Id=1,FirstName = "Brice",LastName=" Lambson" },
              new Contact {Id=2, FirstName = "Rowan",LastName=" Miller" }
            });

        }
    }
}
