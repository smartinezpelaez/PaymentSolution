using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payment.Application.Commands;
using Payment.Application.Queries;

namespace Payment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> Create(string product, decimal amount)
        {
            var id = await _mediator.Send(new CreateOrderCommand(product, amount));
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        => Ok(await _mediator.Send(new GetOrderByIdQuery(id)));

    }
}
