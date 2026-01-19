using Payment.Domain.Entities;

namespace Payment.Infrastructure.Persistence
{
    public class AppDbContext
    {
        public List<Order> Orders { get; set; } = new();
    }
}
