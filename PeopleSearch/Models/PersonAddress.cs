using System.ComponentModel.DataAnnotations;

/*Sub model of Person object. Stores address of a person.*/
namespace PeopleSearch.Models
{
    public class PersonAddress
    {
        [StringLength(255)]
        public string Street { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(25)]
        public string State { get; set; }
    }
}