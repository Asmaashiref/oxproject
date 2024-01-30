namespace WinFormsApp1
{
    public partial class start_page : Form
    {

        public start_page()
        {
            InitializeComponent();
        }

        char player1_choice;
        char player2_choice;

        private void button1_Click(object sender, EventArgs e)
        {
            string player1_name = p1name.Text;
            string player2_name = p2name.Text;
            if (O_radio1.Checked)
            {
                player1_choice = 'O';
                player2_choice = 'X';
            }
            else
            {
                player1_choice = 'X';
                player2_choice = 'O';
            }
            string massage = $"Player1 {player1_name} will play with '{player1_choice}' and Player2 {player2_name} will play with '{player2_choice}'";
            MessageBox.Show(massage, "Confirmation", MessageBoxButtons.OK);
            Game game = new Game(player1_name, player2_name);
            game.ShowDialog();
            this.Close();

        }

        private void O_radio1_CheckedChanged(object sender, EventArgs e)
        {
            DetachEventHandlers();
            Xradio2.Checked = true;
            AttachEventHandlers();
        }

        private void Xradio1_CheckedChanged(object sender, EventArgs e)
        {
            DetachEventHandlers();
            Oradio2.Checked = true;
            AttachEventHandlers();
        }

        private void Oradio2_CheckedChanged(object sender, EventArgs e)
        {
            DetachEventHandlers();
            Xradio1.Checked = true;
            AttachEventHandlers();
        }

        private void Xradio2_CheckedChanged(object sender, EventArgs e)
        {
            DetachEventHandlers();
            O_radio1.Checked = true;
            AttachEventHandlers();
        }
        private void DetachEventHandlers()
        {
            // Detach event handlers temporarily
            O_radio1.CheckedChanged -= O_radio1_CheckedChanged;
            Xradio1.CheckedChanged -= Xradio1_CheckedChanged;
            Oradio2.CheckedChanged -= Oradio2_CheckedChanged;
            Xradio2.CheckedChanged -= Xradio2_CheckedChanged;
        }
        private void AttachEventHandlers()
        {
            // Reattach event handlers
            O_radio1.CheckedChanged += O_radio1_CheckedChanged;
            Xradio1.CheckedChanged += Xradio1_CheckedChanged;
            Oradio2.CheckedChanged += Oradio2_CheckedChanged;
            Xradio2.CheckedChanged += Xradio2_CheckedChanged;
        }

    }
}
