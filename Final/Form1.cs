using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Final
//Bilal Zeineddine
//January 10, 2021
//This PC game version of the viral show Squid Games lets you play the classic favourites, such as RLGL and Glass Game! 
//Play as yourself or against a friend and compare yourself to the top times on the leaderboard!
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //As soon as the program loads, open the menu screen
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
            ms.Location = new Point(this.Width / 2 - ms.Width / 2, this.Height / 2 - ms.Height / 2);
        }
    }
}
