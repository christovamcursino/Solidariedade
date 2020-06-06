using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Solidariedade.Application.Implementations;
using Solidariedade.Application.Interfaces;
using Solidariedade.DataAccess;
using Solidariedade.DataAccess.Context;
using Solidariedade.DataAccess.Repositories;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using Solidariedade.Domain.Services;

namespace Solidariedade.CrossCutting
{
    public static class Injections
    {
        public static void AddSolidariedadeServices(this IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<IProductRepository, ProductSqlRepository>();
            services.AddScoped<IRequestedProductRepository, RequestedProductSqlRepository>();
            services.AddScoped<IDonationItemRepository, DonationItemSqlRepository>();
            services.AddScoped<IDonationProductRepository, DonationProductSqlRepository>();
            services.AddScoped<IDonationRepository, DonationSqlRepository>();
            services.AddScoped<IDonatorPersonRepository, DonatorPersonSqlRepository>();
            services.AddScoped<IDoneePersonRepository, DoneePersonSqlRepository>();

            //Services
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<IDoneePersonService, DoneePersonService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRequestedProductService, RequestedProductService>();
            services.AddScoped<IDonationService, DonationService>();
            services.AddScoped<IDonatorPersonService, DonatorPersonService>();

            //Applications
            services.AddScoped<IStateApp, StateApp>();
            services.AddScoped<IDonationApp, DonationApp>();
            services.AddScoped<IDonatorPersonApp, DonatorPersonApp>();
            services.AddScoped<IDoneePersonApp, DoneePersonApp>();
            services.AddScoped<IProductApp, ProductApp>();
            services.AddScoped<IRequestedProductApp, RequestedProductApp>();
        }

        public static void AddDbContext(this IServiceCollection services)
        {
            //DBContext
            services.AddScoped<DbContext, SolidariedadeContext>();

            //IoW
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

    }
}
