using dddPrg.Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dddPrg.Controllers
{
    public class ProductController:ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost,Route("[action]")]
        public async Task<IActionResult> AddProduct(AddProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
