﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Stats_Browser;

public class PlayerAverage
{
    public double Pts { get; set; }
    public double Ast { get; set; }
    public double Turnover { get; set; }
    public double Pf { get; set; }
    public double Fga { get; set; }
    public double Fgm { get; set; }
    public double Fta { get; set; }
    public double Ftm { get; set; }
    public double Fg3a { get; set; }
    public double Fg3m { get; set; }
    public double Reb { get; set; }
    public double Oreb { get; set; }
    public double Dreb { get; set; }
    public double Stl { get; set; }
    public double Blk { get; set; }
    public double Fg_pct { get; set; }
    public double Fg3_pct { get; set; }
    public double Ft_pct { get; set; }
    public string Min { get; set; }
    public int Games_played { get; set; }
    public int Player_id { get; set; }
    public int Season { get; set; }

}

public class PlayerAverageResponse
{
    public IEnumerable<PlayerAverage> Data { get; set; }
}