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
    }
}
