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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //TODO: remove this screen and start the GameScreen
            // f is the form "this" control is on 
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the GameScreen 
            GameScreen ss = new GameScreen();
            // Centre the screen on the Form 
            ss.Location = new Point((f.ClientSize.Width - ss.Width) / 2,
                 (f.ClientSize.Height - ss.Height) / 2);
            // Add UC to Form and give focus
            f.Controls.Add(ss);
            ss.Focus();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            //TODO: end the application
            Application.Exit();            
        }
    }
}
