using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IRepository<Service> _serviceRepo;

        public ServiceController(IRepository<Service> serviceRepo)
        {
            _serviceRepo = serviceRepo;
        }

        public async Task<IActionResult> Index()
        {
            var result = await (await _serviceRepo.GetAllAsync(s => !s.IsDeleted)).ToListAsync();

            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Service service)
        {
            await _serviceRepo.AddAsync(service);
            await _serviceRepo.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}
