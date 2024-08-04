using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _repository;

        public ServiceController(IServiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
           var services = await (await _repository.GetAllAsync(x=>!x.IsDeleted)).ToListAsync();
            return View(services);
        }
        public IActionResult Booking()
        {
            return View();
        }
    }
}
