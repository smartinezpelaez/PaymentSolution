using Payment.Domain.Events;

namespace Payment.Application.EventHandlers
{
    public class OrderCreatedEventHandler
    {
        public Task Handle(OrderCreatedEvent ev)
        {
            Console.WriteLine($"📬 Orden creada: {ev.OrderId} - {ev.Product}");

            // Aquí podrías:
            // + Enviar email
            // + Publicar a otra cola
            // + Disparar otra saga

            return Task.CompletedTask;
        }
    }
}
