using System.ComponentModel.DataAnnotations;

namespace SampleStore.Services.ShoppingCart
{
    public class ShoppingCartAddOrUpdateDto
    {
        [Required]
        public Guid BookId { get; set; }
        
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public int Count { get; set; }
    }

    public static class ShoppingCartRequestExtension
    {
        public static Domain.Entities.CartItem ToShoppingCard(this ShoppingCartAddOrUpdateDto shoppingCard)
        {
            return new Domain.Entities.CartItem
            {
                ApplicationUserId = shoppingCard.UserId,
                BookId = shoppingCard.BookId,
                Count = shoppingCard.Count,
            };
        }
    }
}
