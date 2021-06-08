using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer musicPlayer = new WindowsMediaPlayer();
        int playerMovement = 15;
        PictureBox[] enemyballs;
        PictureBox masterball;
        int[] enemyspeed;
        int masterballspeed;
        int enemynum;
        Random random = new Random();
        int score = 0;
        public Character character { get; set; }
        

        public Form1()
        {
            InitializeComponent();
            musicPlayer.URL = "pokemonThemeSong.mp3";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Character.level == 1)
            {
                enemynum = 5;
            }
            else if (Character.level == 2)
            {
                enemynum = 10;
            }
            else if (Character.level == 3)
            {
                enemynum = 15;
            }
            musicPlayer.controls.play();
            enemyballs = new PictureBox[enemynum];
            enemyspeed = new int[enemynum];

            timerGame.Enabled = true;
            timerGame.Interval = 150;
            score = 0;
            labelScore.Text = "" + score;
            pokemon.BackgroundImage = Character.character;

            for (int i=0; i<enemynum; i++)
            {
                enemyballs[i] = new PictureBox();
                enemyballs[i].BackgroundImage = Properties.Resources.pokeball;
                enemyballs[i].BackColor = Color.Transparent;
                enemyballs[i].BackgroundImageLayout = ImageLayout.Zoom;
                enemyballs[i].BringToFront();

                enemyballs[i].Height = 50;
                enemyballs[i].Width = 50;

                enemyballs[i].Top = 0;
                enemyballs[i].Left = random.Next(0, this.ClientRectangle.Width - enemyballs[i].Width);

                enemyspeed[i] = random.Next(10, 30);

                Controls.Add(enemyballs[i]);
            }

            masterball = new PictureBox();
            masterball.BackgroundImage = Properties.Resources.masterball;
            masterball.BackColor = Color.Transparent;
            masterball.BackgroundImageLayout = ImageLayout.Zoom;
            masterball.BringToFront();

            masterball.Height = 30;
            masterball.Width = 30;

            masterball.Top = 0;
            masterball.Left = random.Next(0, this.ClientRectangle.Width - masterball.Width);

            masterballspeed = random.Next(1, 10);

            Controls.Add(masterball);
        }

        //↓↓↓ Движење во четири насоки со притиснување на стрелките на тастатурата (горе, долу, лево, десно)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (pokemon.Top > 5)
                {
                    pokemon.Top -= playerMovement;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (pokemon.Top < 670 - pokemon.Height)
                {
                    pokemon.Top += playerMovement;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (pokemon.Left > 10)
                {
                    pokemon.Left -= playerMovement;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pokemon.Left < 1040 - pokemon.Width)
                {
                    pokemon.Left += playerMovement;
                }
            }
            
            pokemon.SendToBack();
        }

        //↓↓↓ Двојно баферирање на прозорец заедно со сите контроли со цел да не се забележува лагирање при движење на покемонот во околината.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void pokemon_Click(object sender, EventArgs e)
        {

        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            for(int i=0; i<enemynum; i++)
            {
                enemyballs[i].Top += enemyspeed[i];

                if (pokemon.Bounds.IntersectsWith(enemyballs[i].Bounds))
                {
                    timerGame.Enabled = false;
                    MessageBox.Show("Game Over");
                    
                }

                if(enemyballs[i].Top + enemyballs[i].Height > this.ClientRectangle.Height)
                {
                    score += 1;
                    labelScore.Text = "" + score;
                    enemyballs[i].Top = 0;
                    enemyballs[i].Left = random.Next(0, this.ClientRectangle.Width - enemyballs[i].Width);
                }
            }

            masterball.Top += masterballspeed;
            if(masterball.Top + masterball.Height > this.ClientRectangle.Height)
            {
                masterball.Top = 0;
                masterball.Left = random.Next(0, this.ClientRectangle.Width - masterball.Width);
            }
            if (pokemon.Bounds.IntersectsWith(masterball.Bounds))
            {
                score += 3;
                labelScore.Text = "" + score;
                masterball.Top = 0;
                masterball.Left = random.Next(0, this.ClientRectangle.Width - masterball.Width);
            }
        }
    }
}
