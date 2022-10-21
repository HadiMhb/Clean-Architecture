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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new List<Product>()
                {
                    new Product(
                        2,
                        "title",
                        "body",
                        DateTime.Now,
                        1000,
                        "image path",
                        "file path",
                        1,
                        true,
                        false,
                        true
                        ),
                    new Product(
                          3,
                        "title 2",
                        "body 2",
                        DateTime.Now,
                        1000,
                        "image path",
                        "file path",
                        1,
                        true,
                        false,
                        false
                        )

                });

            modelBuilder.Entity<CustomIdentityUser>().HasData(
                new List<CustomIdentityUser>() {
                    new CustomIdentityUser()
                    {
                        Id = 1,
                        UserName="hadiMhb",
                        Email="mohebi.hadi1996@gmail.com",
                        CreatedAt=DateTime.Now,
                        PhoneNumber="12345666",
                        Mobile=09034456,
                        PhoneNumberConfirmed=true,
                        LoginCount=0,
                        PurchaseNumber=0,
                        IsActive=true,
                        TwoFactorEnabled=false,
                        IsEmailPublic=true,
                        LockoutEnabled=false,
                        AccessFailedCount=0
                    }
                });

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
