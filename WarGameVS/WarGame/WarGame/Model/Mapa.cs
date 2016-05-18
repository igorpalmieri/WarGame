using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Mapa
    {
        private List<Continente> _continentes;
        
        public Mapa()
        {
            this._continentes = new List<Continente>();
        }

        public Mapa(List<Continente> continentes)
        {
            this._continentes = new List<Continente>(continentes);
        }

        public List<Continente> getContinentes()
        {
            //retorna uma cópia da lista de continentes para operações de escrita sobre lista de continentes
            return new List<Continente>(this._continentes);
        }
    }
}