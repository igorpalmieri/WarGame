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
        private CartaObjetivo objetivo;
        private List<CartaTerritorio> _cartasTerr;


        public Jogador(string nome)
        {
            this.Nome = nome;
            this._exercitosDisponiveis = new List<Exercito>();
            this._cartasTerr = new List<CartaTerritorio>();
            this.objetivo = new CartaObjetivo();
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
        
        public void receberObjetivo(CartaObjetivo objetivo) 
        {
            this.objetivo = objetivo;
        }

        public void receberCartaTerritorio(CartaTerritorio cTerr)
        {
            this._cartasTerr.Add(cTerr);
        }

        public CartaTerritorio darCartaTerritorio(CartaTerritorio cTerr)
        {
            this._cartasTerr.Remove(cTerr);
            return cTerr;
        }

    }
}
