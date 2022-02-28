using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern
            patternLabel.Text = $"You had a score of {Form1.pattern.Count}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen
            //TODO: remove this screen and start the GameScreen
            // f is the form "this" control is on 
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the GameScreen 
            MenuScreen mms = new MenuScreen();
            // Centre the screen on the Form 
            mms.Location = new Point((f.ClientSize.Width - mms.Width) / 2,
                 (f.ClientSize.Height - mms.Height) / 2);
            // Add UC to Form and give focus
            f.Controls.Add(mms);
            mms.Focus();
        }
    }
}
