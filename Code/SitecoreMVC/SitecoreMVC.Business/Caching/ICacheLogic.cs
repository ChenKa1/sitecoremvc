using System;

namespace SitecoreMVC.Business.Caching
{
    public interface ICacheLogic
    {
        T GetOrCreateItem<T>(string key, Func<T> createItemCallback, TimeSpan lifespan);
        bool Exists(string key);
        void Flush();
    }
}
