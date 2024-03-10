using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Json;


namespace NBA_Stats_Browser;

public class TeamService
{
    private readonly MemoryCacheEntryOptions cacheEntryOptions = new MemoryCacheEntryOptions()
    .SetSlidingExpiration(TimeSpan.FromMinutes(5))
    .SetAbsoluteExpiration(TimeSpan.FromMinutes(30))
    .SetPriority(CacheItemPriority.Normal);

    private readonly IMemoryCache _cache;

    private readonly string cacheKey = "Teams";

    private readonly HttpClient _client;

    public TeamService(IMemoryCache cache, IHttpClientFactory httpClientFactory)
    {
        _cache = cache;
        _client = httpClientFactory.CreateClient("APIClient");
    }

    // API methods
    public async Task GetTeamsAsync()
    {
        // Fetch teams from API
        var response = await _client.GetFromJsonAsync<TeamsResponse>($"{_client.BaseAddress}teams");
        var teams = response.Data;
        // Add teams to cache
        AddToCache(cacheKey, teams);
        
    }

    public void PrintTeams(RichTextBox outputBox)
    {
        var cachedTeams = GetFromCache<Team>(cacheKey);
        foreach (var team in cachedTeams)
        {
            string output = $"ID: {team.Id}, Name: {team.Name}, Full Name: {team.Full_name}\n";
            outputBox.Invoke(new Action(() => outputBox.AppendText(output)));
        }
    }

    // Cache methods
    public void AddToCache<T>(string key, T value)
    {
        _cache.Set(key, value, cacheEntryOptions);
    }

    public Team GetTeamById(int id)
    {
        var cachedTeams = GetFromCache<Team>(cacheKey);
        return cachedTeams.FirstOrDefault(t => t.Id == id);
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
