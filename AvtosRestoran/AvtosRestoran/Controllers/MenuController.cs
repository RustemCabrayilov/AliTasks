using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
