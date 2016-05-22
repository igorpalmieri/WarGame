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
    public partial class Form_combo_ataque : Form
    {
        public Form_combo_ataque()
        {
            InitializeComponent();
        }

        private void label__Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button_ir_ataque_Click(object sender, EventArgs e)
        {
            Form_ataque frm_ataque = new Form_ataque();
            frm_ataque.Show();            
        }
    }
}
