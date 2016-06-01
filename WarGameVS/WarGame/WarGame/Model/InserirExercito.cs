using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class InserirExercito
    {
        private Territorio     _territorioDestino;
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
            if((this._territorioDestino.getComandate() == null) || (this._territorioDestino.getComandate() != this._exercitos[0].Comandante))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void realizarMovimento()
        {
            if(this.validarMovimento() == true)
            {
                this._territorioDestino.addExercitos(this._exercitos);
            }
        }
    }
}
