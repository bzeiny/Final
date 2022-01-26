using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class winnerScreen : UserControl
    {
        public winnerScreen()
        {
            InitializeComponent();
        }

        private void winnerScreen_Load(object sender, EventArgs e)

            //Output which player won the game.
        {
            if (GameScreen.p1Result == "Win")
            {
                
                wsLabel.Text = $"{PreGameScreen.p1Name} Wins!";
            }
            else if (GameScreen.p2Result == "Win")
            {
             
                wsLabel.Text = $"{PreGame2.p2Name} Wins!";
            }
           
        }

        private void overButton_Click(object sender, EventArgs e)
        {
            //Close the application 
            Application.Exit();
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            //Send player back to menu screen with option to play agaib.
            replayButton.Visible = false;
            overButton.Visible = false;
            wsLabel.Visible = false;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            MenuScreen ms = new MenuScreen();
            f.Controls.Add(ms);
            ms.Location = new Point(this.Width / 2 - ms.Width / 2, this.Height / 2 - ms.Height / 2);
            
        }
    }
}
