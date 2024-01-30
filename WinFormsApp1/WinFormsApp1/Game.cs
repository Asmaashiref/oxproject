using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Game : Form
    {
        private char[,] board = new char[3, 3];
        private char currentPlayer = 'X';
        private int playerXScore = 0;
        private int playerOScore = 0;
        private string player1_name;
        private string player2_name;

        SqlConnection con;

        public Game(string player1_name, string player2_name)
        {
            this.player1_name = player1_name;
            this.player2_name = player2_name;
            InitializeComponent();
            InitializeBoard();
            con = new SqlConnection("Server=.;Database=oxdatabase;Trusted_Connection=True;TrustServerCertificate=True");
        }

        private void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                    TextBox textBox = new TextBox
                    {
                        ReadOnly = true
                    };
                    textBox.Click += TextBox_Click;
                    Controls.Add(textBox);
                }
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (TextBox)sender;
            int index = int.Parse(clickedTextBox.Name.Substring(4)) - 1;
            int row = index / 3;
            int col = index % 3;

            if (board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                clickedTextBox.Text = currentPlayer.ToString();

                CheckForWinner();
                

                if (IsBoardFull())
                {
                    MessageBox.Show("No one win");
                    //ResetGame();
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
            
        }



        private bool CheckForWinner()
        {
            // Check rows, columns, and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    Updatescore(currentPlayer);
                    return true;

                }


                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    Updatescore(currentPlayer);
                    return true;

                }
            }

            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                Updatescore(currentPlayer);
                return true;

            }

            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                Updatescore(currentPlayer);
                return true;

            }
            return false;
        }

        private bool IsBoardFull()
        {
            // Check if the board is full (no empty spaces)
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                        return false;
                }
            }
            return true;
        }
        private void Updatescore(char winner)
        {
            if (winner == 'X')
            {
                playerXScore++;
                scorex.Text = playerXScore.ToString();
                scoreo.Text = "0";
            }
            
            else if (winner == 'O')
            {
                playerOScore++;
                scoreo.Text = playerOScore.ToString();
                scorex.Text = "0";
            }
            //else
            //{
            //    resetscore();
            //}
        }
        private void resetscore()
        {
            playerXScore = 0;
            playerOScore = 0;
            scoreo.Text = "0";
            scorex.Text = "0";
        }

        private void Game_Load(object sender, EventArgs e)
        {
            player1.Text = player1_name;
            player2.Text = player2_name;
          
        }

        private void button1_Click(object sender, EventArgs e)

        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
            }

            InitializeBoard();
            currentPlayer = 'X';

          
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
            }

            InitializeBoard();
            currentPlayer = 'X';
            resetscore();
        }

        private void savescore_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"insert into gamedata([p1name],[score1],[p2name],[score2],[gamedate]) values('{player1.Text}','{scorex.Text}','{player2.Text}','{scoreo.Text}',getdate())", con);
            int rowsEffected = 0;
            try
            {
                // open connection
                con.Open();
                // exceute
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close connection
                con.Close();
            }

            if (rowsEffected > 0)
            {
                MessageBox.Show("Data was insereted");

            }
            score score = new score();
            score.ShowDialog();
            this.Close();
        }
    }
}

