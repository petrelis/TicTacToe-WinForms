using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Visual
{
    public partial class Form1 : Form
    {
        int moves = 0;
        bool gameEnded = false;

        Button[,] btnArray = new Button[3, 3];

        private Button[,] Create_Buttons()
        {
            btnArray = new Button[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    btnArray[i, j] = new Button();
                    btnArray[i, j].Font = new Font("Microsoft Sans Serif", 32F);
                    btnArray[i, j].ForeColor = SystemColors.MenuText;
                    btnArray[i, j].Location = new Point(i*200, j*200+162);
                    btnArray[i, j].Size = new Size(200, 200);
                    int pos = j * 3 + i;
                    btnArray[i, j].TabIndex = pos;
                    btnArray[i, j].Name ="button" + pos.ToString();
                    btnArray[i, j].UseVisualStyleBackColor = true;
                    Controls.Add(btnArray[i, j]); ;
                    btnArray[i, j].Click += new EventHandler(ClickButton);
                }
            }
            return btnArray;

        }

        public void ClickButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (gameEnded) NewGame();
            else
            {
                if (moves % 2 == 0)
                {
                    btn.Text = "X";
                    btn.BackgroundImage = Image.FromFile("C:\\Users\\visti\\Desktop\\Python\\game\\player.png");
                    btn.ForeColor = Color.Red;
                }
                
                else
                {
                    btn.Text = "O";
                    btn.ForeColor = Color.Blue;
                }
                btn.Click -= new EventHandler(ClickButton);

                moves++;
                if (moves > 8)
                {
                    gameEnded = true;
                    resultLabel.Text = "Draw!";
                    restartLabel.Text = "Press any button to play again";
                    ResetButtonClick();

                }

                string winner = CheckWin();

                if (winner == "X" || winner == "O")
                {
                    resultLabel.Text = winner + " Won!";
                    restartLabel.Text = "Press any button to play again";
                    gameEnded = true;
                    ResetButtonClick();
                }

                


            }


        }


        private string CheckWin()
        {
            if (moves < 4) return "";

            int xCountVertical = 0;
            int oCountVertical = 0;
            int xCountHorizontal = 0;
            int oCountHorizontal = 0;

            if ( ((btnArray[0,0].Text == btnArray[1,1].Text && btnArray[2,2].Text == btnArray[0, 0].Text) 
                || (btnArray[0,2].Text == btnArray[1,1].Text && btnArray[0,2].Text == btnArray[2, 0].Text))
                && btnArray[1, 1].Text != "")
            {
                return btnArray[1, 1].Text;
            }

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (btnArray[i, j].Text == "X") xCountVertical++;
                    if (xCountVertical > 2) return "X";

                    if (btnArray[i, j].Text == "O") oCountVertical++;
                    if (oCountVertical > 2) return "O";

                    if (btnArray[j, i].Text == "X") xCountHorizontal++;
                    if (xCountHorizontal > 2) return "X";

                    if (btnArray[j, i].Text == "O") oCountHorizontal++;
                    if (oCountHorizontal > 2) return "O";

                }
                xCountVertical = 0;
                oCountVertical = 0;
                xCountHorizontal = 0;
                oCountHorizontal = 0;

            }
            
            return "";
        }

        private void ResetButtonClick()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btnArray[i, j].Click -= new EventHandler(ClickButton);
                    btnArray[i, j].Click += new EventHandler(ClickButton);
                }
            }
        }

        private void NewGame()
        {
            gameEnded = false;
            moves = 0;
            resultLabel.Text = "";
            restartLabel.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btnArray[i, j].Text = "";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            Create_Buttons();
        }
    }
}
