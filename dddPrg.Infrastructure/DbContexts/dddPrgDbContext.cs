using dddPrg.Domain.Models.Orders;
using dddPrg.Domain.Models.Products;
using dddPrg.Domain.Models.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dddPrg.Infrastructure.DbContexts
{
    public class dddPrgDbContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public dddPrgDbContext()
        {

        }

        public dddPrgDbContext(DbContextOptions<dddPrgDbContext> options) : base(options)
        {

        }
    }

    


}
