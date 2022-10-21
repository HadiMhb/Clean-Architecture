using dddPrg.Domain.CommandResults.Orders;
using dddPrg.Domain.Commands.Orders;
using dddPrg.Domain.Commands.Products;
using dddPrg.Domain.Contracts.Repositories;
using dddPrg.Domain.Models.Orders;
using dddPrg.Domain.Models.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dddPrg.Application.ProductHandlers
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, AddOrderResult>
    {
        private IOrderRepository _orderRepository;

        public AddOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<AddOrderResult> Handle(AddOrderCommand cmd, CancellationToken cancellationToken)
        {
            var order =  new Order(0,1,DateTime.Now);
            order.AddItem(cmd.OrderItems);
            _orderRepository.Save(order);

            return new AddOrderResult(order.Id);
        }
    }
}
