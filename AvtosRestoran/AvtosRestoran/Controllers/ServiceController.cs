using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Booking()
        {
            return View();
        }
    }
}
