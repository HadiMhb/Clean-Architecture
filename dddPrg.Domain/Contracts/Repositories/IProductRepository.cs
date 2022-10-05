using dddPrg.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Get(int id);
    }
}
