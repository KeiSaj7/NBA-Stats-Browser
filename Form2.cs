using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA_Stats_Browser;


public partial class Form2 : Form
{
    private readonly TeamService _teamService;

    private readonly PlayerService _playerService;
    public Form2(TeamService teamService, PlayerService playerService)
    {
        InitializeComponent();
        this._teamService = teamService;
        this._playerService = playerService;
    }

    public void loadForm(object Form)
    {
        if (this.panelMain.Controls.Count > 0)
        {
            this.panelMain.Controls.RemoveAt(0);
        }
        Form f = Form as Form;
        f.TopLevel = false;
        f.Dock = DockStyle.Fill;
        this.panelMain.Controls.Add(f);
        this.panelMain.Tag = f;
        f.Show();
    }

    private void PlayerInfoButton_Click(object sender, EventArgs e)
    {
        loadForm(new PlayerInfoForm(this._playerService));
    }

    private void TeamInfoButton_Click(object sender, EventArgs e)
    {
        int teamId = _playerService.GetSelectedPlayerFromCache().Team.Id;
        loadForm(new TeamInfoForm(_playerService));
    }

    private void LineCheckButton_Click(object sender, EventArgs e)
    {
        loadForm(new LineCheckForm(_playerService));
    }

    private void PlayerAveragesButton_Click(object sender, EventArgs e)
    {
        loadForm(new PlayerAveragesForm(_playerService));
    }
}
