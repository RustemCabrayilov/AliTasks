using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvtosRestoran.Controllers
{
    public class TeamController : Controller
    {
        private readonly IChefRepository _repository;

        public TeamController(IChefRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var chefs = await (await _repository.GetAllAsync(x => !x.IsDeleted)).ToListAsync();
            return View(chefs);
        }
    }
}
