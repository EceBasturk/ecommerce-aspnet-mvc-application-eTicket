using eTicket.Models;
using eTickets.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }

    }
}