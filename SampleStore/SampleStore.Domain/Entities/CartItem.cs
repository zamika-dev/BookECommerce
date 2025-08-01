namespace SampleStore.Domain.Entities
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public int Count { get; set; }
        public Book Book { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
