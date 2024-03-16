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

    private readonly string selectedPlayerKey = "SelectedPlayer";

    private readonly string playerAveragesKey = "PlayerAverages";

    private readonly string playerStatsKey = "PlayerStats";

    private readonly string resultsKey = "Results";
    
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
                players.AddRange(response.Data);
                nextCursor = response.Meta.Next_cursor;
            } while (nextCursor != 0);

            // Add players to cache
            AddToCache(cacheKey, players);
            return players;
        }
        var cachedPlayersList = cachedPlayers.Where(p => (p.First_Name + " " + p.Last_Name).ToLower().Contains(input.Trim().ToLower()));
        if (cachedPlayersList.Any()) {
            return cachedPlayersList.ToList();
        }
        else return null;

    }

    public async Task<List<Results>> CheckLines(decimal line)
    {
        int selectedPlayerId = GetSelectedPlayerFromCache().Id;
        int nextCursor = 0;
        var playerStats = new List<PlayerStats>();
        do
        {
            var response = await _client.GetFromJsonAsync<PlayerStatsResponse>($"{_client.BaseAddress}stats?per_page=100&player_ids[]={selectedPlayerId}&seasons[]=2023" + (nextCursor != 0 ? $"&cursor={nextCursor}" : ""));
            if (response?.Data == null || !response.Data.Any())
            {
                break;
            }
            playerStats.AddRange(response.Data);
            nextCursor = response.Meta.Next_cursor;
        } while (nextCursor != 0);

        AddToCache(playerStatsKey, playerStats);

        List<Results> stats = CalcLines(line).ToList();
        return stats;
    }

    public IEnumerable<Results> CalcLines(decimal line)
    {
        CalcPts(line);
        var stats = GetFromCache<Results>(this.resultsKey);
        return stats;
    }

    public void CalcPts(decimal line)
    {
        List<Results> results = new List<Results>();

        var playerStats = GetFromCache<PlayerStats>(playerStatsKey);
        if (playerStats == null) return;
        int achieved = 0;
        int totalGames = 0;
        foreach(var match in playerStats)
        {
            // Check if player was absent
            if(match.Min == "00") continue;
            if(match.Pts > line) achieved++;
            totalGames++;
        }
        decimal percentage = (int)((decimal)achieved / totalGames * 100);
        Results ptsResults = new Results {Stat = "Points" ,TotalGames = totalGames, Achieved = achieved, Percentage = percentage };
        results.Add(ptsResults);
        CalcReb(line, results);
    }

    public void CalcReb(decimal line, List<Results> results)
    {
        var playerStats = GetFromCache<PlayerStats>(playerStatsKey);
        if (playerStats == null) return;
        int achieved = 0;
        int totalGames = 0;
        foreach(var match in playerStats)
        {
            // Check if player was absent
            if(match.Min == "00") continue;
            if(match.Reb > line) achieved++;
            totalGames++;
        }
        decimal percentage = (int)((decimal)achieved / totalGames * 100);
        Results rebResults = new Results {Stat = "Rebounds" ,TotalGames = totalGames, Achieved = achieved, Percentage = percentage };
        results.Add(rebResults);
        CalcAst(line, results);
    }

    public void CalcAst(decimal line, List<Results> results)
    {
        var playerStats = GetFromCache<PlayerStats>(playerStatsKey);
        if (playerStats == null) return;
        int achieved = 0;
        int totalGames = 0;
        foreach(var match in playerStats)
        {
            // Check if player was absent
            if(match.Min == "00") continue;
            if(match.Ast > line) achieved++;
            totalGames++;
        }
        decimal percentage = (int)((decimal)achieved / totalGames * 100);
        Results astResults = new Results {Stat = "Assists" ,TotalGames = totalGames, Achieved = achieved, Percentage = percentage };
        results.Add(astResults);
        AddToCache(resultsKey, results);
    }

    public async Task GetPlayerAverages()
    {
        int selectedPlayerId = GetSelectedPlayerFromCache().Id;
        var response = await _client.GetFromJsonAsync<PlayerAverageResponse>($"{_client.BaseAddress}season_averages?season=2023&player_ids[]={selectedPlayerId}");
        if (response == null) return;
        PlayerAverage playerAverages = response.Data.FirstOrDefault();
        AddToCache(playerAveragesKey, playerAverages);
    }

    public Player PlayerValidation(string input)
    {
        var cachedPlayers = GetFromCache<Player>(cacheKey);
        if (cachedPlayers != null)
        {
            var player = cachedPlayers.FirstOrDefault(p => p.GetFullNameAndTeam() == input);
            if (player != null)
            {
                return player;
            }
           
        }
        return null;
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

    public Player GetSelectedPlayerFromCache()
    {
        if (_cache.TryGetValue(this.selectedPlayerKey, out Player value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }

    public void AddSelectedPlayerToCache(Player player)
    {
        _cache.Set(this.selectedPlayerKey, player, cacheEntryOptions);
    }

    public PlayerAverage GetSelectedPlayerAvgFromCache()
    {
        if (_cache.TryGetValue(this.playerAveragesKey, out PlayerAverage value))
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
