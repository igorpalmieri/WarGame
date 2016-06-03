using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Territorio
    {
        public string Nome { get; }
        private List<Territorio> _fronteiras;
        private List<Exercito> _exercitos;

        public Territorio(string nome)
        {
            this.Nome = nome;
            this._exercitos = new List<Exercito>();
        }

        public Territorio(string nome, List<Territorio> fronteiras)
        {
            this.Nome = nome;
            this._exercitos = new List<Exercito>();
            this._fronteiras = new List<Territorio>(fronteiras);
        }

        public void AddExercito(Exercito e)
        {
            this._exercitos.Add(e);
        }

        public void AddExercitos(List<Exercito> exercitos)
        {
            this._exercitos.AddRange(exercitos);
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

            //Obtem o numero de exercitos desejado
            var exercitos = this._exercitos.Take(numExercitos).ToList();
            //remove os exercitos do territorio para a lista
            exercitos.ForEach(e => this._exercitos.Remove(e));

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