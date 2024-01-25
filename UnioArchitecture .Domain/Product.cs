using System.ComponentModel.DataAnnotations.Schema;

namespace UnioArchitecture_.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Image> Images { get; set; } = new List<Image>();

    }
}