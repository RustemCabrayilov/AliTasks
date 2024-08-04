using System.ComponentModel.DataAnnotations.Schema;
using AvtosRestoran.Models.BaseModels;

namespace AvtosRestoran.Models;

public class Slider : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public bool IsActive { get; set; }
    [NotMapped] 
    public IFormFile Image { get; set; }
}