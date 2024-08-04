using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace AvtosRestoran.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderRepository _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SliderController(ISliderRepository repository, IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var Sliders = await (await _repository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();
            return View(Sliders);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Slider Slider)
        {
            //file-in adini hazirlayiriq
            string fileName = Guid.NewGuid().ToString() + Slider.Image.FileName;

            //file-in upload olunacaq adresi cixaririq

            // https://localhost2121/Images/Sliders/fileName


            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images/Sliders", fileName);

            using (FileStream stream = System.IO.File.Open(path, FileMode.CreateNew))
            {
                await Slider.Image.CopyToAsync(stream);
            }

            Slider.ImageUrl = fileName;
            await _repository.AddAsync(Slider);
            await _repository.SaveAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var Slider = await _repository.GetAsync(x => x.Id.ToString() == id);
            return View(Slider);
        }
        public async Task<IActionResult> Update(string id, Slider Slider)
        {
            var updatedSlider = await _repository.GetAsync(x => x.Id.ToString() == id);
            if (updatedSlider == null)
                return NotFound();

            if (Slider.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + Slider.Image.FileName;
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Images/Sliders", fileName);

                using (FileStream stream = System.IO.File.Open(path, FileMode.CreateNew))
                {
                    await Slider.Image.CopyToAsync(stream);
                }

                updatedSlider.ImageUrl = fileName;
            }

            updatedSlider.Description = Slider.Description;
            updatedSlider.Title = Slider.Title;
            updatedSlider.IsActive = Slider.IsActive;
            _repository.Update(updatedSlider);
            await _repository.SaveAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(string id)
        {
            var Slider = await _repository.GetAsync(c => c.Id.ToString() == id);

            if (Slider == null)
                return NotFound();

            Slider.IsDeleted = true;
            await _repository.SaveAsync();
            return RedirectToAction("Index");
        }
    }
}
