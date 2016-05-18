using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Territorio
    {
        public string Nome { get; }
        private List<Territorio> _fronteiras;
        private List<Exercito> _exercitos;

        public Territorio(string nome)
        {
            this.Nome = nome;
        }

        public Territorio(string nome, List<Territorio> fronteiras)
        {
            this.Nome = nome;
            this._fronteiras = new List<Territorio>(fronteiras);
        }
    }
}