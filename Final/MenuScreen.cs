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
using System.IO;
namespace Final

{
    public partial class MenuScreen : UserControl
    {
        //Load the menu music
        public static SoundPlayer menuPlayer = new SoundPlayer(Final.Properties.Resources.menuMusic);

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            //Play the menu music
            menuPlayer.Play();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Remove the MenuScreen and go to Player 1s Pregame Screen
            Form f = this.FindForm();
            f.Controls.Remove(this);
            PreGameScreen pgs = new PreGameScreen();
            f.Controls.Add(pgs);
            pgs.Location = new Point(f.Width / 2 - pgs.Width / 2, f.Height / 2 - pgs.Height / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }
    }
}
