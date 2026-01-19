using MediatR;

namespace Payment.Application.Commands
{
    public record CreateOrderCommand(string Product, decimal Amount) : IRequest<Guid>
    {
    }
}
