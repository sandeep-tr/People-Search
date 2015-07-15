using System.Collections.Generic;

/*Data model for the Search Results*/
namespace PeopleSearch.Models
{
    public class PeopleListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public PersonAddress Address { get; set; }
        public ICollection<PersonInterest> Interests { get; set; }
    }
}