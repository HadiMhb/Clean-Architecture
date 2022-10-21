using dddPrg.Application.ProductHandlers;
using dddPrg.Domain.Commands.Products;
using dddPrg.Domain.Contracts.Repositories;
using dddPrg.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace dddPrg.Ioc
{
    public static class ServiceRegistrationExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IOrderRepository,OrderRepository>();
            services.AddScoped<IUserRepository,UserRepository>();
        }
    }
}
