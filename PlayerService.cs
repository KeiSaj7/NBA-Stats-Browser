using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NBA_Stats_Browser;

public class PlayerService
{
    private readonly MemoryCacheEntryOptions cacheEntryOptions = new MemoryCacheEntryOptions()
    .SetSlidingExpiration(TimeSpan.FromMinutes(5))
    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30))
    .SetPriority(CacheItemPriority.Normal);

    private readonly IMemoryCache _cache;

    private readonly string cacheKey = "Player";

    private readonly HttpClient _client;

    public PlayerService(IMemoryCache cache, IHttpClientFactory httpClientFactory)
    {
        _cache = cache;
        _client = httpClientFactory.CreateClient("APIClient");
    }

    // API methods
    public async Task<IEnumerable<Player>> GetPlayersByName(string input)
    {
        var cachedPlayers = GetFromCache<Player>(cacheKey);
        if (cachedPlayers == null)
        {
            var players = new List<Player>();
            int nextCursor = 0;
            do
            {
                // Fetch players from API
                var response = await _client.GetFromJsonAsync<PlayersResponse>($"{_client.BaseAddress}players?search={input}&per_page=100" + (nextCursor != 0 ? $"&cursor={nextCursor}" : ""));
                if (response?.Data == null || !response.Data.Any())
                {
                    break;
                }
                var a = response.Meta.Next_cursor;
                players.AddRange(response.Data);
                nextCursor = response.Meta.Next_cursor;
            } while (nextCursor != 0);

            // Add players to cache
            AddToCache(cacheKey, players);
            return players;
        }
        return cachedPlayers.Where(p => p.First_Name.Contains(input) || p.Last_Name.Contains(input));

    }



    // Cache methods
    public void AddToCache<T>(string key, T value)
    {
        _cache.Set(key, value, cacheEntryOptions);
    }

    public IEnumerable<T> GetFromCache<T>(string key)
    {
        if (_cache.TryGetValue(key, out IEnumerable<T> value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }

    public void ClearCache()
    {
        _cache.Remove(cacheKey);
    }
}
