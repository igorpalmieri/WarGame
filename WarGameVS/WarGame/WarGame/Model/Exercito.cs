using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Exercito
    {
		public  Jogador    Comandante { get; set; }
		private Territorio _territorioOcupado = null;
		public  Territorio TerritorioOcupado 
		{ 
			get { return this._territorioOcupado; } 
			set { this._territorioOcupado = value; } 
		}

        public Exercito(Jogador comandante)
        {
            this.Comandante = comandante;
        }
    }
}
