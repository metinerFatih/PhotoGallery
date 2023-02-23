using System.ComponentModel.DataAnnotations;

namespace PhotoGallery.Attributes
{
    public class GecerliResimAttribute : ValidationAttribute
    {
        public int MaksDosyaBoyutuMb { get; set; }

        public override bool IsValid(object? value)
        {
            IFormFile? file = value as IFormFile;

            if (file == null)
                return true;

            if (MaksDosyaBoyutuMb > 0 && file.Length > MaksDosyaBoyutuMb * 1024 * 1024)
            {
                ErrorMessage = $"Dosya boyutu{MaksDosyaBoyutuMb} MB'dan büyük";
                return false;
            }
            else if (file.ContentType.StartsWith("image/"))
            {
                ErrorMessage = "Geçersiz resim formatı.";
                return false;
            }

            return true;
        }
    }
}
