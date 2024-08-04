using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using AvtosRestoran.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuCategoryRepository _repository;
        private readonly IMenuItemRepository _menuItemRepository;


        public MenuController(IMenuCategoryRepository repository, IMenuItemRepository menuItemRepository)
        {
            _repository = repository;
            _menuItemRepository = menuItemRepository;
        }

        public async Task<IActionResult> Index()
        {
            MenuViewModel model = new MenuViewModel()
            {
                MenuCategories = await (await _repository.GetAllAsync(x => !x.IsDeleted)).ToListAsync(),
                MenuItems = await (await _menuItemRepository.GetAllAsync(x => !x.IsDeleted)).ToListAsync()
            };

            return View(model);
        }
    }
}
