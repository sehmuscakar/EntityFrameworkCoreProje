namespace EntityFrameworkCoreProje.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } //boş geçilebeilir
        public IEnumerable<Product> Products { get; set; } //IEnumerable yerine IList de yazabilirdin 
    }
}
