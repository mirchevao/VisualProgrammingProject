using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class ExitMenu : Form
    {
        public int highScore;
        public Form1 game { get; set; }
        public ExitMenu()
        {
            InitializeComponent();
        }

        private void ExitMenu_Load(object sender, EventArgs e)
        {
            
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void labelScore_Paint(object sender, PaintEventArgs e)
        {
            labelScore.Text = Form1.score.ToString();
        }

        private int highScoree()
        {
            int currentScore = Form1.score;

            if(currentScore > highScore)
            {
                highScore = currentScore;
            }

            return highScore;
        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {
            int hs = highScoree();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            game = new Form1();
            this.Hide();
            game.Closed += (s, args) => this.Close();
            game.Show();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
