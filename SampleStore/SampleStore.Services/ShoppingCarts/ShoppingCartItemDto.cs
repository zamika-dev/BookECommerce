using SampleStore.Domain.Entities;

namespace SampleStore.Services.ShoppingCarts
{
    public class ShoppingCartItemDto
    {
        public Guid Id { get; set; }
        public Book Book { get; set; }
        public int Count { get; set; }
    }
}
