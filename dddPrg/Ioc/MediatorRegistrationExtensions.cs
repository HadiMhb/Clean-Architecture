using dddPrg.Application.ProductHandlers;
using dddPrg.Domain.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace dddPrg.Ioc
{
    public static class MediatorRegistrationExtensions
    {
        public static void RegisterMediator(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(typeof(AddProductCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(AddProductCommandHandler).Assembly);
        }
    }
}
