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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // panel1.Enabled = false;
            BackgroundImage = Properties.Resources.adv2;
            buttonJogar.Visible = false;
            buttonOpt.Visible = false;
            buttonVoltar.Visible = true;
            buttonAvancar.Visible = true;
            numericUpDown1.Visible = true;
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            Form_mapa mapa = new Form_mapa();
            mapa.Show();
        }
    }
}
