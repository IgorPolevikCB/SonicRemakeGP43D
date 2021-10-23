using SonicRemakeGP43D.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicRemakeGP43D
{
    public partial class GameFormLevel1 : Form
    {
        public static SoundPlayer audioDead = new SoundPlayer(SonicRemakeGP43D.Properties.Resources.dead);
        public static SoundPlayer audioWon = new SoundPlayer(SonicRemakeGP43D.Properties.Resources.won);


        Player player;
        Timer mainTimer;
        MainMenu mainMenu;
        public GameFormLevel1(MainMenu menu)
        {
            InitializeComponent();

            this.Width = 700;
            this.Height = 300;
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(DrawGame);
            this.KeyUp += new KeyEventHandler(OnKeyboardUp);
            this.KeyDown += new KeyEventHandler(OnKeyboardDown);
            mainTimer = new Timer();
            mainTimer.Interval = 10;
            mainTimer.Tick += new EventHandler(Update);
            mainMenu = menu;
            Init();
        }

        private void OnKeyboardDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (!player.physics.isJumping)
                    {
                        player.physics.isCrouching = true;
                        player.physics.isJumping = false;
                        player.physics.transform.size.Height = 25;
                        player.physics.transform.position.Y = 174;
                    }
                    break;
            }
        }

        private void OnKeyboardUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (!player.physics.isCrouching)
                    {
                        player.physics.isCrouching = false;
                        player.physics.AddForce();
                    }
                    break;
                case Keys.Down:
                    player.physics.isCrouching = false;
                    player.physics.transform.size.Height = 50;
                    player.physics.transform.position.Y = 150.2f;
                    break;
            }
        }

        public void Init()
        {
            GameController.Init();
            player = new Player(new PointF(50, 149), new Size(50, 50));
            mainTimer.Start();
            Invalidate();
        }

        public void Update(object sender, EventArgs e)
        {
       
            if (player.score >= 1000)
            {
                mainTimer.Stop();
                GameController.StopMusic();
                audioWon.Play();
                DialogResult res = MessageBox.Show("Level 1 passed!\n" + "Your Score is: " + player.score, "You won", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    
                    mainMenu.Show();
                    mainMenu.UnlockLevel2();
                    this.Close();

                }
                

            }
            player.score++;
            this.label1.Text = "Score: " + player.score;

            if (player.physics.Collide())
            {

                mainTimer.Stop();
                GameController.StopMusic();
                audioDead.Play();
                DialogResult res = MessageBox.Show("Your Score is: " + player.score +"\n"+ "Restart the game?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Init();

                }
                if (res == DialogResult.No)
                {
                    mainMenu.Show();
                    Close();

                }
            }

            player.physics.ApplyPhysics();
            GameController.MoveMap();
            Invalidate();

           
        }

        private void DrawGame(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            player.DrawSprite(g);
            GameController.DrawObjets(g);
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
           GameController.StopMusic();

            DialogResult res = MessageBox.Show("Your Score is: " + player.score, "Game Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                mainMenu.Show();
                Close();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            GameController.StopMusic();
            mainMenu.Show();
            this.Close();
        }

        private void musicONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.PlayMusic();
        }

        private void musicOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.StopMusic();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
