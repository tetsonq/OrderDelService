using DeliveryService.Data;
using DeliveryService.Events;
using DeliveryService.Models;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Consumers
{
    public class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        private readonly IDbContextFactory<DeliveryDbContext> _contextFactory;

        public OrderCreatedConsumer(IDbContextFactory<DeliveryDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Consume(ConsumeContext<OrderCreated> context)
        {
            using var db = _contextFactory.CreateDbContext();
            
            var message = context.Message;

            var delivery = new DeliveryRequest
            {
                OrderId = message.OrderId,
                Product = message.Product,
                Quantity = message.Quantity,
                Address = message.Address,
                CreatedAt = DateTime.UtcNow
            };

            db.DeliveryRequests.Add(delivery);
            await db.SaveChangesAsync();
            
            Console.WriteLine($"[DeliveryService] Заявка на доставку создана для заказа {message.OrderId}");    
        }
    }
}