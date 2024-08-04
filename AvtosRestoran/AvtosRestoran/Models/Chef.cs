using AvtosRestoran.Models.BaseModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvtosRestoran.Models
{
    public class Chef : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public string ImageUrl {  get; set; }

        [NotMapped] // gedib db-ye dusmemesi ucun yazilri
        public IFormFile? Image { get; set; }
    }
}
