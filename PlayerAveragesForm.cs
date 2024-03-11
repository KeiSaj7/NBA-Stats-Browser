namespace NBA_Stats_Browser;

public partial class PlayerAveragesForm : Form
{
    private readonly PlayerService _playerService;
    public PlayerAveragesForm(PlayerService playerService)
    {
        InitializeComponent();
        _playerService = playerService;
    }

    private void PlayerAveragesForm_Load(object sender, EventArgs e)
    {
        PlayerAverage avg = _playerService.GetSelectedPlayerAvgFromCache();
        List<PlayerAverage> avgs = new List<PlayerAverage>() { avg };
        this.dataGridView.DataSource = avgs;
    }
}
