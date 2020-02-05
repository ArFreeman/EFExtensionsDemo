using EFExtensions.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EFExtensions.Migrations
{
    using System.Data.Entity.Migrations;

    [ExcludeFromCodeCoverage]
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled        = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var heroes = new List<Hero> {new Hero {FirstName = "Bruce", LastName = "Wayne"}, new Hero {FirstName = "Harley", LastName = "Quinn"}};
            context.Heroes.AddRange(heroes);
            context.SaveChanges();
        }
    }
}
