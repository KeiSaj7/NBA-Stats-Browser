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

public partial class LineCheckForm : Form
{
    private readonly PlayerService _playerService;
    public LineCheckForm(PlayerService playerService)
    {
        InitializeComponent();
        this._playerService = playerService;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        bool valid = decimal.TryParse(this.textBox1.Text, out decimal result);
        if (!valid) return;
        this.textBox1.Text = "SUCCESS";
        List<Results> results = await this._playerService.CheckLines(result);
        this.dataGridView.DataSource = results;
    }
}
