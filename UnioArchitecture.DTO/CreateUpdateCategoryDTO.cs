namespace UnioArchitecture.DTO
{
    public class CreateUpdateCategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int parentId { get; set; }
    }
}