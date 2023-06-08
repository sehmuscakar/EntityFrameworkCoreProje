using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreProje.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // override on dee bu yapı gelecek 
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PBFD0LU;  database=EFCoreDB; integrated security=true; TrustServerCertificate=true ");//catalog yerine database de diyebilirsin 
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Fluent Api ile Tablo ve Kolon Özelliklerini Belirleme
        {
            modelBuilder.Entity<Brand>().Property(b=>b.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            modelBuilder.Entity<Product>().HasOne(p=>p.Brand).WithMany(p=>p.Products).HasForeignKey(p=>p.BrandId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
