using System.ComponentModel.DataAnnotations.Schema;

namespace UnioArchitecture_.Domain
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Size { get; set; }
        public string Type { get; set; } = string.Empty;

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }=default!;


    }
}