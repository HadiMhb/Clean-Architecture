using dddPrg.Domain.Models.Orders;
using dddPrg.Domain.Models.Products;
using dddPrg.Domain.Models.Tags;
using dddPrg.Domain.Models.Users;
using dddPrg.Infrastructure.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dddPrg.Infrastructure.DbContexts
{
    public class dddPrgDbContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CustomIdentityUser> CustomIdentityUsers { get; set; }

        public dddPrgDbContext()
        {

        }

        private readonly IMediator _mediator;

        public dddPrgDbContext(DbContextOptions<dddPrgDbContext> options,IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _mediator.DispatchDomainEventsAsync(this);
            var result = await base.SaveChangesAsync(cancellationToken);
            return true;
        }
    }

    


}
