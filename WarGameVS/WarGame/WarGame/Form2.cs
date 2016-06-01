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
    public partial class Form2 : Form
    {
        public String objetivo;
        public String cor;

        public Form2(String cor)
        {
            this.cor = cor;
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 3);
            String[] objetivos = { "Conquistar a Ásia", "Conquistar a América do Sul", "Eliminar time ", "Juntar 20 territórios" };
            objetivo = objetivos[aleatorio];
            if(objetivo.Equals("Eliminar time "))
            {
                String[] cores = { "azul", "amarelo", "vermelho", "verde" };
                int random_int = rnd.Next(0, 3);
                String cor_adversario = cores[random_int];
                while (cor_adversario.Equals(cor))
                {
                    random_int = rnd.Next(0, 3);
                    cor_adversario = cores[random_int];
                }
                objetivo += cor_adversario;
            }
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Seu objetivo é: " + objetivo);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void picAlaska_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou em Alaska: ");
        }

        private void picOmsk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Osmk");
        }

        private void picAral_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aral");
        }

        private void picDudinka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dudinka");
        }

        private void picIndia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("india");
        }

        private void picVladvostok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vladvostok");
        }

        private void picChina_Click(object sender, EventArgs e)
        {
            MessageBox.Show("China");
        }

        private void picMongolia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mongolia");
        }

        private void picTchita_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tchita");
        }

        private void picVietnam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vietnam");
        }

        private void picSumatra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sumatra");
        }

        private void picAustralia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Australia");
        }

        private void picBorneo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Borneo");
        }

        private void picBrazil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brazil");
        }

        private void picColombia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Colombia");
        }

        private void picChile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chile");
        }

        private void picArgentina_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Argentina");
        }

        private void picNigeria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nigeria");
        }

        private void picSudan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudan");
        }

        private void picEgypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Egypt");
        }

        private void picCongo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congo");
        }

        private void picMackenzie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mackenzie");
        }

        private void picVancouver_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vancouver");
        }

        private void picOttawa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ottawa");
        }

        private void picLabrador_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labrador");
        }

        private void picGreenLand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("greenland");
        }

        private void picIceland_Click(object sender, EventArgs e)
        {
            MessageBox.Show("island");
        }

        private void picNewYork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("N Y");
        }

        private void picCalifornia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cali");
        }

        private void picMexico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mex");
        }

        private void picEngland_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Engl");
        }

        private void picSweden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Swen");
        }

        private void picGermany_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Germ");
        }

        private void picSpain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spain");
        }

        private void picPoland_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poland");
        }

        private void picMoscow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moscow");
        }

        private void picMiddleEast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mid");
        }

        private void picSiberia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siberia");
        }

        private void picJapan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("japan");
        }

        private void picNewGuinea_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Guinea");
        }

        private void picMadagascar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Madagascar");
        }

        private void picSouthAfrica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("South");
        }
    }
}
