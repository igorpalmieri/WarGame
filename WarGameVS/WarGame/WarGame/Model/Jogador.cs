using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Jogador
    {
        public string Nome { get;}
        private List<Exercito> _exercitosDisponiveis;

        public Jogador(string nome)
        {
            this.Nome = nome;
            this._exercitosDisponiveis = new List<Exercito>();
        }

        public void receberExercito(Exercito exercito)
        {
            exercito.Comandante = this;
            this._exercitosDisponiveis.Add(exercito);
        }

        public void receberExercitos(List<Exercito> exercitos)
        {
            exercitos.ForEach(e => e.Comandante = this);
            this._exercitosDisponiveis.AddRange(exercitos);
        }

        public int contarExercitos()
        {
            return _exercitosDisponiveis.Count;
        }

        public Exercito darExercito()
        {
            if(this.contarExercitos() == 0)
            {
                throw new Exception(this.Nome + ": Não há mais exércitos disponíveis");
            }
            var exercito = _exercitosDisponiveis[0];
            _exercitosDisponiveis.Remove(exercito);
            return exercito;
        }
    }
}
