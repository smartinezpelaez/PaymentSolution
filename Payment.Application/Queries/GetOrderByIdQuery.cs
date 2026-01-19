using MediatR;
using Payment.Application.DTOs;

namespace Payment.Application.Queries
{
    public record GetOrderByIdQuery(Guid Id) : IRequest<OrderDTO>;
}
