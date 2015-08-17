using SitecoreMVC.Business.Common;
using System;
using System.Runtime.Caching;

namespace SitecoreMVC.Business.Caching
{
    public class CacheLogic : ICacheLogic
    {
        private readonly IDateTimeLogic _dateTime;
        private readonly ICacheRepositoryLogic _cacheRepository;

        public CacheLogic(IDateTimeLogic dateTime, ICacheRepositoryLogic cacheRepository)
        {
            _dateTime = dateTime;
            _cacheRepository = cacheRepository;
        }

        public T GetOrCreateItem<T>(string key, Func<T> createItemCallback, TimeSpan lifespan)
        {
            var result = _cacheRepository.Get(key);

            if (result != null)
            {
                return (T)result;
            }

            result = createItemCallback();
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = _dateTime.UtcNow + lifespan
            };
            _cacheRepository.Add(key, result, cacheItemPolicy);

            return (T)result;
        }

        public virtual bool Exists(string key)
        {
            return _cacheRepository.Exists(key);
        }

        public virtual void Flush()
        {
            _cacheRepository.ClearAll();
        }
    }
}
