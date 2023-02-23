using PhotoGallery.Attributes;
using System.ComponentModel.DataAnnotations;

namespace PhotoGallery.Models
{
    public class ResimViewModel
    {
        [MaxLength(100, ErrorMessage ="{0} alanı en fazla {1} karakterden oluşabilir.")]
        [Required(ErrorMessage ="{0} alanı zorunludur.")]
        [Display(Name = "Başlık")]
        public string Baslik { get; set; } = string.Empty;
        [GecerliResim(MaksDosyaBoyutuMb = 1)]
        [Display(Name = "Resim")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public IFormFile Dosya { get; set; } = null!;

        public List<Resim> Resimler { get; set; } = new();
    }
}
