using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyonu.Entities
{
    public class KutuphaneContext : DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<OduncIslem> OduncIslemleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KutuphaneDb;Trusted_Connection=True;");
        }
    }
}