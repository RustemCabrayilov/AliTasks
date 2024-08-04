using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace AvtosRestoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChefController : Controller
    {
        private readonly IChefRepository _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ChefController(IChefRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var chefs = await (await _repository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();
            return View(chefs);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Chef chef)
        {
            //file-in adini hazirlayiriq
            string fileName = Guid.NewGuid().ToString() + chef.Image.FileName;

            //file-in upload olunacaq adresi cixaririq

            // https://localhost2121/Images/Chefs/fileName


            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images/Chefs", fileName);

            using (FileStream stream = System.IO.File.Open(path, FileMode.CreateNew))
            {
                await chef.Image.CopyToAsync(stream);
            }

            chef.ImageUrl = fileName;
            await _repository.AddAsync(chef);
            await _repository.SaveAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var chef = await _repository.GetAsync(x => x.Id.ToString() == id);
            return View(chef);
        }
        public async Task<IActionResult> Update(string id, Chef chef)
        {
            var updatedChef = await _repository.GetAsync(x => x.Id.ToString() == id);
            if (updatedChef == null)
                return NotFound();

            if (chef.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + chef.Image.FileName;
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images/Chefs", fileName);

                using (FileStream stream = System.IO.File.Open(path, FileMode.CreateNew))
                {
                    await chef.Image.CopyToAsync(stream);
                }

                updatedChef.ImageUrl = fileName;
            }

            updatedChef.Surname = chef.Surname;
            updatedChef.Position = chef.Position;
            updatedChef.Name = chef.Name;
            _repository.Update(updatedChef);
            await _repository.SaveAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(string id)
        {
            var chef = await _repository.GetAsync(c => c.Id.ToString() == id);

            if (chef == null)
                return NotFound();

            chef.IsDeleted = true;
            await _repository.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}
