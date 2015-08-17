using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreMVC.Business.Caching
{
    [ExcludeFromCodeCoverage]
    public class CacheRepositoryLogic : ICacheRepositoryLogic
    {
        private const string CacheName = "CustomCache";

        private static MemoryCache _cache = new MemoryCache(CacheName);

        public void ClearAll()
        {
            _cache.Dispose();
            _cache = new MemoryCache(CacheName);
        }

        public void Add(string key, object result, CacheItemPolicy cacheItemPolicy)
        {
            _cache.Add(key, result, cacheItemPolicy);
        }

        public object Get(string key)
        {
            return _cache.Get(key);
        }

        public bool Exists(string key)
        {
            return _cache.Contains(key);
        }
    }
}
