using System.ComponentModel.DataAnnotations;

namespace SampleStore.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime ShipingDate { get; set; }
        public double OrderTotal { get; set; }

        public required string OrderStatus { get; set; }
        public required string PaymentStatus { get; set; }
        public required string TrackingNumber { get; set; }
        public required string Carrier { get; set; }

        public required string PaymentRefrenceId { get; set; }
        public required string PaymentGateway { get; set; }

        [Required]
        public required string PhoneNumber { get; set; }
        [Required]
        public required string Address { get; set; }
        [Required]
        public required string City { get; set; }
        [Required]
        public required string Province { get; set; }
        [Required]
        public required string PostalCode { get; set; }
        [Required]
        public required string Name { get; set; }
    }
}
