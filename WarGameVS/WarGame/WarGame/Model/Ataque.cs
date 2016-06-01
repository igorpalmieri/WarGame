using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Ataque
    {
        private Jogador        _atacante;
        private Territorio     _territorioOrigem, _territorioDestino;
        private int            _numeroExerctiosAtaque = 0, _numeroExercitosDefesa = 0;
        private List<Exercito> _exercitosAtacantes, _exercitosDefensores;

        public Ataque(Jogador atacante, Territorio territorioOrigem, Territorio territorioDestino)
        {
            this._atacante = atacante;
            this._territorioOrigem = territorioOrigem;
            this._territorioDestino = territorioDestino;
        }

        public void setQuantAtacantes(int numeroExercitos)
        {
            if (numeroExercitos <= this._territorioOrigem.potenciaisAtacantes())
            {
                this._numeroExerctiosAtaque = numeroExercitos;
            }
            else
            {
                throw new Exception("Numero de atacantes inválido");
            }
        }

        public void setQuantDefensores(int numeroExercitos)
        {
            if (numeroExercitos <= this._territorioOrigem.potenciaisDefensores())
            {
                this._numeroExercitosDefesa = numeroExercitos;
            }
            else
            {
                throw new Exception("Numero de defensores inválido");
            }
        }
    }
}
