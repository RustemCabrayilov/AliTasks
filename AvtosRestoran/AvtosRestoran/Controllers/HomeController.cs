using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using AvtosRestoran.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IChefRepository _chefRepository;
        private readonly IMenuCategoryRepository _menuCategoryRepository;
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly ISliderRepository _sliderRepository;

        public HomeController(IServiceRepository serviceRepository, IChefRepository chefRepository, IMenuCategoryRepository menuCategoryRepository, IMenuItemRepository menuItemRepository, ISliderRepository sliderRepository)
        {
            _serviceRepository = serviceRepository;
            _chefRepository = chefRepository;
            _menuCategoryRepository = menuCategoryRepository;
            _menuItemRepository = menuItemRepository;
            _sliderRepository = sliderRepository;
        }

        //Her bir actionun ozune uygun view si var
        public async Task<IActionResult> Index()
        {
            var services = await (await _serviceRepository.GetAllAsync(x => !x.IsDeleted)).Take(4).ToListAsync();
            var chefs = await (await _chefRepository.GetAllAsync(x => !x.IsDeleted)).Take(4).ToListAsync();
            var categories = await (await _menuCategoryRepository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();
            var items = await (await _menuItemRepository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();
            var sliders = await (await _sliderRepository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();

            HomeViewModel model = new HomeViewModel()
            {
                Services = services,
                Chefs = chefs,
                MenuCategories = categories,
                MenuItems = items,
                Sliders = sliders
            };

            return View(model);
        }
    }
}
