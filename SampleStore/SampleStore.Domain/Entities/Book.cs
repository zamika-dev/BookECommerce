namespace SampleStore.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string? ImagePath { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string PublisherName { get; set; } = string.Empty;
        public Guid WriterId { get; set; }
        public Writer Writer { get; set; }
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishDate { get; set; }
        public double Discount { get; set; }
        public string Condition { get; set; } = string.Empty;
        public string Desctiption { get; set; } = string.Empty;
    }
}
