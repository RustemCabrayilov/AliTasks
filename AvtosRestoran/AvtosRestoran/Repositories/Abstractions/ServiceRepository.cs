using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;

namespace AvtosRestoran.Repositories.Abstractions;

public class ServiceRepository : Repository<Service>,IServiceRepository
{
    public ServiceRepository(AvtosDbContext context) : base(context)
    {
    }
}