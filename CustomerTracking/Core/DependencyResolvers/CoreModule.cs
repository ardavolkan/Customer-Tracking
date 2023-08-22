using Autofac.Core;
using Core.CrossCuttingConcerns.Cashing;
using Core.CrossCuttingConcerns.Cashing.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();   
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICasheManager, MemoryCasheManager>();
            //Birisi senden ICasheManager isterse ona MemoryCasheManager ver.
            serviceCollection.AddSingleton<Stopwatch>();   // Kronometre
        }
    }
}
