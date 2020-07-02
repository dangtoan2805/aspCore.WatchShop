using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace aspCore.WatchShop.Helper
{
    public static class CacheData
    {
        public static void SetData<T>(IMemoryCache cache, string key, T obj)
        {
            if (cache.Get(key) != null)
                cache.Remove(key);
            cache.Set(key, obj);
        }

        public static T GetData<T>(IMemoryCache cache, string key)
        {
            T obj;
            return cache.TryGetValue(key, out obj) ? obj : default(T);
        }

        public static void UpdateData<T>(IMemoryCache cache, string key, T newObj)
        {
            if (cache.Get(key) != null)
                cache.Remove(key);
            cache.Set(key, newObj);
        }



    }
}