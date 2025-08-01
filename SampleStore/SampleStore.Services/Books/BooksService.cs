using Microsoft.EntityFrameworkCore;
using SampleStore.DataAccess;

namespace SampleStore.Services.Books
{
    public class BooksService : IBooksService
    {
        private readonly ApplicationDbContext _dbContext;

        public BooksService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<BooksSummaryDto>> GetAllBooksSummery()
        {
            var books =  await _dbContext.Books.Select(book =>
                new BooksSummaryDto()
                {
                    Id = book.Id,
                    BookName = book.BookName,
                    ImagePath = book.ImagePath,
                    CategoryName = book.Category!.CategoryName!,
                    Condition = book.Condition,
                    Price = book.Price,
                    WriterFullName = $"{book.Writer.FirstName} {book.Writer.LastName}"
                }).AsNoTracking()
                .ToListAsync();

            return books;
        }

        public async Task<BookDetailsDto?> GetBooksDetails(Guid bookId)
        {
            var books = await _dbContext.Books
                .Where(i => i.Id == bookId)
                .Select(book =>
                new BookDetailsDto()
                {
                    Id = book.Id,
                    BookName = book.BookName,
                    ImagePath = book.ImagePath,
                    CategoryName = book.Category!.CategoryName!,
                    CategoryId = book.CategoryId,
                    Condition = book.Condition,
                    Price = book.Price,
                    WriterFullName = $"{book.Writer.FirstName} {book.Writer.LastName}",
                    WriterId = book.WriterId,
                    PublishDate = book.PublishDate,
                    PublisherName = book.PublisherName,
                    Description = book.Desctiption
                }).AsNoTracking()
                .FirstOrDefaultAsync();

            return books;
        }
    }
}
