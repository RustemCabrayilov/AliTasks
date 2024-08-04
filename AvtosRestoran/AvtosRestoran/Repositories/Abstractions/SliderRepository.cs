using AvtosRestoran.Context;
using AvtosRestoran.Models;
using AvtosRestoran.Repositories.Interfaces;

namespace AvtosRestoran.Repositories.Abstractions;

public class SliderRepository : Repository<Slider> , ISliderRepository
{
    public SliderRepository(AvtosDbContext context) : base(context)
    {
    }
}