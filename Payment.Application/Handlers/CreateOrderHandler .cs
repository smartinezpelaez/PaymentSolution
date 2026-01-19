using MediatR;
using Payment.Application.Commands;
using Payment.Domain.Entities;
using Payment.Domain.Events;
using Payment.Domain.Interfaces;



namespace Payment.Application.Handlers
{
    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, Guid>
    {

        private readonly IOrderRepository _repo;
        private readonly IEventBus _eventBus;

        public CreateOrderHandler(IOrderRepository repo, IEventBus eventBus)
        {
            _repo = repo;
            _eventBus = eventBus;
        }

        public async Task<Guid> Handle(CreateOrderCommand cmd, CancellationToken ct)
        {
            var order = new Order(cmd.Product, cmd.Amount);

            await _repo.AddAsync(order);

            await _eventBus.PublishAsync(
                new OrderCreatedEvent(order.Id, order.Product, order.Amount)
            );

            return order.Id;
        }
    }
}
