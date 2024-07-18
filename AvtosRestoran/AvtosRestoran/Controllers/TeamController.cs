using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
