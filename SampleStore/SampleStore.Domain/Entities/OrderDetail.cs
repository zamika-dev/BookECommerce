namespace SampleStore.Domain.Entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order? Order { get; set; }

        public Guid BookId { get; set; }
        public required Book Book { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public required string Count { get; set; }
    }
}
