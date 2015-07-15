using System.ComponentModel.DataAnnotations;

/*Person Interest model. Has dependency on Person model.*/
namespace PeopleSearch.Models
{
    public class PersonInterest
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Interest { get; set; }
        [Required]
        public int PersonId { get; set; }
    }
}