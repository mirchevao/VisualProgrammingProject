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

        public Character()
        {
            InitializeComponent();
            form = new Form1();
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
            if(e.KeyCode == Keys.Right)
            {
                pic_character.Image = Properties.Resources.characterCharmander;
                
            } else if (e.KeyCode == Keys.Left)
            {
                pic_character.Image = Properties.Resources.characterBulbasaur;

            }
            character = pic_character.Image;

        }
    }
}
