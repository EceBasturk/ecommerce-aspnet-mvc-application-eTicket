using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Name")]

        public string FullName { get; set; }

        [Display(Name = "Biography")]

        public string Bio { get; set; }
    }
}
