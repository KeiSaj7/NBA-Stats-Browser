﻿namespace NBA_Stats_Browser;

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
        PlayerChoice = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // PlayerChoice
        // 
        PlayerChoice.Location = new Point(323, 169);
        PlayerChoice.Name = "PlayerChoice";
        PlayerChoice.Size = new Size(133, 23);
        PlayerChoice.TabIndex = 0;
        PlayerChoice.TextChanged += PlayerChoice_TextChanged;
        // 
        // button1
        // 
        button1.Location = new Point(567, 163);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(PlayerChoice);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox PlayerChoice;
    private Button button1;
}
