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
            PlayerChoiceComboBox.Focus();

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

    private void button1_Click(object sender, EventArgs e)
    {
        var input = PlayerChoiceComboBox.Text.Trim();
        var player = _playerService.PlayerValidation(input);

        if(player != null)
        {
            //
            _playerService.ClearCache();
            _playerService.AddSelectedPlayerToCache(player);

            // Form creation
            loadForm(new Form2(_teamService, _playerService));
        }
        else
        {
        }

    }


    private async void PlayerChoiceComboBox_TextUpdate(object sender, EventArgs e)
    {
        // Get the user input
        string userInput = PlayerChoiceComboBox.Text;


        if (PlayerChoiceComboBox.Text.Length > 2)
        {
            
            PlayerChoiceComboBox.Items.Clear();
            PlayerChoiceComboBox.SelectionStart = PlayerChoiceComboBox.Text.Length;
            var players = await _playerService.GetPlayersByName(userInput);
            if (players != null)
            {
                // Show players first and last name in the combobox
                foreach (var player in players)
                {
                    PlayerChoiceComboBox.Items.Add(player.FullNameAndTeam);
                }
                PlayerChoiceComboBox.DroppedDown = true;
                PlayerChoiceComboBox.SelectedIndex = -1;
                PlayerChoiceComboBox.Text = userInput;
                PlayerChoiceComboBox.SelectionStart = PlayerChoiceComboBox.Text.Length;
            }
        }
        else
        {
            PlayerChoiceComboBox.Items.Clear();
            _playerService.ClearCache();
            PlayerChoiceComboBox.SelectedIndex = -1;
            PlayerChoiceComboBox.DroppedDown = false;
            PlayerChoiceComboBox.SelectionStart = PlayerChoiceComboBox.Text.Length;

        }
    }
}
