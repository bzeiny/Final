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
using System.Threading;
using System.IO;
namespace Final
{
    public partial class GameScreen : UserControl
    {
        //Set all strings, ints, brushes, generators
        Random randGen = new Random();
        SolidBrush playerBrush1;
        SolidBrush playerBrush2;
        SolidBrush botBrush = new SolidBrush(Color.Lime);
        Pen drawPen = new Pen(Color.White, 5);
        player p1 = new player(185, 575, 20, 1);
        player p2 = new player(605, 575, 20, 1);
        int p1score = 0;
        int p2score = 0;
        string lightColour = "Green";
        public static string p1Result;
        public static string p2Result;
        public static int counter = 0;
        public static int timeCount = 0;

        Boolean wArrowDown, upArrowDown;
        SoundPlayer gmPlayer = new SoundPlayer(Properties.Resources.gameMusic);

        int turnCounter = 0;
        public GameScreen()
        {
            //Stop the menu music
            InitializeComponent();
            MenuScreen.menuPlayer.Stop();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //Check all colour selection for player 1 and player 2, and set their shirt the corresponding colour.
            turnCounter = 150;
            if (PreGameScreen.colour1Selection == "Yellow")
            {
                playerBrush1 = new SolidBrush(Color.Yellow);
            }
            else if (PreGameScreen.colour1Selection == "Blue")
            {
                playerBrush1 = new SolidBrush(Color.Blue);
            }
            else if (PreGameScreen.colour1Selection == "Red")
            {
                playerBrush1 = new SolidBrush(Color.Red);
            }
            else if (PreGameScreen.colour1Selection == "Purple")
            {
                playerBrush1 = new SolidBrush(Color.Purple);
            }
            else if (PreGameScreen.colour1Selection == "Green")
            {
                playerBrush1 = new SolidBrush(Color.Lime);
            }
            else if (PreGameScreen.colour1Selection == "Orange")
            {
                playerBrush1 = new SolidBrush(Color.Orange);
            }

            if (PreGame2.colour2Selection == "Yellow")
            {
                playerBrush2 = new SolidBrush(Color.Yellow);
            }
            else if (PreGame2.colour2Selection == "Blue")
            {
                playerBrush2 = new SolidBrush(Color.Blue);
            }
            else if (PreGame2.colour2Selection == "Red")
            {
                playerBrush2 = new SolidBrush(Color.Red);
            }
            else if (PreGame2.colour2Selection == "Purple")
            {
                playerBrush2 = new SolidBrush(Color.Purple);
            }
            else if (PreGame2.colour2Selection == "Green")
            {
                playerBrush2 = new SolidBrush(Color.Lime);
            }
            else if (PreGame2.colour2Selection == "Orange")
            {
                playerBrush2 = new SolidBrush(Color.Orange);
            }

            //Set the background image, play the game music, and go to the CheckTurn method.
            this.BackgroundImage = Final.Properties.Resources.rlgl3;
            gmPlayer.Play();
            CheckTurn();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Paint the lines, bot, players, and colour indicator, as well as updating the game timer.
            if (lightColour == "Red")
            {
                botBrush.Color = Color.Red;
            }
            else if (lightColour == "Green")
            {
                botBrush.Color = Color.Green;
            }
            e.Graphics.DrawLine(drawPen, this.Width / 2, 95, this.Width / 2, this.Height);
            e.Graphics.DrawLine(drawPen, 0, 95, this.Width, 95);
            e.Graphics.FillRectangle(playerBrush1, p1.x, p1.y, p1.size, p1.size);
            e.Graphics.FillRectangle(playerBrush2, p2.x, p2.y, p2.size, p2.size);
            e.Graphics.FillRectangle(botBrush, 390, 65, 20, p1.size);
            int timeSecs = timeCount % 60;
            int timeMins = timeCount / 60;
            string timeString = "";

            if (timeMins < 10)
            {
                timeString += $"0{timeMins}:";
            }
            else if (timeMins >= 10)
            {
                timeString += $"{timeMins}:";
            }

            if (timeSecs < 10)
            {
                timeString += $"0{timeSecs}";
            }
            else if (timeSecs >= 10)
            {
                timeString += $"{timeSecs}";
            }
            timerLabel.Text = $"{timeString}";

        }


        //On the timer tick, check if the turn counter is 0, and which colour it is. Go to appropriate method, and get a random value between 50 and 200.
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            turnCounter--;
            if (turnCounter == 0 && lightColour == "Green")
            {
                RedLightTurn();
                lightColour = "Red";
                turnCounter = randGen.Next(50, 200);
            }
            else if (turnCounter == 0 && lightColour == "Red")
            {
                GreenLightTurn();
                lightColour = "Green";
                turnCounter = randGen.Next(50, 200);
            }

            //Check if light is green, and if so, move the player without reprocussions.

            if (lightColour == "Green")
            {
                if (wArrowDown == true)
                {
                    p1.movePlayer();
                }
                if (upArrowDown == true)
                {
                    p2.movePlayer();
                }
                counter++;

                //If player reaches the top, they win. Go to appropriate player winning screen once this occurs.
                if (counter == 60)
                {
                    timeCount++;
                    counter = 0;
                }
                if (p1.y < 570)
                {
                    p1.y = 575;
                    p1score++;
                }
                if (p2.y < 570)
                {
                    p2.y = 575;
                    p2score++;
                }
                if (p1score == 1)
                {
                    p1Result = "Win";
                    PlayerOneWinner();
                }
                if (p2score == 1)
                {
                    p2Result = "Win";
                    PlayerTwoWinner();
                }
            }

            //If light colour is red and player movement is detecte, send back to starting position.
            else if (lightColour == "Red")
            {
                if (upArrowDown == true)
                {
                    p2.y = 575;
                }
                if (wArrowDown == true)
                {
                    p1.y = 575;
                }
            }
            Refresh();
        }


        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }


        private void CheckTurn()
        {
            //Check the turn with a random value to see if its red light or green light. Play the turn sound depending on which colour. 
            int turnNumb = randGen.Next(50, 100);

            if (turnNumb == 1)
            {
                RedLightTurn();
            }
            else if (turnNumb == 2)
            {
                GreenLightTurn();
            }
        }
        System.Windows.Media.MediaPlayer turnSound = new System.Windows.Media.MediaPlayer();

        private void RedLightTurn()
        {
            // lightColour = "Red";
            turnSound.Open(new Uri(Application.StartupPath + "/Resources/redLightSound.wav"));
            turnSound.Play();
        }
        private void GreenLightTurn()
        {
            // lightColour = "Green";
            turnSound.Open(new Uri(Application.StartupPath + "/Resources/greenLightSound.wav"));
            turnSound.Play();
        }

        private void PlayerOneWinner()
        {
            //Go to the winner screen
            timerLabel.Text = "";
            Form gs = this.FindForm();
            this.Controls.Remove(this);
            winnerScreen ws = new winnerScreen();
            this.Controls.Add(ws);
            ws.Location = new Point((this.Width - ws.Width) / 2, (this.Height - ws.Height) / 2);

        }
        private void PlayerTwoWinner()
        {
            timerLabel.Text = "";
            Form gs = this.FindForm();
            this.Controls.Remove(this);
            winnerScreen ws = new winnerScreen();
            this.Controls.Add(ws);
            ws.Location = new Point((this.Width - ws.Width) / 2, (this.Height - ws.Height) / 2);
        }
    }
}
