using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA_Stats_Browser;

public partial class TeamInfoForm : Form
{
    private readonly PlayerService _playerService;


    public TeamInfoForm(PlayerService playerService)
    {
        InitializeComponent();
        this._playerService = playerService;
    }

    private void TeamInfoForm_Load(object sender, EventArgs e)
    {
        Team team = _playerService.GetSelectedPlayerFromCache().Team;
        List<Team> teams = new List<Team>() { team };
        dataGridView.DataSource = teams;
    }
}
