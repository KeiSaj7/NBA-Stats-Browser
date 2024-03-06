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
            PlayerChoiceComboBox.Enabled = false;
            await _teamService.GetTeamsAsync();
            PlayerChoiceComboBox.Enabled = true;
        };
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _teamService.ClearCache();
        _playerService.ClearCache();

    }

    private async void PlayerChoiceComboBox_TextChanged(object sender, EventArgs e)
    {
        // Get the user input
        string userInput = PlayerChoiceComboBox.Text;

        // Check if user deleted all input
        if(string.IsNullOrEmpty(userInput))
        {
            _playerService.ClearCache();
            PlayerChoiceComboBox.Items.Clear();
            return;
        }
        if (userInput.Length < 3)
        {
            _playerService.ClearCache();
            return;
        }

        // Get players 
        var players = await _playerService.GetPlayersByName(userInput);
        
        // Save the cursor position
        int cursorPos = PlayerChoiceComboBox.SelectionStart;
        PlayerChoiceComboBox.Items.Clear();

        // Add players to the combobox
        foreach (var player in players)
        {
            PlayerChoiceComboBox.Items.Add(player.First_Name + " " + player.Last_Name + "Team: " + player.Team.Abbreviation);
        }
        if (PlayerChoiceComboBox.Items.Count > 0)
        {
            PlayerChoiceComboBox.SelectionStart = cursorPos;
        }

    }
}
