using dddPrg.Domain.CommandResults;
using dddPrg.Domain.CommandResults.Orders;
using dddPrg.Domain.Models.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Commands.Orders
{
    public class AddOrderCommand : IRequest<AddOrderResult>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
