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
    public partial class Character : Form
    {
        public Form1 form { get; set; }
        public static Image character { get; set; }
        public int i = 0;
        // 1- easy 2- medium 3- hard
        public static int level = 0;


        public Character()
        {
            InitializeComponent();
            form = new Form1();
            character = Properties.Resources.characterBulbasaur;
        }

        private void btn_start_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_start_MouseClick(object sender, MouseEventArgs e)
        {   
            form.Show();
            this.Hide(); //za sega a krie samo, treba da se implementira na x da se gase app
            
        }

        private void Character_KeyDown(object sender, KeyEventArgs e)
        { 

            Image[] images = new Image[3];
            images[0] = Properties.Resources.characterBulbasaur;
            images[1] = Properties.Resources.characterCharmander;
            images[2] = Properties.Resources.characterSquirtle;


            if (e.KeyCode == Keys.Right)
            {
                i++;
                if (i > 2)
                {
                    i = 0;
                }
                pic_character.Image = images[i];
                
            }
            else if (e.KeyCode == Keys.Left)
            {
                i--;
                if (i < 0)
                {
                    i = 2;
                }
                pic_character.Image = images[i];
                
            }

            character = pic_character.Image;

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            level = 1;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            level = 2;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            level = 3;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            level = 3;
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            level = 2;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            level = 1;
        }
    }
}
