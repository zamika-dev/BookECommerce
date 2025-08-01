namespace SampleStore.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}
