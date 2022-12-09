using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor: Person, IEntityBase
    {
      //Relationalship
      public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
