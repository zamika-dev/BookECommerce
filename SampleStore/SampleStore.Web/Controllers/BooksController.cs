using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleStore.Services.Books;
using SampleStore.Services.ShoppingCarts;
using SampleStore.Web.Models;

namespace SampleStore.Web.Controllers
{
    [AllowAnonymous]
    public class BooksController : BaseController
    {
        private readonly IBooksService _booksService;
        private readonly IShoppingCartService _shoppingCartService;


        public BooksController(IBooksService booksService, IShoppingCartService shoppingCartService)
        {
            _booksService = booksService;
            _shoppingCartService = shoppingCartService;
        }

        public async Task<IActionResult> Books()
        {
            var books = await _booksService.GetAllBooksSummery();
            return View(books);
        }

        [HttpGet]
        public async Task<IActionResult> BookDetails(Guid id)
        {
            BookDetailsDto? bookDetails = await _booksService.GetBooksDetails(id);
            if (bookDetails == null)
                return NotFound();

            int bookCount = 0;

            var userId = UserClaims?.Id;
            if (userId != null)
            {
                var shoppingCartDto = await _shoppingCartService.GetShoppingCart(userId.Value, bookDetails.Id);
                bookCount = shoppingCartDto == null ? bookCount : shoppingCartDto.Count;
            }

            var bookDetailsViewModel = new BookDetailsViewModel
            {
                Book = bookDetails,
                Count = bookCount
            };
            return View(bookDetailsViewModel);
        }
    }
}
