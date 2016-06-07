using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WarGame.Exceptions;

namespace WarGame.Model
{
    public class InserirExercito
    {
        private Territorio     _territorioDestino;
        public  Territorio     TerritorioDestino { get { return this._territorioDestino; } }
        private List<Exercito> _exercitos;

        public InserirExercito(Territorio territorioDestino, List<Exercito> exercitos)
        {
            this._territorioDestino = territorioDestino;
            this._exercitos = exercitos;
        }

        /// <summary>
        /// Checa se o movimento desejado é possível
        /// <para>O jogador pode um exército em um território apenas se
        /// ele já possuir algum exército naquele território.</para>
        /// </summary>
        /// <returns>Boolean de validade do movimento</returns>
        public bool validarMovimento()
        {
            if(this._territorioDestino.GetComandate() == this._exercitos[0].Comandante)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void realizarMovimento()
        {
            if(this.validarMovimento() == true)
            {
                this._territorioDestino.AddExercitos(this._exercitos);
            }
            else
            {
                throw new JogadaInvalidaException("Movimento de inserção inválido");
            }
        }
    }
}
