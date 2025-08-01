using Microsoft.EntityFrameworkCore;
using SampleStore.DataAccess;
using SampleStore.Services.ShoppingCarts;

namespace SampleStore.Services.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly ApplicationDbContext _dbContext;

        public ShoppingCartService(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<bool> AddToCartOrUpdateIfExistAsync(ShoppingCartAddOrUpdateDto shoppingCardRequest)
        {
            if(shoppingCardRequest == null)
                return false;

            if (shoppingCardRequest.UserId == Guid.Empty || shoppingCardRequest.BookId == Guid.Empty)
                return false;

            var cartItem = await _dbContext.ShoppingCarts.Where(sc => sc.BookId == shoppingCardRequest.BookId &&
            sc.ApplicationUserId == shoppingCardRequest.UserId).FirstOrDefaultAsync();
            
            if (cartItem != null)
            {
                if(cartItem.Count + shoppingCardRequest.Count > 0)
                {
                    cartItem.Count += shoppingCardRequest.Count;
                    _dbContext.ShoppingCarts.Update(cartItem);
                }
                else
                {
                    cartItem.Count += shoppingCardRequest.Count;
                    _dbContext.ShoppingCarts.Remove(cartItem);
                }
            }
            else
            {
                var shoppingCart = shoppingCardRequest.ToShoppingCard();
                _dbContext.ShoppingCarts.Add(shoppingCart);
            }

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<ShoppingCartItemDto?> GetShoppingCart(Guid userId, Guid bookId)
        {
            return await _dbContext.ShoppingCarts.Where(sc => sc.ApplicationUserId == userId && sc.BookId == bookId)
                .Select(item => new ShoppingCartItemDto {
                    Id = item.Id,
                    Book = item.Book,
                    Count = item.Count
                })
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<List<ShoppingCartItemDto>?> GetShoppingCartItems(Guid userId)
        {
            return await _dbContext.ShoppingCarts.Where(sc => sc.ApplicationUserId == userId)
                .Select(item => new ShoppingCartItemDto
                {
                    Id = item.Id,
                    Book = item.Book,
                    Count = item.Count
                })
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task UpdateCartCount(Guid cartId, int delta)
        {
            var cartItem = await _dbContext.ShoppingCarts.Where(cart => cart.Id == cartId).FirstOrDefaultAsync();
            if(cartItem == null)
                throw new NullReferenceException();
            
            if(cartItem.Count + delta > 0)
            {
                cartItem.Count += delta;
                _dbContext.ShoppingCarts.Update(cartItem);
            }
            else
            {
                _dbContext.ShoppingCarts.Remove(cartItem);
            }
            
            await _dbContext.SaveChangesAsync();
        }
    }
}
