using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _serviceRepo;

        public ServiceController(IServiceRepository serviceRepo)
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
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var entity = await _serviceRepo.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if (entity is null)
            {
                return NotFound();
            }
            return View(entity);    
        }
        public async Task<IActionResult> Update(string id,Service service)
        {
            var entity = await _serviceRepo.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if (entity is null)
            {
                return NotFound();
            }
            entity.Title = service.Title;
            entity.Description = service.Description;
            entity.Icon = service.Icon;
            _serviceRepo.Update(entity);
            await _serviceRepo.SaveAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var entity = await _serviceRepo.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if (entity is null)
            {
                return NotFound();
            }
            entity.IsDeleted = true;
            _serviceRepo.Update(entity);
            await _serviceRepo.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}
