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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        button1 = new Button();
        panelMain = new Panel();
        SearchList = new DataGridView();
        SearchWindow = new TextBox();
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
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        SearchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        SearchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        SearchList.ColumnHeadersVisible = false;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        SearchList.DefaultCellStyle = dataGridViewCellStyle2;
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
}
