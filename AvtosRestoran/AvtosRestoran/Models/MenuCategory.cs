using AvtosRestoran.Models.BaseModels;

namespace AvtosRestoran.Models
{
    public class MenuCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}
