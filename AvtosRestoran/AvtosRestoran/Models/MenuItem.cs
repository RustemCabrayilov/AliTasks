using AvtosRestoran.Models.BaseModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvtosRestoran.Models
{
    public class MenuItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public Guid MenuCategoryId { get; set; }
        public MenuCategory MenuCategory { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
       
    }
}
