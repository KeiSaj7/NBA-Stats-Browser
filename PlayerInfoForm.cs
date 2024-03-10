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

public partial class PlayerInfoForm : Form
{
    private readonly PlayerService _playerService;
    public PlayerInfoForm(PlayerService playerService)
    {
        InitializeComponent();
        this._playerService = playerService;
    }

    private void PlayerInfoForm_Load(object sender, EventArgs e)
    {
        var player = _playerService.GetSelectedPlayerFromCache();
        List<Player> players = new List<Player>() { player };
        dataGridView1.DataSource = players;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
