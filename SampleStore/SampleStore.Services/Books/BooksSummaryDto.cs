namespace SampleStore.Services.Books
{
    public class BooksSummaryDto
    {
        public Guid Id { get; set; }
        public string? ImagePath { get; set; }
        public string BookName { get; set; } = string.Empty;
        public string PublisherName { get; set; } = string.Empty;
        public string WriterFullName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Condition { get; set; }
    }
}

