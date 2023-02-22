using System.ComponentModel.DataAnnotations;

namespace PhotoGallery.Models
{
    public class ResimViewModel
    {
        [MaxLength(100)]
        public string Baslik { get; set; } = string.Empty;

        public IFormFile Dosya { get; set; } = null!;
    }
}
