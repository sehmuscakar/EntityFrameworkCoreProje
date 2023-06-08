using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCoreProje.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50)]// 50 karkter uzunluğunda izin verdik
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } //coklu olacak,IList kullanabilirsin 
    }
}
