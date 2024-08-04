using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;

namespace AvtosRestoran.Repositories.Abstractions;

public class MenuItemRepository : Repository<MenuItem>,IMenuItemRepository
{
    public MenuItemRepository(AvtosDbContext context) : base(context)
    {
    }
}