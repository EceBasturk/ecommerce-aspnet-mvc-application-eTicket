using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class SalonsController : Controller
    {
        private readonly AppDbContext _context;
        public SalonsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allSalons = await _context.Salons.ToListAsync(); ;
            return View(allSalons);
        }
    }
}
