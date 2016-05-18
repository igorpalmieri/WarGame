using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Continente
    {
        public string Nome { get; }
        private List<Territorio> _territorios;

        public Continente(string nome, List<Territorio> territorios)
        {
            this.Nome = nome;
            this._territorios = new List<Territorio>(territorios);
        }
    }
}