using Payment.Application.EventHandlers;
using Payment.Domain.Events;
using Payment.Domain.Interfaces;


namespace Payment.Infrastructure.Messaging
{
    public class InMemoryEventBus : IEventBus
    {
        private readonly OrderCreatedEventHandler _handler;

        public InMemoryEventBus(OrderCreatedEventHandler handler)
        {
            _handler = handler;
        }

        public Task PublishAsync(OrderCreatedEvent ev)
        {
            return _handler.Handle(ev);
        }
    }
}
