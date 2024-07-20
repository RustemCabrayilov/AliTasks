using AvtosRestoran.Context;
using AvtosRestoran.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Controllers
{
    public class TestController : Controller
    {
        private readonly AvtosDbContext _context;

        public TestController(AvtosDbContext context)
        {
            _context = context;
        }

        public IActionResult Ali()
        {
            //List<Service> services = new List<Service>()
            //{
            //    new()
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "Dine-In Service",
            //        Icon =  "fa-utensils",
            //        Description = "Traditional table service where guests are seated, given menus, and served food and beverages at their table.",
            //        CreateAt = DateTime.Now,
            //    },
            //    new()
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "Takeout Service",
            //         Icon =  "fa-utensils",
            //        Description = "Customers order food and pick it up from the restaurant to eat elsewhere. This can include phone orders, online orders, or walk-in orders.",
            //        CreateAt = DateTime.Now,
            //    },
            //    new()
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "Delivery Service",
            //         Icon =  "fa-utensils",
            //        Description = "Food is delivered directly to the customer's location. This service can be provided by the restaurant itself or through third-party delivery platforms.",
            //        CreateAt = DateTime.Now,
            //    }
            //,
            //    new()
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "Catering Service",
            //         Icon =  "fa-utensils",
            //        Description = "Providing food and beverages for events such as parties, weddings, and corporate functions. This can include full-service catering with staff or drop-off catering.",
            //        CreateAt = DateTime.Now,
            //    },
            //    new()
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "Online Ordering",
            //         Icon =  "fa-utensils",
            //        Description = "A digital platform where customers can browse the menu, place orders, and make payments online, either for delivery or takeout.",
            //        CreateAt = DateTime.Now,
            //    },
            //    new()
            //    {
            //        Id = Guid.NewGuid(),
            //        Title = "Drive-Thru Service",
            //         Icon =  "fa-utensils",
            //        Description = "A convenient service where customers can order, pay for, and receive their food without leaving their vehicles. This is common in fast-food and quick-service restaurants.",
            //        CreateAt = DateTime.Now,
            //    }
            //};
            //_context.Services.AddRange(services);

            //_context.SaveChanges();
            return Ok();
        }
        //[ActionName("Salam")]
        //[NonAction]
        public IActionResult Ali2(int id)
        {
            return View();
            //return Content("sdasda");
            //return Json(new { id=id,name="Ali",surname="Agayev" });
            //return Redirect("https://www.google.com");
            //return RedirectToRoute("Index", "Home");
            //return RedirectToAction("Index", "Home");
        }
    }
}
