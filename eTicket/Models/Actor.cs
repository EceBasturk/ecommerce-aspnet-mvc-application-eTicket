using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor: Person
    {
      //Relationalship
      public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
