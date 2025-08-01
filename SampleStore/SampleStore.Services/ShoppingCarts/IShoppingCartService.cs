using SampleStore.Services.ShoppingCart;

namespace SampleStore.Services.ShoppingCarts
{
    public interface IShoppingCartService
    {
        Task<bool> AddToCartOrUpdateIfExistAsync(ShoppingCartAddOrUpdateDto shoppingCardRequest);
        Task<ShoppingCartItemDto?> GetShoppingCart(Guid userId, Guid bookId);
        Task<List<ShoppingCartItemDto>?> GetShoppingCartItems(Guid userId);
        Task UpdateCartCount(Guid cartId, int delta);
    }
}
