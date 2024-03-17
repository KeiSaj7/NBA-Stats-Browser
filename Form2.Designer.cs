namespace NBA_Stats_Browser
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlayerInfoButton = new Button();
            panelSide = new Panel();
            LineCheckButton = new Button();
            PlayerAveragesButton = new Button();
            TeamInfoButton = new Button();
            panelTop = new Panel();
            panelMain = new Panel();
            textBox1 = new TextBox();
            panelSide.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // PlayerInfoButton
            // 
            PlayerInfoButton.FlatAppearance.BorderSize = 2;
            PlayerInfoButton.FlatStyle = FlatStyle.Flat;
            PlayerInfoButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PlayerInfoButton.ForeColor = Color.White;
            PlayerInfoButton.Location = new Point(50, 50);
            PlayerInfoButton.Name = "PlayerInfoButton";
            PlayerInfoButton.Size = new Size(156, 42);
            PlayerInfoButton.TabIndex = 0;
            PlayerInfoButton.Text = "PLAYER INFO";
            PlayerInfoButton.UseVisualStyleBackColor = true;
            PlayerInfoButton.Click += PlayerInfoButton_Click;
            // 
            // panelSide
            // 
            panelSide.BackColor = SystemColors.MenuHighlight;
            panelSide.Controls.Add(LineCheckButton);
            panelSide.Controls.Add(PlayerAveragesButton);
            panelSide.Controls.Add(TeamInfoButton);
            panelSide.Controls.Add(PlayerInfoButton);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 39);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(267, 561);
            panelSide.TabIndex = 4;
            // 
            // LineCheckButton
            // 
            LineCheckButton.FlatAppearance.BorderSize = 2;
            LineCheckButton.FlatStyle = FlatStyle.Flat;
            LineCheckButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LineCheckButton.ForeColor = Color.White;
            LineCheckButton.Location = new Point(50, 362);
            LineCheckButton.Name = "LineCheckButton";
            LineCheckButton.Size = new Size(156, 42);
            LineCheckButton.TabIndex = 3;
            LineCheckButton.Text = "LINE CHECK";
            LineCheckButton.UseVisualStyleBackColor = true;
            LineCheckButton.Click += LineCheckButton_Click;
            // 
            // PlayerAveragesButton
            // 
            PlayerAveragesButton.FlatAppearance.BorderSize = 2;
            PlayerAveragesButton.FlatStyle = FlatStyle.Flat;
            PlayerAveragesButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PlayerAveragesButton.ForeColor = Color.White;
            PlayerAveragesButton.Location = new Point(50, 259);
            PlayerAveragesButton.Name = "PlayerAveragesButton";
            PlayerAveragesButton.Size = new Size(156, 42);
            PlayerAveragesButton.TabIndex = 2;
            PlayerAveragesButton.Text = "PLAYER AVERAGES";
            PlayerAveragesButton.UseVisualStyleBackColor = true;
            PlayerAveragesButton.Click += PlayerAveragesButton_Click;
            // 
            // TeamInfoButton
            // 
            TeamInfoButton.FlatAppearance.BorderSize = 2;
            TeamInfoButton.FlatStyle = FlatStyle.Flat;
            TeamInfoButton.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            TeamInfoButton.ForeColor = Color.White;
            TeamInfoButton.Location = new Point(50, 149);
            TeamInfoButton.Name = "TeamInfoButton";
            TeamInfoButton.Size = new Size(156, 42);
            TeamInfoButton.TabIndex = 1;
            TeamInfoButton.Text = "TEAM INFO";
            TeamInfoButton.UseVisualStyleBackColor = true;
            TeamInfoButton.Click += TeamInfoButton_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.HotTrack;
            panelTop.Controls.Add(textBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 39);
            panelTop.TabIndex = 5;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(267, 39);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(933, 561);
            panelMain.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(-48, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(381, 30);
            textBox1.TabIndex = 0;
            textBox1.Text = "NBA Stats Browser";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(panelMain);
            Controls.Add(panelSide);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            panelSide.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button PlayerInfoButton;
        private Panel panelSide;
        private Panel panelTop;
        private Panel panelMain;
        private Button LineCheckButton;
        private Button PlayerAveragesButton;
        private Button TeamInfoButton;
        private TextBox textBox1;
    }
}