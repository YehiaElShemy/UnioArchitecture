using System.ComponentModel.DataAnnotations.Schema;

namespace UnioArchitecture_.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get=>Name;
            set => new HtmlSanitizer
          }
        [ForeignKey(nameof(parentCategory))]
        public int parentId { get; set; }
        public virtual Category? parentCategory { get; set; }
        public virtual List<Category> subCategories { get; set;}=new();
        public virtual List<Product> Products { get; set; } =new();



    }
}