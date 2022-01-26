using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Final
{

    public partial class PreGame2 : UserControl
    {
        //Create strings for Player 2s colour selection, name, and colour
        public static string colour2Selection = "";
        public static string p2Name, p2Colour;
        public PreGame2()
        {
            InitializeComponent();
        }

        private void enterButton2_Click(object sender, EventArgs e)
        {
            //Once the enter button is pressed, check to see if there is a valid input in the text box and if a shirt colour was selected. If not, spit out error message. If there is, switch to game screen and store name in string.
            if (playernameBox2.Text == "" || colour2Selection == "")
            {
                enterButton2.Enabled = false;
                errorLabel2.Text = "Please enter a valid name and colour";
                Refresh();
                Thread.Sleep(2500);
                enterButton2.Enabled = true;
                errorLabel2.Text = "";
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                GameScreen gs = new GameScreen();
                f.Controls.Add(gs);
                gs.Location = new Point(f.Width / 2 - gs.Width / 2, f.Height / 2 - gs.Height / 2);
                gs.Focus();
                p2Name = playernameBox2.Text;
            }
        }


        //Load background image
        private void PreGame2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Final.Properties.Resources.menuScreenTwo;
        }

        //For each colour select, set colour1selection to the choice and light up button pressed. Unhiglight any other selected buttons.
        private void yellowSelect2_Click(object sender, EventArgs e)
        {
            yellowSelect2.FlatAppearance.BorderColor = Color.White;
            yellowSelect2.FlatAppearance.BorderSize = 3;
            blueSelect2.FlatAppearance.BorderSize = 0;
            redSelect2.FlatAppearance.BorderSize = 0;
            greenSelect2.FlatAppearance.BorderSize = 0;
            purpleSelect2.FlatAppearance.BorderSize = 0;
            orangeSelect2.FlatAppearance.BorderSize = 0;
            colour2Selection = "Yellow";
        }

        private void blueSelect2_Click(object sender, EventArgs e)
        {
            blueSelect2.FlatAppearance.BorderColor = Color.White;
            blueSelect2.FlatAppearance.BorderSize = 3;
            yellowSelect2.FlatAppearance.BorderSize = 0;
            redSelect2.FlatAppearance.BorderSize = 0;
            greenSelect2.FlatAppearance.BorderSize = 0;
            purpleSelect2.FlatAppearance.BorderSize = 0;
            orangeSelect2.FlatAppearance.BorderSize = 0;
            colour2Selection = "Blue";
        }

        private void redSelect2_Click(object sender, EventArgs e)
        {
            redSelect2.FlatAppearance.BorderColor = Color.White;
            redSelect2.FlatAppearance.BorderSize = 3;
            yellowSelect2.FlatAppearance.BorderSize = 0;
            blueSelect2.FlatAppearance.BorderSize = 0;
            greenSelect2.FlatAppearance.BorderSize = 0;
            purpleSelect2.FlatAppearance.BorderSize = 0;
            orangeSelect2.FlatAppearance.BorderSize = 0;
            colour2Selection = "Red";
        }

        private void greenSelect2_Click(object sender, EventArgs e)
        {
            greenSelect2.FlatAppearance.BorderColor = Color.White;
            greenSelect2.FlatAppearance.BorderSize = 3;
            yellowSelect2.FlatAppearance.BorderSize = 0;
            blueSelect2.FlatAppearance.BorderSize = 0;
            redSelect2.FlatAppearance.BorderSize = 0;
            purpleSelect2.FlatAppearance.BorderSize = 0;
            orangeSelect2.FlatAppearance.BorderSize = 0;
            colour2Selection = "Green";
        }

        private void purpleSelect2_Click(object sender, EventArgs e)
        {
            purpleSelect2.FlatAppearance.BorderColor = Color.White;
            purpleSelect2.FlatAppearance.BorderSize = 3;
            yellowSelect2.FlatAppearance.BorderSize = 0;
            blueSelect2.FlatAppearance.BorderSize = 0;
            redSelect2.FlatAppearance.BorderSize = 0;
            greenSelect2.FlatAppearance.BorderSize = 0;
            orangeSelect2.FlatAppearance.BorderSize = 0;
            colour2Selection = "Purple";
        }

        private void playernameBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void orangeSelect2_Click(object sender, EventArgs e)
        {
            orangeSelect2.FlatAppearance.BorderColor = Color.White;
            orangeSelect2.FlatAppearance.BorderSize = 3;
            yellowSelect2.FlatAppearance.BorderSize = 0;
            blueSelect2.FlatAppearance.BorderSize = 0;
            redSelect2.FlatAppearance.BorderSize = 0;
            greenSelect2.FlatAppearance.BorderSize = 0;
            purpleSelect2.FlatAppearance.BorderSize = 0;
            colour2Selection = "Orange";
        }
    }
}
