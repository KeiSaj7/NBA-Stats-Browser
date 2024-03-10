using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Stats_Browser;
public class Player
{
    public int Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string? Position { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }
    public string? Jersey_Number { get; set; }
    public string? College { get; set; }
    public string? Country { get; set; }
    public int? Draft_Year { get; set; }
    public int? Draft_Round { get; set; }
    public int? Draft_Number { get; set; }
    public Team Team { get; set; }

    public string FullNameAndTeam => $"{First_Name} {Last_Name} | {Team?.Abbreviation}";

}


public class Meta
{
    public int Next_cursor { get; set; }
    public int Per_page { get; set; }
}
public class PlayersResponse
{
    public IEnumerable<Player> Data { get; set; }
    public Meta Meta { get; set; }
}


