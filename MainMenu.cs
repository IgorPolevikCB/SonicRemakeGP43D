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
    public partial class MainMenu : Form
    {
        
        public static GameFormInfinite gameFormInfinite = new GameFormInfinite();
        public static SoundPlayer audioMainTheme = new SoundPlayer(SonicRemakeGP43D.Properties.Resources.mainTheme);

        public MainMenu()
        {
            InitializeComponent();
            audioMainTheme.Play();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            GameFormLevel1 gameFormLevel1 = new GameFormLevel1(this);
            gameFormLevel1.Show();
            this.Hide();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            GameFormLevel2 gameFormLevel2 = new GameFormLevel2(this);
            gameFormLevel2.Show();
            this.Hide();
        }

        public void UnlockLevel2()
        {

            if (btnLevel2.Enabled == false)
            {
                btnLevel2.Enabled = true;
            }         
        }

        public void UnlockLevel3()
        {
            if (btnLevel3.Enabled == false)
            {
                btnLevel3.Enabled = true;
            }
        }
        private void btnLevel3_Click(object sender, EventArgs e)
        {
            GameFormLevel3 gameFormLevel3 = new GameFormLevel3(this);
            gameFormLevel3.Show();
            this.Hide();
        }

        private void btnInfiniteGame_Click(object sender, EventArgs e)
        {
            GameFormInfinite gameFormInfinite = new GameFormInfinite(this);
            gameFormInfinite.Show();
            this.Hide();
        }


    }
}
