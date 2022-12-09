using eTicket.Models;
using eTicket.Data.Base;
using eTicket.Data.Services;

namespace eTicket.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}