using Acme.Apllication.Interfaces;
using Acme.Apllication.Services;
using Acme.Domain.Interfaces;
using Acme.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Infrastructure.IoC
{
    public class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IAccountService, AccountService>();

            //Infrastructure.Data Layer
            services.AddScoped<IAccountRepository, AccountRepository>();


        }

    }
}
