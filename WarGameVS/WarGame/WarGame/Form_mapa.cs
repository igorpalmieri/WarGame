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
