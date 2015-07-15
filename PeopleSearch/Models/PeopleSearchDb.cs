using System.Data.Entity;

/*Enitity First Implementation for the Person model */
namespace PeopleSearch.Models
{
    public class PeopleSearchDb : DbContext
    {
        public PeopleSearchDb()
            : base("name=DefaultConnection")
        {

        }
        public DbSet<Person> People { get; set; }
    }
}