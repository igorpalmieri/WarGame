using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Ataque
    {
        private Jogador                   _atacante;
        private Territorio                _territorioOrigem, _territorioDestino;
        private int                       _numeroExercitosAtaque = 0, _numeroExercitosDefesa = 0;
        private Dictionary<Exercito, int> _exercitosAtacantes, _exercitosDefensores;    /* dicionario relaciona um exercito com um valor de dado */

        public Ataque(Jogador atacante, Territorio territorioOrigem, Territorio territorioDestino)
        {
            this._atacante            = atacante;
            this._territorioOrigem    = territorioOrigem;
            this._territorioDestino   = territorioDestino;
            this._exercitosAtacantes  = new Dictionary<Exercito, int>();
            this._exercitosDefensores = new Dictionary<Exercito, int>();
        }

        public void SetQuantAtacantes(int numeroExercitos)
        {
            if (numeroExercitos <= this._territorioOrigem.PotenciaisAtacantes())
            {
                this._numeroExercitosAtaque = numeroExercitos;
            }
            else
            {
                throw new Exception("Numero de atacantes inválido");
            }
        }

        public void SetQuantDefensores(int numeroExercitos)
        {
            if (numeroExercitos <= this._territorioOrigem.PotenciaisDefensores())
            {
                this._numeroExercitosDefesa = numeroExercitos;
            }
            else
            {
                throw new Exception("Numero de defensores inválido");
            }
        }

        private void ObterExercitos()
        {
            var exercitosAtaque = this._territorioOrigem.GetExercitosByQuantidade(this._numeroExercitosAtaque);
            var exercitosDefesa = this._territorioDestino.GetExercitosByQuantidade(this._numeroExercitosDefesa);

            exercitosAtaque.ForEach(exercito => this._exercitosAtacantes.Add(exercito, 0));
            exercitosDefesa.ForEach(exercito => this._exercitosDefensores.Add(exercito, 0));
        }

        private void RolarDados()
        {
            Random r = new Random();
            foreach(var chaveDicionario in this._exercitosAtacantes.Keys)
            {
                this._exercitosAtacantes[chaveDicionario] = r.Next(1, 6);
            }

            foreach(var chaveDicionario in this._exercitosDefensores.Keys)
            {
                this._exercitosDefensores[chaveDicionario] = r.Next(1, 6);
            }
        }

        public bool ValidarAtaque()
        {
            if(this._territorioOrigem.IsVizinho(this._territorioDestino) &&
                this._numeroExercitosAtaque != 0 &&
                this._numeroExercitosDefesa != 0 &&
                this._territorioOrigem.GetComandate() != this._territorioDestino.GetComandate())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FinalizarAtaque()
        {
            if(this._exercitosDefensores.Count == 0)    /* caso todos todos os exercitos defensores tenha sido destruidos */ 
            {
                this._territorioDestino.AddExercitos(this._exercitosAtacantes.Keys.ToList());   /* mover os atacantes para o territorio destino */
            }
            else
            {
                this._territorioOrigem.AddExercitos(this._exercitosAtacantes.Keys.ToList());    /* mover os exercitos atacantes de volta para o territorio origem */
                this._territorioDestino.AddExercitos(this._exercitosDefensores.Keys.ToList());  /* mover os exercitos defensores de volta para o territorio destino */
            }
        }

        public void Atacar()
        {
            this.ObterExercitos();  /* obtem exercitos dos territorios que participarão na batalha */
            this.RolarDados();      /* "rola" os dados e relaciona os valores aos exercitos em um dicionario */

            /* 
              define o numero de enfrentamentos; que corresponde a menor quantidade de exercitos
              envolvida na batalha
            */
            int numeroEnfrentamentos = (this._exercitosAtacantes.Count <= this._exercitosDefensores.Count) ?
                                        this._exercitosAtacantes.Count : this._exercitosDefensores.Count;

            for (int i = 0; i < numeroEnfrentamentos; i++)
            {
                KeyValuePair<Exercito, int> exercitoAtacante = this._exercitosAtacantes.OrderByDescending(ex => ex.Value)
                                                                .FirstOrDefault();  /* seleciona o exercito de ataque com o maior valor de dado */
                KeyValuePair<Exercito, int> exercitoDefensor = this._exercitosDefensores.OrderByDescending(ex => ex.Value)
                                                                .FirstOrDefault();  /* seleciona o exercito de defesa com o maior valor de dado */

                if(exercitoAtacante.Value < exercitoDefensor.Value)
                {
                    this._exercitosAtacantes.Remove(exercitoAtacante.Key);
                }
                else
                {
                    this._exercitosDefensores.Remove(exercitoDefensor.Key);
                }
            }

            this.FinalizarAtaque();
        }
    }
}
