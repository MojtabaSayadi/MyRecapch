using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MyRecapch.Core.Services.Implementations;
using MyRecapch.Core.Services.Interfaces;
using MyRecapch.Data.Repositories;
using MyRecapch.Domain.Interfaces;

namespace Recapch.Ioc
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IWebContactUsRepository, WebContacUsRepository>();
            services.AddScoped<IWebContactUsService, WebContactUsService>();

           //services.AddScoped<IRecaptchaService, RecaptchaService>();
        }
    }


}

