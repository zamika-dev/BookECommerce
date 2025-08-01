using SampleStore.Services.Books;

namespace SampleStore.Web.Models
{
    public class BookDetailsViewModel
    {
        public BookDetailsDto Book { get; set; } = default!;
        public int Count { get; set; } = 1;
    }
}
