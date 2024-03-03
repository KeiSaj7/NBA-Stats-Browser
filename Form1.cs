namespace NBA_Stats_Browser;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void PlayerChoice_TextChanged(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
        await APIService.GetPlayersAsync();
    }
}
