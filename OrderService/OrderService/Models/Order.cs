namespace OrderService.Models;

public class Order
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string Product { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}