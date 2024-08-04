using AvtosRestoran.Models;

namespace AvtosRestoran.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; } = new();
        public List<Chef> Chefs { get; set; } = new();
        public List<MenuCategory> MenuCategories { get; set; } = new();
        public List<MenuItem> MenuItems { get; set; } = new();
        public List<Slider> Sliders { get; set; } = new();
    }
}
