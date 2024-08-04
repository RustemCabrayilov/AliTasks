using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;

namespace AvtosRestoran.Repositories.Abstractions;

public class MenuCategoryRepository : Repository<MenuCategory>, IMenuCategoryRepository
{
    public MenuCategoryRepository(AvtosDbContext context) : base(context)
    {
    }
}