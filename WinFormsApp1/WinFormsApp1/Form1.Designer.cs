namespace WinFormsApp1
{
    partial class start_page
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
            O_radio1 = new RadioButton();
            Xradio1 = new RadioButton();
            Xradio2 = new RadioButton();
            Oradio2 = new RadioButton();
            startgame = new Button();
            player1 = new Label();
            player2 = new Label();
            p1name = new TextBox();
            name1 = new Label();
            p2name = new TextBox();
            name2 = new Label();
            group1 = new GroupBox();
            groupBox1 = new GroupBox();
            group1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // O_radio1
            // 
            O_radio1.AutoSize = true;
            O_radio1.BackColor = Color.Transparent;
            O_radio1.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            O_radio1.Location = new Point(91, 191);
            O_radio1.Name = "O_radio1";
            O_radio1.Size = new Size(126, 93);
            O_radio1.TabIndex = 0;
            O_radio1.TabStop = true;
            O_radio1.Text = "O";
            O_radio1.UseVisualStyleBackColor = false;
            O_radio1.CheckedChanged += O_radio1_CheckedChanged;
            // 
            // Xradio1
            // 
            Xradio1.AutoSize = true;
            Xradio1.BackColor = Color.Transparent;
            Xradio1.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xradio1.Location = new Point(400, 191);
            Xradio1.Name = "Xradio1";
            Xradio1.Size = new Size(119, 93);
            Xradio1.TabIndex = 1;
            Xradio1.TabStop = true;
            Xradio1.Text = "X";
            Xradio1.UseVisualStyleBackColor = false;
            Xradio1.CheckedChanged += Xradio1_CheckedChanged;
            // 
            // Xradio2
            // 
            Xradio2.AutoSize = true;
            Xradio2.BackColor = Color.Transparent;
            Xradio2.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xradio2.Location = new Point(450, 191);
            Xradio2.Name = "Xradio2";
            Xradio2.Size = new Size(119, 93);
            Xradio2.TabIndex = 2;
            Xradio2.TabStop = true;
            Xradio2.Text = "X";
            Xradio2.UseVisualStyleBackColor = false;
            Xradio2.CheckedChanged += Xradio2_CheckedChanged;
            // 
            // Oradio2
            // 
            Oradio2.AutoSize = true;
            Oradio2.BackColor = Color.Transparent;
            Oradio2.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Oradio2.Location = new Point(131, 191);
            Oradio2.Name = "Oradio2";
            Oradio2.Size = new Size(126, 93);
            Oradio2.TabIndex = 3;
            Oradio2.TabStop = true;
            Oradio2.Text = "O";
            Oradio2.UseVisualStyleBackColor = false;
            Oradio2.CheckedChanged += Oradio2_CheckedChanged;
            // 
            // startgame
            // 
            startgame.BackColor = Color.LightSkyBlue;
            startgame.Font = new Font("Segoe UI", 26.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startgame.Location = new Point(627, 705);
            startgame.Name = "startgame";
            startgame.Size = new Size(554, 132);
            startgame.TabIndex = 4;
            startgame.Text = "Start Game";
            startgame.UseVisualStyleBackColor = false;
            startgame.Click += button1_Click;
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.BackColor = Color.Transparent;
            player1.Font = new Font("Segoe UI", 27.9000015F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1.Location = new Point(91, 43);
            player1.Name = "player1";
            player1.Size = new Size(407, 125);
            player1.TabIndex = 5;
            player1.Text = "Player 1";
            // 
            // player2
            // 
            player2.AutoSize = true;
            player2.BackColor = Color.Transparent;
            player2.Font = new Font("Segoe UI", 27.9000015F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2.Location = new Point(131, 43);
            player2.Name = "player2";
            player2.Size = new Size(407, 125);
            player2.TabIndex = 6;
            player2.Text = "Player 2";
            // 
            // p1name
            // 
            p1name.BackColor = Color.WhiteSmoke;
            p1name.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p1name.Location = new Point(313, 464);
            p1name.Name = "p1name";
            p1name.Size = new Size(382, 97);
            p1name.TabIndex = 7;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.BackColor = Color.Transparent;
            name1.Font = new Font("Segoe UI", 21.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name1.Location = new Point(27, 464);
            name1.Name = "name1";
            name1.Size = new Size(245, 98);
            name1.TabIndex = 10;
            name1.Text = "Name";
            // 
            // p2name
            // 
            p2name.BackColor = Color.WhiteSmoke;
            p2name.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            p2name.Location = new Point(1328, 465);
            p2name.Name = "p2name";
            p2name.Size = new Size(382, 97);
            p2name.TabIndex = 11;
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.BackColor = Color.Transparent;
            name2.Font = new Font("Segoe UI", 21.9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name2.Location = new Point(1029, 460);
            name2.Name = "name2";
            name2.Size = new Size(245, 98);
            name2.TabIndex = 12;
            name2.Text = "Name";
            // 
            // group1
            // 
            group1.BackColor = Color.Transparent;
            group1.Controls.Add(player1);
            group1.Controls.Add(O_radio1);
            group1.Controls.Add(Xradio1);
            group1.Location = new Point(69, 47);
            group1.Name = "group1";
            group1.Size = new Size(778, 382);
            group1.TabIndex = 13;
            group1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(player2);
            groupBox1.Controls.Add(Oradio2);
            groupBox1.Controls.Add(Xradio2);
            groupBox1.Location = new Point(1029, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 382);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // start_page
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1865, 1028);
            Controls.Add(groupBox1);
            Controls.Add(group1);
            Controls.Add(name2);
            Controls.Add(p2name);
            Controls.Add(name1);
            Controls.Add(p1name);
            Controls.Add(startgame);
            Name = "start_page";
            Text = "start_page";
            group1.ResumeLayout(false);
            group1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton O_radio1;
        private RadioButton Xradio1;
        private RadioButton Xradio2;
        private RadioButton Oradio2;
        private Button startgame;
        private Label player1;
        private Label player2;
        private TextBox p1name;
        private Label name1;
        private TextBox p2name;
        private Label name2;
        private GroupBox group1;
        private GroupBox groupBox1;
    }
}
