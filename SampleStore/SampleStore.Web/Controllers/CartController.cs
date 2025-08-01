using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleStore.Services.ShoppingCart;
using SampleStore.Services.ShoppingCarts;
using SampleStore.Web.Models.Cart;

namespace SampleStore.Web.Controllers
{
    [Authorize(Roles ="Customer")]
    public class CartController : BaseController
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly ICartCalculationService _cartCalculationService;

        public CartController(IShoppingCartService shoppingCartService, ICartCalculationService cartCalculationService)
        {
            _shoppingCartService = shoppingCartService;
            _cartCalculationService = cartCalculationService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdateCountByUserAndBook(ShoppingCartInputModel model)
        {
            var userId = UserClaims?.Id;

            if (!IsAuthenticated && userId == null)
                return RedirectToAction("Login", "Account");

            var shoppingCart = new ShoppingCartAddOrUpdateDto
            {
                BookId = model.BookId,
                Count = model.Count,
                UserId = userId!.Value,
            };

            await _shoppingCartService.AddToCartOrUpdateIfExistAsync(shoppingCart);

            return RedirectToAction("BookDetails", "Books", new { id = model.BookId });
        }

        public async Task<IActionResult> CartItems()
        {
            var userId = UserClaims?.Id;
            if(userId == null)
                throw new ArgumentNullException(nameof(userId));

            var cartSummary = await _cartCalculationService.GetCartSummaryAsync(userId.Value);

            if (cartSummary.shoppingCartItems!.Count == 0)
                return RedirectToAction(nameof(EmptyCart));

            var shoppingCartViewModel = new ShoppingCartDetailsViewModel
            {
                shoppingCartItems = cartSummary.shoppingCartItems,
                OrderTotal = cartSummary.OrderTotal,
                PostPrice = 100,
                Discount = cartSummary.Discount
            };

            return View(shoppingCartViewModel);
        }

        public IActionResult EmptyCart()
        {
            return View();
        }

        public async Task<IActionResult> UpdateCountByCartId(Guid cartId, int delta)
        {
            await _shoppingCartService.UpdateCartCount(cartId, delta);
            return RedirectToAction(nameof(CartItems));
        }

        public async Task<IActionResult> CheckoutAddress()
        {
            var userId = UserClaims?.Id;
            if (userId == null)
                throw new ArgumentNullException(nameof(userId));

            var cartCalculationDto = await _cartCalculationService.GetCartSummaryAsync(userId.Value);
            var checkoutViewModel = new CheckoutAddressViewModel
            {
                OrderTotal = cartCalculationDto.OrderTotal,
                PostPrice = 100,
                Discount = cartCalculationDto.Discount
            };
            return View(checkoutViewModel);
        }
    }
}
