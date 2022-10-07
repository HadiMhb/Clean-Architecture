using dddPrg.Domain.Contracts.Repositories;
using dddPrg.Domain.Models.Products;
using dddPrg.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Infrastructure.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private dddPrgDbContext _dbContext;
        public ProductRepository(dddPrgDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public Product Get(int id)
        {
            return _dbContext.Products.FirstOrDefault(a=>a.Id == id);
            _dbContext.SaveChanges();
        }
    }
}
