using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGame
{
    public partial class Form_mapa : Form
    {
        private PictureBox pictureBox1;

        public Form_mapa()
        {
            InitializeComponent();
            this.SuspendLayout();
            // 
            // Form_mapa
            // 
            this.ClientSize = new System.Drawing.Size(1240, 620);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_mapa";
            this.ResumeLayout(false);

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_mapa
            // 
            this.BackgroundImage = global::WarGame.Properties.Resources.mapa;
            this.ClientSize = new System.Drawing.Size(1230, 609);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_mapa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private void Form_mapa_Load(object sender, EventArgs e)
        {

        }

        private void bt_vancouver_Click(object sender, EventArgs e)
        {
            Form_combo_ataque frm_combo_ataque = new Form_combo_ataque();
            frm_combo_ataque.Show();
        }

       
    }
}
