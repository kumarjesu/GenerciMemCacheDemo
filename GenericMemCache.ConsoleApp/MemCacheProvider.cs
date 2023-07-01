using Enyim.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMemCache.ConsoleApp
{
    internal class MemCacheProvider : IMemCacheProvider
    {
        private readonly IMemcachedClient _memcachedClient;
        public MemCacheProvider(IMemcachedClient memcachedClient)
        {
            _memcachedClient = memcachedClient;
        }

        public T GetCacheProvier<T>(string KEY) where T : class
        {
            try
            {
                return _memcachedClient.Get<T>(KEY);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
