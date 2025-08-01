namespace SampleStore.Services.Books
{
    public interface IBooksService
    {
        Task<List<BooksSummaryDto>> GetAllBooksSummery();

        Task<BookDetailsDto?> GetBooksDetails(Guid bookId);
    }
}
