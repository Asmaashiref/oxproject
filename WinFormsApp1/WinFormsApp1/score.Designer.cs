namespace WinFormsApp1
{
    partial class score
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
            gamescore = new Label();
            save = new Button();
            dataGridView1 = new DataGridView();
            delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gamescore
            // 
            gamescore.AutoSize = true;
            gamescore.BackColor = Color.Transparent;
            gamescore.Font = new Font("Segoe UI", 26.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gamescore.Location = new Point(623, 36);
            gamescore.Name = "gamescore";
            gamescore.Size = new Size(535, 116);
            gamescore.TabIndex = 0;
            gamescore.Text = "Game Score";
            // 
            // save
            // 
            save.BackColor = Color.White;
            save.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(848, 214);
            save.Name = "save";
            save.Size = new Size(499, 91);
            save.TabIndex = 4;
            save.Text = "Save Ghanges";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(81, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1542, 483);
            dataGridView1.TabIndex = 5;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // delete
            // 
            delete.BackColor = Color.White;
            delete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(312, 214);
            delete.Name = "delete";
            delete.Size = new Size(499, 91);
            delete.TabIndex = 11;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // score
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1813, 905);
            Controls.Add(delete);
            Controls.Add(dataGridView1);
            Controls.Add(save);
            Controls.Add(gamescore);
            Name = "score";
            Text = "score";
            Load += score_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gamescore;
        private Button save;
        private DataGridView dataGridView1;
        private Button delete;
    }
}