using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DeliveryService.Data;

namespace DeliveryService.Data
{
    public class DeliveryDbContextFactory : IDesignTimeDbContextFactory<DeliveryDbContext>
    {
        public DeliveryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DeliveryDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=deliverydb;Username=postgres;Password=1234");

            return new DeliveryDbContext(optionsBuilder.Options);
        }
    }
}