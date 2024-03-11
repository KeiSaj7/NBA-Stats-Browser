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
        button1 = new Button();
        PlayerChoiceComboBox = new ComboBox();
        panelMain = new Panel();
        panelMain.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.FlatAppearance.BorderSize = 2;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
        button1.ForeColor = Color.White;
        button1.Location = new Point(444, 305);
        button1.Name = "button1";
        button1.Size = new Size(283, 78);
        button1.TabIndex = 1;
        button1.TabStop = false;
        button1.Text = "Select player";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // PlayerChoiceComboBox
        // 
        PlayerChoiceComboBox.FormattingEnabled = true;
        PlayerChoiceComboBox.ImeMode = ImeMode.Alpha;
        PlayerChoiceComboBox.Location = new Point(444, 205);
        PlayerChoiceComboBox.MaxDropDownItems = 10;
        PlayerChoiceComboBox.Name = "PlayerChoiceComboBox";
        PlayerChoiceComboBox.Size = new Size(283, 23);
        PlayerChoiceComboBox.Sorted = true;
        PlayerChoiceComboBox.TabIndex = 1;
        PlayerChoiceComboBox.TextUpdate += PlayerChoiceComboBox_TextUpdate;
        // 
        // panelMain
        // 
        panelMain.Controls.Add(button1);
        panelMain.Controls.Add(PlayerChoiceComboBox);
        panelMain.Dock = DockStyle.Fill;
        panelMain.Location = new Point(0, 0);
        panelMain.Name = "panelMain";
        panelMain.Size = new Size(1184, 561);
        panelMain.TabIndex = 2;
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
        ResumeLayout(false);
    }

    #endregion
    private Button button1;
    private ComboBox PlayerChoiceComboBox;
    private Panel panelMain;
}
