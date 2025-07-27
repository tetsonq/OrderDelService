namespace DeliveryService.Events
{
    public class OrderCreated
    {
        public Guid OrderId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
    }
}