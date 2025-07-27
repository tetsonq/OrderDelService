namespace OrderService.Events
{
    public class OrderCreated
    {
        public int OrderId { get; set; }              // ID заказа
        public string CustomerName { get; set; } // Имя клиента
        public string Product { get; set; }      // Название продукта
        public int Quantity { get; set; }        // Количество
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }  // Дата создания
    }
}