using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
