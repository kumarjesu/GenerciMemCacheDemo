using Enyim.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMemCache.ConsoleApp
{
    internal class MemCacheRepository : IMemCacheRepository
    {
        private readonly IMemcachedClient _memcachedClient;

        public MemCacheRepository(IMemcachedClient memcachedClient)
        {
            _memcachedClient = memcachedClient;
        }

        public void SaveMemCache<T>(string key, T value) where T : class
        {
            _memcachedClient.Set(key, value, 1);
        }
    }
}
