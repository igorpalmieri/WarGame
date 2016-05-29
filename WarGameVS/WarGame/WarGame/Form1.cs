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
            BackgroundImage = Properties.Resources.adv_clean;
            //buttonJogar.Visible = false;
            //buttonOpt.Visible = false;
            buttonVoltar.Visible = true;
            buttonAvancar.Visible = true;
            numericUpDown1.Visible = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            this.BackgroundImage = global::WarGame.Properties.Resources.capa_clean;
            btnJogar.Visible = true;
            btnOpcoes.Visible = true;
        }

        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            //new Form_mapa().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void button1_Click_1(object sender, EventArgs e) //btnJogar
        {
            // panel1.Enabled = false;
            BackgroundImage = Properties.Resources.adv_clean;
            btnJogar.Visible = false;
            btnOpcoes.Visible = false;
            buttonVoltar.Visible = true;
            buttonAvancar.Visible = true;
            numericUpDown1.Visible = true;
            btnGloria.Visible = true;
            btnInes.Visible = true;
            btnCerebro.Visible = true;
            btnBolso.Visible = true;
            fundoVermelho.Visible = true;
            fundoVerde.Visible = true;
            fundoAmarelo.Visible = true;
            fundoAzul.Visible = true;

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.capa_clean;
            btnJogar.Visible = true;
            btnOpcoes.Visible = true;
            buttonVoltar.Visible = false;
            buttonAvancar.Visible = false;
            numericUpDown1.Visible = false;
            btnGloria.Visible = false;
            btnInes.Visible = false;
            btnCerebro.Visible = false;
            btnBolso.Visible = false;
            fundoAmarelo.Visible = false;
            fundoVerde.Visible = false;
            fundoVermelho.Visible = false;
            fundoAzul.Visible = false;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            btnGloria.BackgroundImage = Properties.Resources.gloria_sad;
            btnBolso.BackgroundImage = Properties.Resources.bolso_sad;
            btnCerebro.BackgroundImage = Properties.Resources.pink_feliz;
            btnInes.BackgroundImage = Properties.Resources.ines_sad;
        }

        private void btnVerde_Click(object sender, EventArgs e) //gloria
        {
            btnGloria.BackgroundImage = Properties.Resources.gloria_feliz;
            btnBolso.BackgroundImage = Properties.Resources.bolso_sad;
            btnCerebro.BackgroundImage = Properties.Resources.cerebro_sad;
            btnInes.BackgroundImage = Properties.Resources.ines_sad;
        }

        private void btnBolso_Click(object sender, EventArgs e)
        {
            btnGloria.BackgroundImage = Properties.Resources.gloria_sad;
            btnBolso.BackgroundImage = Properties.Resources.bolso_feliz;
            btnCerebro.BackgroundImage = Properties.Resources.cerebro_sad;
            btnInes.BackgroundImage = Properties.Resources.ines_sad;
        }

        private void btnInes_Click(object sender, EventArgs e)
        {
            btnGloria.BackgroundImage = Properties.Resources.gloria_sad;
            btnBolso.BackgroundImage = Properties.Resources.bolso_sad;
            btnCerebro.BackgroundImage = Properties.Resources.cerebro_sad;
            btnInes.BackgroundImage = Properties.Resources.ines_feliz;
        }
    }
}
