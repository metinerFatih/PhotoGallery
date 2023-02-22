using System.ComponentModel.DataAnnotations;

namespace PhotoGallery.Models
{
    public class Resim
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Baslik { get; set; } = string.Empty;

        [MaxLength(255)]
        [Required]
        public string DosyaAd { get; set; } = string.Empty;
    }
}
