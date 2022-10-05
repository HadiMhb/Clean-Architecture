using dddPrg.Domain.CommandResults;
using dddPrg.Domain.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dddPrg.Application.ProductHandlers
{
    class AddProductCommandHandler : IRequestHandler<AddProductCommand, AddProductResult>
    {
        public Task<AddProductResult> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
