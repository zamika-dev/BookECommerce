using SampleStore.Domain.Entities;

namespace SampleStore.Services.Books
{
    public class BookDetailsDto
    {
        public Guid Id { get; set; }
        public string? ImagePath { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string PublisherName { get; set; } = string.Empty;
        public Guid WriterId { get; set; }
        public string WriterFullName { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid ProvinceId { get; set; }
        public Province? Province { get; set; }
        public string Condition { get; set; } = string.Empty;
        public string Description { get; set; }
        public double Discount { get; set; }
    }
}
