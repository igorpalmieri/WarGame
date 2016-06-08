using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Territorio
    {
        public  string           Nome { get; }
        private List<Territorio> _fronteiras;
        private List<Exercito>   _exercitos;

        public Territorio(string nome)
        {
            this.Nome = nome;
            this._exercitos = new List<Exercito>();
            this._fronteiras = new List<Territorio>();
        }

        public Territorio(string nome, List<Territorio> fronteiras)
        {
            this.Nome = nome;
            this._exercitos = new List<Exercito>();
            this._fronteiras = new List<Territorio>(fronteiras);
        }

        public void AddFronteira(Territorio t)
        {
            this._fronteiras.Add(t);
            t.AddFronteira(this);
        }

        public void AddFronteiras(List<Territorio> t)
        {
            this._fronteiras.AddRange(t);
            t.ForEach(terr => terr.AddFronteira(this));
        }

        public void AddExercito(Exercito e)
        {
			e.TerritorioOcupado = this;
            this._exercitos.Add(e);
        }

        public void AddExercitos(List<Exercito> exercitos)
        {
			exercitos.ForEach(ex => ex.TerritorioOcupado = this);
            this._exercitos.AddRange(exercitos);
        }

        public int CountExercitos()
        {
            return this._exercitos.Count;
        }

        public bool IsVizinho(Territorio t)
        {
			return this._fronteiras.Any(fronteira => fronteira.Equals(t));
        }

        public Jogador GetComandate()
        {
            if(this._exercitos.Count == 0)
            {
                return null;
            }
            else
            {
                return _exercitos[0].Comandante;
            }
        }

        public List<Exercito> GetExercitosByQuantidade(int numExercitos)
        {
            if(numExercitos > this._exercitos.Count - 1)
            {
                throw new Exception("Não é possível obter esta quantidade de exércitos");
            }

			var exercitos = this._exercitos.Take(numExercitos).ToList(); /* Obtem o numero de exercitos desejado */
			exercitos.ForEach (ex => ex.TerritorioOcupado = null);		 /* desassocia os exercitos do territorio antes de removê-los do território */
			exercitos.ForEach(e => this._exercitos.Remove(e)); 			 /* move os exercitos do territorio para a lista */

            return exercitos;
        }

        public int PotenciaisAtacantes()
        {
            return ((this._exercitos.Count - 1) > 3) ? 3 : this._exercitos.Count - 1;
        }

        public int PotenciaisDefensores()
        {
            return (this._exercitos.Count);
        }
    }
}