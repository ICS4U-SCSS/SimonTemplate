using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        int guess = 0;
        Random randgen = new Random();
    SoundPlayer = new SoundPlayer blue ;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO: clear the pattern list from form1, refresh, pause for a bit, and run ComputerTurn()
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(500);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list
            Form1.pattern.Add(randgen.Next(0, 4));
            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button


            for (int i = 0; i < Form1.pattern.Count; i++)
            {

                if (Form1.pattern[i] == 0)
                {
                    redButton.BackColor = Color.LightSalmon;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.DarkRed;
                    Refresh();
                    Thread.Sleep(500);


                }
                if (Form1.pattern[i] == 1)
                {
                    greenButton.BackColor = Color.LightGreen;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.ForestGreen;
                    Refresh();
                    Thread.Sleep(200);
                }
                if (Form1.pattern[i] == 2)
                {
                    blueButton.BackColor = Color.LightCyan;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.DarkBlue;
                    Refresh();
                    Thread.Sleep(200);
                }
                if (Form1.pattern[i] == 3)
                {
                    yellowButton.BackColor = Color.LightYellow;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refresh();
                    Thread.Sleep(200);

                }

            }
            //TODO: get guess index value back to 0
            guess = 0;
        }

        public void GameOver()
        {
            //TODO: Play a game over sound

            //TODO: close this screen and open the GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameOverScreen gs = new GameOverScreen();
            // Centre the screen on the Form 
            gs.Location = new Point((f.ClientSize.Width - gs.Width) / 2,
                 (f.ClientSize.Height - gs.Height) / 2);
            // Add UC to Form and give focus
            f.Controls.Add(gs);
            gs.Focus();

        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value at current guess index equal to a green. If so:
            // light up button, play sound, and pause

            if (Form1.pattern[guess] == 1)
            {
                greenButton.BackColor = Color.LightGreen;
                Refresh();
                Thread.Sleep(300);
                Refresh();
                greenButton.BackColor = Color.ForestGreen;
                Refresh();
                Thread.Sleep(100);
                guess++;
            }
            else 
            {
                GameOver();
            }
            if (Form1.pattern.Count==guess)
            { ComputerTurn(); }

            // set button colour back to original
            // add one to the guess index
            // check to see if we are at the end of the pattern. If so:
            // call ComputerTurn() method
            // else call GameOver method
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            
            if (Form1.pattern[guess] == 0)
            {
                redButton.BackColor = Color.Salmon;
                Refresh();
                Thread.Sleep(100);
                Refresh();
                redButton.BackColor = Color.DarkRed;
                Refresh();
                Thread.Sleep(500);
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess)
            { ComputerTurn(); }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                yellowButton.BackColor = Color.LightYellow;
                Refresh();
                Thread.Sleep(100);
                yellowButton.BackColor = Color.Goldenrod;
                Refresh();
                Thread.Sleep(500);
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess)
            { ComputerTurn(); }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 2)
            {
                blueButton.BackColor = Color.LightBlue;
                Refresh();
                Thread.Sleep(100);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                Thread.Sleep(500);
                guess++;
            }
            else
            {
                GameOver();
            }
            if (Form1.pattern.Count == guess)
            { ComputerTurn(); }
        }
    }
}
