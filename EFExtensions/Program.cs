using EFExtensions.Entities;

namespace EFExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationContext();
            context.Heroes.InsertFromQuery("Villains", hero => new {hero.FirstName, hero.LastName});
            context.SaveChanges();
        }
    }
}