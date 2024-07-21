using AvtosRestoran.Context;
using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AvtosDbContext _context;
        public ServiceController(AvtosDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }
        public IActionResult Booking()
        {
            return View();
        }
    }
}
