using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class gameFrm : Form
    {
        bool turn = true; // true for X's turn, false for O's turn
        private readonly bool editCell = true; // true if the cell can be edited, false if it's already occupied
        int[,] board = new int[3, 3]; // 0 for empty, 1 for X, 2 for O
        bool gameOver = false; // true if the game is over, false otherwise
        PictureBox[,] cells;
        string name1, name2;
      
        public gameFrm(string playerNm1, string playerNm2)
        {
            InitializeComponent();
            cells = new PictureBox[3, 3] { { cell0, cell1, cell2 }, { cell3, cell4, cell5 }, { cell6, cell7, cell8 } };
            name1 = playerNm1;
            name2 = playerNm2;
            turnLabel.Text = name1;
        }
       private  void highlightWinCells( params PictureBox[]p)
        {
            foreach (var cell in p)
            {
                cell.BackColor = Color.Indigo;
            }
        }
        private void paint(object sender, PaintEventArgs e)
        {
            Color white=Color.FromArgb(255, 255, 255);
            Pen p = new Pen(white);
            p.Width = 6;
            p.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //vertical
            e.Graphics.DrawLine(p, 720, 158, 720, 460);
            e.Graphics.DrawLine(p, 890, 158, 890, 460);

            // Draw two horizontal lines
            e.Graphics.DrawLine(p, 600, 340, 1000, 340);
            e.Graphics.DrawLine(p, 600, 220, 1000, 220);
        
    }
        private void winner()
        {
            // Check rows, columns, and diagonals for a winner
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != 0 && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    string winner = board[i, 0] == 1 ? name1 : name2;
                    MessageBox.Show($"{winner} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    winnerLabel.Text = $"{winner} wins!";
                    gameOver = true;
                    highlightWinCells(cells[i, 0], cells[i, 1], cells[i, 2]);
                    return;
                }
                if (board[0, i] != 0 && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    string winner = board[0, i] == 1 ? name1 : name2;
                    MessageBox.Show($"{winner} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    winnerLabel.Text = $"{winner} wins!";
                    gameOver = true;
                    highlightWinCells(cells[0, i], cells[1, i], cells[2, i]);
                    return;
                }
            }
            if (board[0, 0] != 0 && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                string winner = board[0, 0] == 1 ? name1 : name2;
                MessageBox.Show($"{winner} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                winnerLabel.Text = $"{winner} wins!";
                gameOver = true;
                highlightWinCells(cells[0, 0], cells[1, 1], cells[2, 2]);
                return;
            }
            if (board[0, 2] != 0 && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                string winner = board[0, 2] == 1 ? name1 : name2;
                MessageBox.Show($"{winner} wins!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                winnerLabel.Text = $"{winner} wins!";
                gameOver = true;
                highlightWinCells(cells[0, 2], cells[1, 1], cells[2, 0]);
                return;
            }
            // Check for a draw
            if (board.Cast<int>().All(cell => cell != 0))
            {
                MessageBox.Show("It's a draw!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                winnerLabel.Text = "It's a draw!";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return; // Do nothing if the game is already over
            PictureBox pb = sender as PictureBox;
            int cellIndex=int.Parse(pb.Tag.ToString());
            int row = cellIndex / 3;
            int col = cellIndex % 3;
            pb.Image = null;
            pb.Update();
            if (board[row,col]==0)
            {
                if (turn)
                {
                    pb.BackgroundImage = Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
                    turn = false;
                    turnLabel.Text = name2;
                    board[row, col] = 1; // Mark X in the board array
                }
                else
                {
                    pb.BackgroundImage = Properties.Resources.radio_button_unchecked_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
                    turn = true;
                    turnLabel.Text = name1;
                    board[row, col] = 2; // Mark O in the board array
                }
            }
            else
            {
                MessageBox.Show("This cell is already occupied. Please choose another cell.", "Cell Occupied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            winner();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox[] cells = { cell0, cell1, cell2, cell3, cell4, cell5, cell6, cell7, cell8 }; 
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    board[i, j] = 0; // Reset the board array
          
                }
            }
            foreach (PictureBox cell in cells)
            {
                cell.BackgroundImage = Properties.Resources.question_mark_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24; // Clear the background image
                cell.BackColor = Color.Transparent;

            }
            turn = true; // Reset to Player 1's turn
                turnLabel.Text = ""; // Update the turn label
                winnerLabel.Text = "In progress"; // Clear the winner label
            gameOver = false; // Reset the game over flag


        }

       
    }
}
