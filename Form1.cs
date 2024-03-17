using System.Numerics;

namespace NBA_Stats_Browser;

public partial class Form1 : Form
{
    private readonly TeamService _teamService;
    private readonly PlayerService _playerService;
    public Form1(TeamService teamService, PlayerService playerService)
    {
        InitializeComponent();
        _teamService = teamService;
        _playerService = playerService;

        this.Load += async (sender, e) =>
        {
            await _teamService.GetTeamsAsync();

        };

    }

    public void loadForm(object Form)
    {
        if (this.panelMain.Controls.Count > 0)
        {
            this.panelMain.Controls.Clear();
        }
        Form f = Form as Form;
        f.TopLevel = false;
        f.Dock = DockStyle.Fill;
        this.panelMain.Controls.Add(f);
        this.panelMain.Tag = f;
        f.Show();
    }


    private async void SearchWindow_TextChanged(object sender, EventArgs e)
    {

        if (SearchWindow.TextLength > 2)
        {
            string userInput = SearchWindow.Text;
            var players = await _playerService.GetPlayersByName(userInput);
            if (players != null)
            {
                var info = players.Select(p => new { FullNameAndTeam = p.GetFullNameAndTeam() }).ToList();
                SearchList.DataSource = info;
                SearchList.Height = SearchList.Rows.Count * 30;
            }
            else
            {
                SearchList.Height = 0;
            }
        }
        else if (SearchWindow.TextLength <= 1)
        {
            SearchList.Height = 0;
            _playerService.ClearPlayerCache();
        }
    }

    private void SearchList_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewRow row = SearchList.Rows[e.RowIndex];
        SearchWindow.Text = row.Cells[0].Value.ToString();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        var input = SearchWindow.Text.Trim();
        var player = _playerService.PlayerValidation(input);

        if (player != null)
        {
            _playerService.ClearPlayerCache();
            _playerService.AddSelectedPlayerToCache(player);
            await _playerService.GetPlayerAverages();

            // Form creation
            loadForm(new Form2(_teamService, _playerService));
        }
        else return;

    }
}
