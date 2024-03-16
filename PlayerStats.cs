using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Stats_Browser;

public class PlayerStats
{
    public int Id { get; set; }
    public string Min { get; set; }
    public int Fgm { get; set; }
    public int Fga { get; set; }
    public decimal Fg_pct { get; set; }
    public int Fg3m { get; set; }
    public int Fg3a { get; set; }
    public decimal Fg3_pct { get; set; }
    public int Ftm { get; set; }
    public int Fta { get; set; }
    public decimal Ft_pct { get; set; }
    public int Oreb { get; set; }
    public int Dreb { get; set; }
    public int Reb { get; set; }
    public int Ast { get; set; }
    public int Stl { get; set; }
    public int Blk { get; set; }
    public int Turnover { get; set; }
    public int Pf { get; set; }
    public int Pts { get; set; }
    public Player2 Player { get; set; }
    public Team Team { get; set; }
    public Game Game { get; set; }
}

public class Game
{
    public int Id { get; set; }
    public string Date { get; set; }
    public int Season { get; set; }
    public string Status { get; set; }
    public int Period { get; set; }
    public string Time { get; set; }
    public bool Postseason { get; set; }
    public int Home_Team_Score { get; set; }
    public int Visitor_Team_Score { get; set; }
    public int Home_Team_Id { get; set; }
    public int Visitor_Team_Id { get; set; }
}

public class Player2
{
    public int Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Position { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string Jersey_Number { get; set; }
    public string College { get; set; }
    public string Country { get; set; }
    public int Draft_Year { get; set; }
    public int Draft_Round { get; set; }
    public int Draft_Number { get; set; }
    public int Team_Id { get; set; }
}

public class Results
{
    public string Stat { get; set; }
    public int TotalGames { get; set; }
    public int Achieved { get; set; }
    public decimal Percentage { get; set; }
}

public class PlayerStatsResponse
{
    public IEnumerable<PlayerStats> Data { get; set; }
    public Meta Meta { get; set; }
}
