using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreProje.Models
{
    [Table("Urunler")]// tablo ismi artık Urunlar olarak değiştirebilirsin

    public class Product// ürün tekli 
    {
        [Key]//birincil anahtar olarak değiştirildi
        public int Id { get; set; }
        [StringLength(50)]// 50 karkter uzunluğunda izin verdik
        public string Name { get; set; }
        public string? Description { get; set; }

        [Column("UrunResmi",TypeName ="Varchar")]// column özeliklerini verdik
        [MaxLength(50)]
        public string? Image { get; set; }
        public decimal Price { get; set; }

        [NotMapped]//Stock veritabanına işlemez entityframeworkcore görmezden geldi
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; } //buraya soru işareti eklemeyi unutma 

        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
}
}
