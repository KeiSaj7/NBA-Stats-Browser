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

    private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        // Check if this cell is in the 'Team' column
        if (dataGridView.Columns[e.ColumnIndex].Name == "Team")
        {
            // Get the Player object for this row
            Player player = (Player)dataGridView.Rows[e.RowIndex].DataBoundItem;

            // Change the value of the cell to Team.Name
            e.Value = player.Team.Full_name;

            // Set this flag to true to indicate that you've handled the formatting of the cell
            e.FormattingApplied = true;
        }
    }

    private void PlayerInfoForm_Load(object sender, EventArgs e)
    {
        Player player = _playerService.GetSelectedPlayerFromCache();
        List<Player> players = new List<Player>() { player };

        dataGridView.DataSource = players;
        dataGridView.CellFormatting += DataGridView1_CellFormatting;
        dataGridView.Columns["Team"].DisplayIndex = 3;
        dataGridView.Columns["Id"].Visible = false;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
