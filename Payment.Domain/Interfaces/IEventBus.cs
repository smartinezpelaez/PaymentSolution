using Payment.Domain.Events;

namespace Payment.Domain.Interfaces
{
    public interface IEventBus
    {
        Task PublishAsync(OrderCreatedEvent ev);
    }
}
