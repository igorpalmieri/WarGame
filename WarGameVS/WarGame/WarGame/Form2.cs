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

        public Form2()
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 3);
            String[] objetivos = { "Conquistar a Ásia", "Conquistar a América do Sul", "Eliminar Bolsonaro", "Juntar 20 territórios" };
            objetivo = objetivos[aleatorio];
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
