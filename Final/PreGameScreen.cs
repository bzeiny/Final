using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Final
{
    public partial class PreGameScreen : UserControl
    {
        //Create strings for player 1s name, colour, and colour choice
        public static string p1Name, p1Colour;
        public static string colour1Selection = "";
        public PreGameScreen()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //Once the enter button is pressed, check to see if there is a valid input in the text box and if a shirt colour was selected. If not, spit out error message. If there is, switch to player 2 PGS and store choice in string.
            if (playernameBox.Text == "" || colour1Selection == "")
            {
                enterButton.Enabled = false;
                errorLabel.Text = "Please enter a valid name and colour";
                Refresh();
                Thread.Sleep(2500);
                enterButton.Enabled = true;
                errorLabel.Text = "";
            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                PreGame2 pgs2 = new PreGame2();
                f.Controls.Add(pgs2);
                pgs2.Location = new Point(f.Width / 2 - pgs2.Width / 2, f.Height / 2 - pgs2.Height / 2);
                pgs2.Focus();
                p1Name = playernameBox.Text;

            }
        }

        //For each colour select, set colour1selection to the choice and light up button pressed. Unhiglight any other selected buttons.
        private void yellowSelect_Click(object sender, EventArgs e)
        {
            yellowSelect.FlatAppearance.BorderColor = Color.White;
            yellowSelect.FlatAppearance.BorderSize = 3;
            blueSelect.FlatAppearance.BorderSize = 0;
            redSelect.FlatAppearance.BorderSize = 0;
            greenSelect.FlatAppearance.BorderSize = 0;
            purpleSelect.FlatAppearance.BorderSize = 0;
            orangeSelect.FlatAppearance.BorderSize = 0;
            colour1Selection = "Yellow";
        }

        private void blueSelect_Click(object sender, EventArgs e)
        {
            blueSelect.FlatAppearance.BorderColor = Color.White;
            blueSelect.FlatAppearance.BorderSize = 3;
            yellowSelect.FlatAppearance.BorderSize = 0;
            redSelect.FlatAppearance.BorderSize = 0;
            greenSelect.FlatAppearance.BorderSize = 0;
            purpleSelect.FlatAppearance.BorderSize = 0;
            orangeSelect.FlatAppearance.BorderSize = 0;
            colour1Selection = "Blue";
        }

        private void redSelect_Click(object sender, EventArgs e)
        {
            redSelect.FlatAppearance.BorderColor = Color.White;
            redSelect.FlatAppearance.BorderSize = 3;
            yellowSelect.FlatAppearance.BorderSize = 0;
            blueSelect.FlatAppearance.BorderSize = 0;
            greenSelect.FlatAppearance.BorderSize = 0;
            purpleSelect.FlatAppearance.BorderSize = 0;
            orangeSelect.FlatAppearance.BorderSize = 0;
            colour1Selection = "Red";
        }

        private void greenSelect_Click(object sender, EventArgs e)
        {
            greenSelect.FlatAppearance.BorderColor = Color.White;
            greenSelect.FlatAppearance.BorderSize = 3;
            yellowSelect.FlatAppearance.BorderSize = 0;
            blueSelect.FlatAppearance.BorderSize = 0;
            redSelect.FlatAppearance.BorderSize = 0;
            purpleSelect.FlatAppearance.BorderSize = 0;
            orangeSelect.FlatAppearance.BorderSize = 0;
            colour1Selection = "Green";
        }

        private void purpleSelect_Click(object sender, EventArgs e)
        {
            purpleSelect.FlatAppearance.BorderColor = Color.White;
            purpleSelect.FlatAppearance.BorderSize = 3;
            yellowSelect.FlatAppearance.BorderSize = 0;
            blueSelect.FlatAppearance.BorderSize = 0;
            redSelect.FlatAppearance.BorderSize = 0;
            greenSelect.FlatAppearance.BorderSize = 0;
            orangeSelect.FlatAppearance.BorderSize = 0;
            colour1Selection = "Purple";
        }

        private void orangeSelect_Click(object sender, EventArgs e)
        {
            orangeSelect.FlatAppearance.BorderColor = Color.White;
            orangeSelect.FlatAppearance.BorderSize = 3;
            yellowSelect.FlatAppearance.BorderSize = 0;
            blueSelect.FlatAppearance.BorderSize = 0;
            redSelect.FlatAppearance.BorderSize = 0;
            greenSelect.FlatAppearance.BorderSize = 0;
            purpleSelect.FlatAppearance.BorderSize = 0;
            colour1Selection = "Orange";
        }

        //Load the background image
        private void PreGameScreen_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Final.Properties.Resources.menuScreenTwo;
        }

    }
}
