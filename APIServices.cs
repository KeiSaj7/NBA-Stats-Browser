using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NBA_Stats_Browser;
public class APIService
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public static async Task GetTeamsAsync()
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://api.balldontlie.io/v1/teams"),
            Headers =
            {
                {"Authorization", "29d1f5cd-8fcf-44ea-a77f-1c5df888a0e4"}
            }
        };

        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var deserializedData = JsonSerializer.Deserialize<Root<Team>>(responseContent, options);

            using (var context = new NBAContext())
            {
                if (!context.Teams.Any())
                {
                    context.Teams.AddRange(deserializedData.Data);
                }
                else
                {
                    context.Teams.UpdateRange(deserializedData.Data);
                }
                context.SaveChanges();
            }
        }
        else
        {
            Console.WriteLine($"HTTP Request Failed with status code {response.StatusCode}");
        }
    }


    public static async Task GetPlayersAsync()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        using (var context = new NBAContext())
        {
            var teamIds = context.Teams.Select(t => t.Id).ToList();

            var existingPlayers = context.Players.ToDictionary(p => p.Id);

            foreach (var teamId in teamIds)
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://api.balldontlie.io/v1/players?team_ids[]={teamId}"),
                    Headers =
                    {
                        {"Authorization", "29d1f5cd-8fcf-44ea-a77f-1c5df888a0e4"}
                    }
                };
                var response = await _httpClient.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var desarializedData = JsonSerializer.Deserialize<Root<Player>>(content, options);

                    foreach (var playerData in desarializedData.Data)
                    {
                        if (existingPlayers.TryGetValue(playerData.Id, out var existingPlayer))
                        {
                            // Update the player
                            context.Entry(existingPlayer).CurrentValues.SetValues(playerData);
                            existingPlayer.TeamId = playerData.Team.Id;

                        }
                        else
                        {
                            // Add the player
                            var newPlayer = new Player();
                            context.Entry(newPlayer).CurrentValues.SetValues(playerData);
                            newPlayer.TeamId = playerData.Team.Id;
                            context.Players.Add(newPlayer);
                        }
                    }
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine($"HTTP Request Failed with status code {response.StatusCode}");

                }
            }
        }
    }
}




