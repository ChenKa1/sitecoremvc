using System.Runtime.Caching;

namespace SitecoreMVC.Business.Caching
{
    public interface ICacheRepositoryLogic
    {
        void ClearAll();

        void Add(string key, object result, CacheItemPolicy cacheItemPolicy);

        object Get(string key);

        bool Exists(string key);
    }
}
