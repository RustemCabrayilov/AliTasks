using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace AvtosRestoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemController : Controller
    {
        private readonly IMenuItemRepository _repository;
        private readonly IMenuCategoryRepository _categoryRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public MenuItemController(IMenuItemRepository repository, IMenuCategoryRepository categoryRepository, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var MenuItems = await (await _repository.GetAllAsync(x => !x.IsDeleted)).Include(x=>x.MenuCategory).ToListAsync();
            return View(MenuItems);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ViewBag.Categories = await (await _categoryRepository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(MenuItem MenuItem)
        {
            //file-in adini hazirlayiriq
            string fileName = Guid.NewGuid().ToString() + MenuItem.Image.FileName;

            //file-in upload olunacaq adresi cixaririq

            // https://localhost2121/Images/MenuItems/fileName


            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images/MenuItems", fileName);

            using (FileStream stream = System.IO.File.Open(path, FileMode.CreateNew))
            {
                await MenuItem.Image.CopyToAsync(stream);
            }

            MenuItem.ImageUrl = fileName;
            await _repository.AddAsync(MenuItem);
            await _repository.SaveAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            ViewBag.Categories = await (await _categoryRepository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();

            var MenuItem = await _repository.GetAsync(x => x.Id.ToString() == id);
            return View(MenuItem);
        }
        public async Task<IActionResult> Update(string id, MenuItem MenuItem)
        {
            var updatedMenuItem = await _repository.GetAsync(x => x.Id.ToString() == id);
            if (updatedMenuItem == null)
                return NotFound();

            if (MenuItem.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + MenuItem.Image.FileName;
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images/MenuItems", fileName);

                using (FileStream stream = System.IO.File.Open(path, FileMode.CreateNew))
                {
                    await MenuItem.Image.CopyToAsync(stream);
                }

                updatedMenuItem.ImageUrl = fileName;
            }
            updatedMenuItem.Title = MenuItem.Title;
            updatedMenuItem.Description = MenuItem.Description;
            updatedMenuItem.Price = MenuItem.Price;
            updatedMenuItem.MenuCategoryId = MenuItem.MenuCategoryId;

            _repository.Update(updatedMenuItem);
            await _repository.SaveAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(string id)
        {
            var MenuItem = await _repository.GetAsync(c => c.Id.ToString() == id);

            if (MenuItem == null)
                return NotFound();

            MenuItem.IsDeleted = true;
            await _repository.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}
