using Microsoft.EntityFrameworkCore;

namespace PhotoGallery.Models
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }

        public DbSet<Resim> Resimler => Set<Resim>();
    }
}
