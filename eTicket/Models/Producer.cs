using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer:Person, IEntityBase
    {
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
