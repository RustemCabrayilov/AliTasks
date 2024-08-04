using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;

namespace AvtosRestoran.Repositories.Abstractions;

public class ChefRepository : Repository<Chef>, IChefRepository //dependency injectionu yaratmaq ucun yazilir
{
    public ChefRepository(AvtosDbContext context) : base(context)
    {
    }
}