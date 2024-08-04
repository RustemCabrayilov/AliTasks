using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuCategoryController : Controller
    {
        private readonly IMenuCategoryRepository _MenuCategoryRepo;

        public MenuCategoryController(IMenuCategoryRepository MenuCategoryRepo)
        {
            _MenuCategoryRepo = MenuCategoryRepo;
        }

        public async Task<IActionResult> Index()
        {
            var result = await (await _MenuCategoryRepo.GetAllAsync(s => !s.IsDeleted)).ToListAsync();

            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(MenuCategory MenuCategory)
        {
            await _MenuCategoryRepo.AddAsync(MenuCategory);
            await _MenuCategoryRepo.SaveAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var entity = await _MenuCategoryRepo.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if (entity is null)
            {
                return NotFound();
            }
            return View(entity);    
        }
        public async Task<IActionResult> Update(string id,MenuCategory MenuCategory)
        {
            var entity = await _MenuCategoryRepo.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if (entity is null)
            {
                return NotFound();
            }
            entity.Name = MenuCategory.Name;
            entity.Icon = MenuCategory.Icon;
            _MenuCategoryRepo.Update(entity);
            await _MenuCategoryRepo.SaveAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            var entity = await _MenuCategoryRepo.GetAsync(x => x.Id.ToString() == id && !x.IsDeleted);
            if (entity is null)
            {
                return NotFound();
            }
            entity.IsDeleted = true;
            _MenuCategoryRepo.Update(entity);
            await _MenuCategoryRepo.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}
