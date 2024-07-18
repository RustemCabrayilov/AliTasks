using Microsoft.AspNetCore.Mvc;

namespace AvtosRestoran.Controllers
{
    public class HomeController : Controller
    {
        //Her bir actionun ozune uygun view si var
        public IActionResult Index()
        {
            return View();
        }
    }
}
