﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //TODO: create a List to store the pattern. Must be accessable on other screens
        public static List <int> pattern = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Launch MenuScreen
            // Create an instance of the MainScreen 
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            // Centre the screen on the Form  
            ms.Location = new Point((this.ClientSize.Width - ms.Width) / 2,

                (this.ClientSize.Height - ms.Height) / 2);

            // Add UC to Form and give focus

            ms.Focus();



        }
    }
}
