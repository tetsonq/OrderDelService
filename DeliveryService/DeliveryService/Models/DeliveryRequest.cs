namespace DeliveryService.Models
{
    public class DeliveryRequest
    {
        public Guid Id { get; set; } // опционально

        public Guid OrderId { get; set; }

        public string Product { get; set; } = default!; // или required
        public int Quantity { get; set; }
        public string Address { get; set; } = default!; // или required

        public DateTime CreatedAt { get; set; }
    }

}