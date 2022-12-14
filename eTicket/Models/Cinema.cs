using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Cinema : IEntityBase
    { 
        [Key]
        public int Id { get; set; }

        [Display(Name = "Salon")]
        public string Logo { get; set; }

        [Display(Name ="Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]

        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
