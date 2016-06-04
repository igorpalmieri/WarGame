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
        private List<Exercito>        _exercitos;
        private CartaObjetivo         _cartaObjetivo;
        private List<CartaTerritorio> _cartasTerritorio;

        public Jogador(string nome, CartaObjetivo cartaObjetivo)
        {
            this.Nome = nome;
            this._exercitos = new List<Exercito>();
            this._cartaObjetivo = cartaObjetivo;
            this._cartasTerritorio = new List<CartaTerritorio>();
        }

        public void ReceberExercito(Exercito exercito)
        {
            exercito.Comandante = this;
            this._exercitos.Add(exercito);
        }

        public void ReceberExercitos(List<Exercito> exercitos)
        {
            exercitos.ForEach(e => e.Comandante = this);
            this._exercitos.AddRange(exercitos);
        }

        public int ContarExercitos()
        {
            return _exercitos.Count;
        }

        public Exercito DarExercito()
        {
			var exercitosDisponiveis = this._exercitos.Where(ex => ex.TerritorioOcupado.Equals(null)).ToList();

			if(exercitosDisponiveis.Count == 0)
            {
                throw new Exception(this.Nome + ": Não há mais exércitos disponíveis");
            }
            
			return exercitosDisponiveis.First();
        }

        public CartaTerritorio DarCartaTerritorio(CartaTerritorio terr)
        {
            _cartasTerritorio.Remove(terr);
            return terr;
        }

        public void ReceberTerritorio(CartaTerritorio terr)
        {
            _cartasTerritorio.Add(terr);
        }

        public void ReceberObjetivo(CartaObjetivo obj)
        {
            _cartaObjetivo = obj;
        }

		public int QuantidadeTerritorios()
		{
			return (from exercito in this._exercitos
				 	where !exercito.TerritorioOcupado.Equals (null)
				 	select exercito.TerritorioOcupado).Count;
		}

		public int QuantidadeExercitosAReceber()
		{
			//TODO implementar modificadores de cartas e continentes
			int quantidadeExercitosReceber = 0;
			quantidadeExercitosReceber += Math.Floor(this.QuantidadeTerritorios / 2);

			return quantidadeExercitosReceber;
		}
    }
}
