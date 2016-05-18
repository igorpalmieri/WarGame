using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Movimento
    {
        private Jogador    _jogador;
        private Territorio _territorioOrigem, _territorioDestino;
        
        public Movimento(Jogador jogador, Territorio territorioOrigem, Territorio territorioDestino)
        {
            this._jogador = jogador;
            this._territorioOrigem = territorioOrigem;
            this._territorioDestino = territorioDestino;
        }

        public bool validarMovimento()
        {
            return false;
        }
    }
}
