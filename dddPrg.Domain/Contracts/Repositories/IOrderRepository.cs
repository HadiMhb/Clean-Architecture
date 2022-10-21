using dddPrg.Domain.Models.Orders;
using dddPrg.Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Domain.Contracts.Repositories
{
    public interface IOrderRepository
    {
        Task Save(Order product);
    }
}
