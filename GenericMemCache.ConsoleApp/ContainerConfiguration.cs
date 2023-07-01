using Enyim.Caching.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GenericMemCache.ConsoleApp
{
    internal static class ContainerConfiguration
    {
        public static IServiceProvider Configure()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging();
            serviceCollection.AddEnyimMemcached(cache => cache.Servers = new List<Server> { new Server { Address = "localhost", Port = 11211 } });

            serviceCollection.AddSingleton<IMemCacheProvider, MemCacheProvider>();
            serviceCollection.AddSingleton<IMemCacheRepository, MemCacheRepository>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
