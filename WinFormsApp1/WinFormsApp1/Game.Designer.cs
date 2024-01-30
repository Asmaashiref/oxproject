namespace WinFormsApp1
{
    partial class Game
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
            label1 = new Label();
            text1 = new TextBox();
            text2 = new TextBox();
            text3 = new TextBox();
            text6 = new TextBox();
            text9 = new TextBox();
            text5 = new TextBox();
            text8 = new TextBox();
            text4 = new TextBox();
            text7 = new TextBox();
            player1 = new Label();
            player2 = new Label();
            reset = new Button();
            newgame = new Button();
            savescore = new Button();
            scorex = new TextBox();
            scoreo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.9000015F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(507, 34);
            label1.Name = "label1";
            label1.Size = new Size(465, 125);
            label1.TabIndex = 0;
            label1.Text = "OX Game";
            // 
            // text1
            // 
            text1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text1.Location = new Point(84, 266);
            text1.Name = "text1";
            text1.Size = new Size(179, 167);
            text1.TabIndex = 1;
            text1.Click += TextBox_Click;
            // 
            // text2
            // 
            text2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text2.Location = new Point(283, 266);
            text2.Name = "text2";
            text2.Size = new Size(179, 167);
            text2.TabIndex = 2;
            text2.Click += TextBox_Click;
            // 
            // text3
            // 
            text3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text3.Location = new Point(484, 266);
            text3.Name = "text3";
            text3.Size = new Size(179, 167);
            text3.TabIndex = 3;
            text3.Click += TextBox_Click;
            // 
            // text6
            // 
            text6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text6.Location = new Point(484, 446);
            text6.Name = "text6";
            text6.Size = new Size(179, 167);
            text6.TabIndex = 4;
            text6.Click += TextBox_Click;
            // 
            // text9
            // 
            text9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text9.Location = new Point(484, 627);
            text9.Name = "text9";
            text9.Size = new Size(179, 167);
            text9.TabIndex = 5;
            text9.Click += TextBox_Click;
            // 
            // text5
            // 
            text5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text5.Location = new Point(283, 446);
            text5.Name = "text5";
            text5.Size = new Size(179, 167);
            text5.TabIndex = 6;
            text5.Click += TextBox_Click;
            // 
            // text8
            // 
            text8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text8.Location = new Point(283, 627);
            text8.Name = "text8";
            text8.Size = new Size(179, 167);
            text8.TabIndex = 7;
            text8.Click += TextBox_Click;
            // 
            // text4
            // 
            text4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text4.Location = new Point(84, 446);
            text4.Name = "text4";
            text4.Size = new Size(179, 167);
            text4.TabIndex = 8;
            text4.Click += TextBox_Click;
            // 
            // text7
            // 
            text7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text7.Location = new Point(84, 627);
            text7.Name = "text7";
            text7.Size = new Size(179, 167);
            text7.TabIndex = 9;
            text7.Click += TextBox_Click;
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.BackColor = Color.Transparent;
            player1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1.Location = new Point(843, 283);
            player1.Name = "player1";
            player1.Size = new Size(0, 81);
            player1.TabIndex = 10;
            // 
            // player2
            // 
            player2.AutoSize = true;
            player2.BackColor = Color.Transparent;
            player2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2.Location = new Point(843, 394);
            player2.Name = "player2";
            player2.Size = new Size(0, 81);
            player2.TabIndex = 11;
            // 
            // reset
            // 
            reset.BackColor = SystemColors.ButtonHighlight;
            reset.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset.Location = new Point(869, 505);
            reset.Name = "reset";
            reset.Size = new Size(551, 101);
            reset.TabIndex = 12;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = false;
            reset.Click += button1_Click;
            // 
            // newgame
            // 
            newgame.BackColor = SystemColors.ButtonHighlight;
            newgame.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newgame.Location = new Point(869, 612);
            newgame.Name = "newgame";
            newgame.Size = new Size(551, 101);
            newgame.TabIndex = 13;
            newgame.Text = "New Game";
            newgame.UseVisualStyleBackColor = false;
            newgame.Click += newgame_Click;
            // 
            // savescore
            // 
            savescore.BackColor = SystemColors.ButtonHighlight;
            savescore.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savescore.Location = new Point(869, 719);
            savescore.Name = "savescore";
            savescore.Size = new Size(551, 101);
            savescore.TabIndex = 14;
            savescore.Text = "Save Score";
            savescore.UseVisualStyleBackColor = false;
            savescore.Click += savescore_Click;
            // 
            // scorex
            // 
            scorex.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scorex.Location = new Point(1100, 320);
            scorex.Name = "scorex";
            scorex.Size = new Size(250, 61);
            scorex.TabIndex = 15;
            // 
            // scoreo
            // 
            scoreo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreo.Location = new Point(1100, 413);
            scoreo.Name = "scoreo";
            scoreo.Size = new Size(250, 61);
            scoreo.TabIndex = 16;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1546, 975);
            Controls.Add(scoreo);
            Controls.Add(scorex);
            Controls.Add(savescore);
            Controls.Add(newgame);
            Controls.Add(reset);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(text7);
            Controls.Add(text4);
            Controls.Add(text8);
            Controls.Add(text5);
            Controls.Add(text9);
            Controls.Add(text6);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(label1);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text1;
        private TextBox text2;
        private TextBox text3;
        private TextBox text6;
        private TextBox text9;
        private TextBox text5;
        private TextBox text8;
        private TextBox text4;
        private TextBox text7;
        private Label player1;
        private Label player2;
        private Button reset;
        private Button newgame;
        private Button savescore;
        private TextBox scorex;
        private TextBox scoreo;
    }
}