using Microsoft.Extensions.Caching.Memory;

namespace NBA_Stats_Browser;

public class CacheService
{
    private readonly IMemoryCache _cache;
    public CacheService(IMemoryCache cache)
    {
        _cache = cache;
    }

    public void AddToCache<T>(string key, T value)
    {
        var cacheEntryOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(5))
            .SetAbsoluteExpiration(TimeSpan.FromMinutes(30))
            .SetPriority(CacheItemPriority.Normal);

        _cache.Set(key, value, cacheEntryOptions);
    }
    public IEnumerable<T> GetFromCache<T>(string key)
    {
        if(_cache.TryGetValue(key, out IEnumerable<T> value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }
}
