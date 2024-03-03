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
    public int TeamId { get; set; }
    public Team Team { get; set; }
}

public class Team
{
    public int Id { get; set; }
    public string Conference { get; set; }
    public string Division { get; set; }
    public string City { get; set; }
    public string Name { get; set; }
    public string Full_name { get; set; }
    public string Abbreviation { get; set; }
}
public class Meta
{
    public int next_cursor { get; set; }
    public int per_page { get; set; }
}
public class Root<T>
{
    public List<T> Data { get; set; }
    public Meta Meta { get; set; }
}


