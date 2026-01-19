using Payment.Domain.Entities;
using Payment.Domain.Interfaces;
using Payment.Infrastructure.Persistence;

namespace Payment.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _ctx;
        public OrderRepository(AppDbContext ctx) => _ctx = ctx;

        public Task AddAsync(Order order)
        {
            _ctx.Orders.Add(order);
            return Task.CompletedTask;
        }

        public Task<Order?> GetByIdAsync(Guid id)
        {
            return Task.FromResult(_ctx.Orders.FirstOrDefault(o => o.Id == id));
        }
    }
}
