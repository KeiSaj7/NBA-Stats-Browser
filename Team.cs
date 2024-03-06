using Microsoft.Extensions.Caching.Memory;
using System.Collections;

namespace NBA_Stats_Browser;

public class Team
{
    public int Id { get; set; }
    public string? Conference { get; set; }
    public string? Division { get; set; }
    public string? City { get; set; }
    public string? Name { get; set; }
    public string? Full_name { get; set; }
    public string? Abbreviation { get; set; }

}
public class TeamsResponse
{
    public IEnumerable<Team> Data { get; set; }
}
