using MySql.Data.Entity;
using System.Data.Entity;

namespace EFExtensions.Entities
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }

        public DbSet<Villain> Villains { get; set; }

        public ApplicationContext() : base("name=ApplicationContext")
        {

        }
    }
}
