namespace SampleStore.Services.ShoppingCarts
{
    public class CartCalculationService : ICartCalculationService
    {
        private readonly IShoppingCartService _shoppingCartService;

        public CartCalculationService(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public async Task<CartCalculationDto> GetCartSummaryAsync(Guid userId)
        {
            var items = await _shoppingCartService.GetShoppingCartItems(userId);

            double total = 0, discount = 0;
            foreach (var item in items)
            {
                total += item.Book.Price * item.Count;
                discount += item.Book.Discount * item.Count;
            }

            return new CartCalculationDto
            {
                shoppingCartItems = items,
                OrderTotal = total,
                Discount = discount,
                PostPrice = 100
            };
        }
    }
}
