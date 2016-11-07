using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace DN.RepoAdo.IoC
{
    public class BootStrapper
    {
        public static void Configure(IServiceCollection services)
        {
            Configure(services, Data.IoC.Module.GetTypes());
            Configure(services, Domain.IoC.Module.GetTypes());
            Configure(services, Application.IoC.Module.GetTypes());
        }

        private static void Configure(IServiceCollection services, Dictionary<Type, Type> types)
        {
            foreach (var item in types)
                services.AddScoped(item.Key, item.Value);
        }
    }
}
