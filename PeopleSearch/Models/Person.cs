using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*Person model. Has One to Many Mappings to PersonInterest model*/
namespace PeopleSearch.Models
{
    public class Person
    {
        // -- defualt values for the model
        public Person()
        {
            ImageId = 0;
            ImageExtension = "jpg";
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Index("PSFirstNameIndex")] 
        public string FirstName { get; set; }
        [StringLength(255)]
        [Index("PSLastNameIndex")] 
        public string LastName { get; set; }
        [Range(0, 130)]
        public int Age { get; set; }
        public int ImageId { get; set; }
        [StringLength(5)]
        public string ImageExtension { get; set; }
        public virtual PersonAddress Address { get; set; }
        public virtual ICollection<PersonInterest> Interests { get; set; }
    }
}