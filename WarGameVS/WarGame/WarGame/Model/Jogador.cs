using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Jogador
    {
        public  int                   indice;
        public  string                Nome { get;}
        private List<Exercito>        _exercitosDisponiveis;
        private CartaObjetivo         _cartaObjetivo;
        private List<CartaTerritorio> _cartasTerritorio;

        public Jogador(string nome, CartaObjetivo cartaObjetivo)
        {
            this.Nome = nome;
            this._exercitosDisponiveis = new List<Exercito>();
            this._cartaObjetivo = cartaObjetivo;
            this._cartasTerritorio = new List<CartaTerritorio>();
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

        public CartaTerritorio darCartaTerritorio(CartaTerritorio terr)
        {
            _cartasTerritorio.Remove(terr);
            return terr;
        }

        public void receberTerritorio(CartaTerritorio terr)
        {
            _cartasTerritorio.Add(terr);
        }

        public void receberObjetivo(CartaObjetivo obj)
        {
            _cartaObjetivo = obj;
        }
    }
}
