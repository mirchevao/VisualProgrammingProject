namespace Game
{
    partial class Character
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character));
            this.btn_start = new System.Windows.Forms.Panel();
            this.pic_character = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_character)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::Game.Properties.Resources.start;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Location = new System.Drawing.Point(300, 302);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(171, 51);
            this.btn_start.TabIndex = 3;
            this.btn_start.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_start_Paint);
            this.btn_start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_start_MouseClick);
            // 
            // pic_character
            // 
            this.pic_character.Image = global::Game.Properties.Resources.characterBulbasaur;
            this.pic_character.Location = new System.Drawing.Point(300, 123);
            this.pic_character.Name = "pic_character";
            this.pic_character.Size = new System.Drawing.Size(171, 152);
            this.pic_character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_character.TabIndex = 0;
            this.pic_character.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(529, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 75);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Game.Properties.Resources.left_red;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(160, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 75);
            this.panel2.TabIndex = 1;
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pic_character);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Character";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Character_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_character)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pic_character;
        private System.Windows.Forms.Panel btn_start;
    }
}