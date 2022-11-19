using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer:Person
    {
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
