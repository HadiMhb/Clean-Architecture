using dddPrg.Domain.Commands.Orders;
using dddPrg.Domain.Commands.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dddPrg.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("[action]")]
        public async Task<IActionResult> AddOrder(AddOrderCommand command)
        {
            command.OrderItems = new List<Domain.Models.Orders.OrderItem>();
            command.OrderItems.Add(new Domain.Models.Orders.OrderItem(1,1,1,100));
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
