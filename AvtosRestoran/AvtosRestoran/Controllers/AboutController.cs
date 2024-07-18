using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
