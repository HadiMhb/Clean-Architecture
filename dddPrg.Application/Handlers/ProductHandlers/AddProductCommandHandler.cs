using dddPrg.Domain.CommandResults;
using dddPrg.Domain.Commands;
using dddPrg.Domain.Contracts.Repositories;
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
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, AddProductResult>
    {
        private IProductRepository _productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<AddProductResult> Handle(AddProductCommand cmd, CancellationToken cancellationToken)
        {
            var product =  new Product(
                0,
                cmd.Title,
                cmd.Body,
                DateTime.Now,
                cmd.Price,
                cmd.ImagePath,
                cmd.FilePath,
                cmd.ProductCategoryId,
                cmd.IsVisible,
                cmd.IsDeleted,
                cmd.IsSellable
            );

            _productRepository.Add(product);

            return new AddProductResult(product.Id);
        }
    }
}
