﻿using WarGame.Exceptions;

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
            //TODO adicionar teste limite quantidade de exercitos movimento
            if(!this._territorioOrigem.IsVizinho(this._territorioDestino))
            {
                return ResultadoMovimento.SEM_FRONTEIRA;
            }
            else if(!this._territorioDestino.GetComandate().Equals(_jogador))
            {
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
                throw new JogadaInvalidaException("Movimento inválido");
            }
        }
    }
}
