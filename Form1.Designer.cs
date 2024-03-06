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
        outputBox = new RichTextBox();
        PlayerChoiceComboBox = new ComboBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(682, 82);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // outputBox
        // 
        outputBox.Location = new Point(65, 203);
        outputBox.Name = "outputBox";
        outputBox.Size = new Size(627, 207);
        outputBox.TabIndex = 2;
        outputBox.Text = "";
        // 
        // PlayerChoiceComboBox
        // 
        PlayerChoiceComboBox.FormattingEnabled = true;
        PlayerChoiceComboBox.Location = new Point(323, 83);
        PlayerChoiceComboBox.Name = "PlayerChoiceComboBox";
        PlayerChoiceComboBox.Size = new Size(169, 23);
        PlayerChoiceComboBox.TabIndex = 3;
        PlayerChoiceComboBox.TextChanged += PlayerChoiceComboBox_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(PlayerChoiceComboBox);
        Controls.Add(outputBox);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion
    private Button button1;
    private RichTextBox outputBox;
    private ComboBox PlayerChoiceComboBox;
}
