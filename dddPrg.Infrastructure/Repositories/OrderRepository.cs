using dddPrg.Domain.Contracts.Repositories;
using dddPrg.Domain.Models.Orders;
using dddPrg.Domain.Models.Products;
using dddPrg.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private dddPrgDbContext _dbContext;
        public OrderRepository(dddPrgDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Save(Order order)
        {
            try
            {
                _dbContext.Orders.Update(order);
                await _dbContext.SaveEntitiesAsync();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
