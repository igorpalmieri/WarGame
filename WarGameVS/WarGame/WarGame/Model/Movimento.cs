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
        private int        _numExercitosMover;

        public enum ResultadoMovimento { VALIDO, SEM_FRONTEIRA, BATALHA }

        public Movimento(Jogador jogador, Territorio territorioOrigem, Territorio territorioDestino, int numExercitosMover)
        {
            this._jogador = jogador;
            this._territorioOrigem = territorioOrigem;
            this._territorioDestino = territorioDestino;
            this._numExercitosMover = numExercitosMover;
        }

        public ResultadoMovimento validarMovimento()
        {
            if(!this._territorioOrigem.IsVizinho(this._territorioDestino))
            {
                return ResultadoMovimento.SEM_FRONTEIRA;
            }
            else if(!this._territorioDestino.GetComandate().Equals(null) && !this._territorioDestino.GetComandate().Equals(_jogador))
            {
                // TODO remover caso de território nulo
                return ResultadoMovimento.BATALHA;
            }
            else
            {
                return ResultadoMovimento.VALIDO;
            }
        }

        public void realizarMovimento()
        {
            if(this.validarMovimento() == ResultadoMovimento.VALIDO)
            {
                this._territorioDestino.AddExercitos(this._territorioOrigem.GetExercitosByQuantidade(this._numExercitosMover));
            }
            else
            {
                throw new Exception("Movimento inválido");
            }
        }
    }
}
