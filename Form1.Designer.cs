namespace NBA_Stats_Browser;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        button1 = new Button();
        panelMain = new Panel();
        SearchList = new DataGridView();
        SearchWindow = new TextBox();
        textBox1 = new TextBox();
        panelMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)SearchList).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.FlatAppearance.BorderSize = 2;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
        button1.ForeColor = Color.White;
        button1.Location = new Point(432, 264);
        button1.Name = "button1";
        button1.Size = new Size(335, 78);
        button1.TabIndex = 1;
        button1.TabStop = false;
        button1.Text = "Select player";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // panelMain
        // 
        panelMain.Controls.Add(textBox1);
        panelMain.Controls.Add(SearchList);
        panelMain.Controls.Add(SearchWindow);
        panelMain.Controls.Add(button1);
        panelMain.Dock = DockStyle.Fill;
        panelMain.Location = new Point(0, 0);
        panelMain.Name = "panelMain";
        panelMain.Size = new Size(1184, 561);
        panelMain.TabIndex = 2;
        // 
        // SearchList
        // 
        SearchList.AllowUserToAddRows = false;
        SearchList.AllowUserToDeleteRows = false;
        SearchList.AllowUserToResizeColumns = false;
        SearchList.AllowUserToResizeRows = false;
        SearchList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        SearchList.BackgroundColor = Color.White;
        SearchList.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        SearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        SearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        SearchList.ColumnHeadersVisible = false;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        SearchList.DefaultCellStyle = dataGridViewCellStyle4;
        SearchList.Location = new Point(432, 204);
        SearchList.Name = "SearchList";
        SearchList.RowHeadersVisible = false;
        SearchList.RowTemplate.Height = 30;
        SearchList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        SearchList.Size = new Size(335, 0);
        SearchList.TabIndex = 3;
        SearchList.CellClick += SearchList_CellClick;
        // 
        // SearchWindow
        // 
        SearchWindow.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
        SearchWindow.Location = new Point(432, 176);
        SearchWindow.Name = "SearchWindow";
        SearchWindow.Size = new Size(335, 31);
        SearchWindow.TabIndex = 2;
        SearchWindow.TextChanged += SearchWindow_TextChanged;
        // 
        // textBox1
        // 
        textBox1.BackColor = SystemColors.MenuHighlight;
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
        textBox1.ForeColor = Color.White;
        textBox1.Location = new Point(334, 44);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(545, 59);
        textBox1.TabIndex = 4;
        textBox1.Text = "NBA Stats Browser";
        textBox1.TextAlign = HorizontalAlignment.Center;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.MenuHighlight;
        ClientSize = new Size(1184, 561);
        Controls.Add(panelMain);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        panelMain.ResumeLayout(false);
        panelMain.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)SearchList).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Button button1;
    private Panel panelMain;
    private DataGridView SearchList;
    private TextBox SearchWindow;
    private TextBox textBox1;
}
