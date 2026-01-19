using MediatR;
using Payment.Application.DTOs;
using Payment.Application.Queries;
using Payment.Domain.Interfaces;


namespace Payment.Application.Handlers
{
    public class GetOrderHandler : IRequestHandler<GetOrderByIdQuery, OrderDTO>
    {
        private readonly IOrderRepository _repo;

        public GetOrderHandler(IOrderRepository repo)
        {
            _repo = repo;
        }

        public async Task<OrderDTO> Handle(GetOrderByIdQuery q, CancellationToken ct)
        {
            var order = await _repo.GetByIdAsync(q.Id);
            return new OrderDTO(order.Id, order.Product, order.Amount);
        }
    }
}
