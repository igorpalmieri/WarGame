using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    class Preparacao
    {
        private Jogador                iniciador;
        private List<Jogador>         _listaDeJogadores;
        private List<CartaObjetivo>   _listaDeCartasObjetivo;
        private List<CartaTerritorio> _listaDeCartasTerritorio;

        public Preparacao()
        {
            sortearObjetivo();
            sortearTerritorios();
            this.iniciador = sortearJogador();
        }

        public Jogador sortearJogador()
        {
            return _listaDeJogadores.ElementAt(sortearIndiceJogador());
        }

        public int sortearIndiceJogador()
        {
            Random randN = new Random();
            int indice = randN.Next(0, _listaDeJogadores.Count-1);
            return indice;
        }

        public void sortearObjetivo()
        {
            int[] indicesObjetivo = sortearIndicesObjetivo();
            for(int i = 0;i < _listaDeJogadores.Count; i++)
            {
                _listaDeJogadores.ElementAt(i).ReceberObjetivo(_listaDeCartasObjetivo.ElementAt(indicesObjetivo[i]));
            }
        }

        public int[] sortearIndicesObjetivo()
        {
            Random randN = new Random();
            int[] indicesObjetivo = new int[_listaDeJogadores.Count];
            inicializarVetor(indicesObjetivo);
            int num = 0;
            for(int i = 0;i < _listaDeJogadores.Count; i++)
            {
                num = randN.Next(0,_listaDeCartasObjetivo.Count-1);
                while (verificarRepeticao(indicesObjetivo,num))
                {
                    num = randN.Next(0, _listaDeCartasObjetivo.Count - 1);
                }
                indicesObjetivo[i] = num;
            }
            return indicesObjetivo;
                
        }

        public void sortearTerritorios()
        {
            int [] indicesTerritorio = sortearIndicesTerritorio();
            int qtdJogadores = _listaDeJogadores.Count;
            int numCartasJogador = indicesTerritorio.Count() / qtdJogadores;
            int cartasRestantes = indicesTerritorio.Count() - numCartasJogador;
            int ini = 0,fim = 0;
            for(int i = 0;i < qtdJogadores; i++)
            {
                fim = (i+1) * numCartasJogador;
                for(int j = ini;j < fim; j++)
                {
                    _listaDeJogadores.ElementAt(i).ReceberTerritorio(_listaDeCartasTerritorio.ElementAt(indicesTerritorio[j]));
                }
                ini = fim;
            }
            fim = ini + cartasRestantes - 1;
            while(ini != fim)
            {
                _listaDeJogadores.ElementAt(sortearIndiceJogador()).ReceberTerritorio(_listaDeCartasTerritorio.ElementAt(indicesTerritorio[ini]));
                ini++;
            }
        }

        public int[] sortearIndicesTerritorio()
        {
            Random randN = new Random();
            int[] indicesTerritorio = new int[_listaDeCartasTerritorio.Count];
            inicializarVetor(indicesTerritorio);
            int num = 0;
            for(int i = 0;i < _listaDeCartasTerritorio.Count; i++)
            {
                num = randN.Next(0, _listaDeCartasTerritorio.Count - 1);
                while (verificarRepeticao(indicesTerritorio, num))
                {
                    num = randN.Next(0, _listaDeCartasTerritorio.Count - 1);
                }
                indicesTerritorio[i] = num;
            }
            return indicesTerritorio;
        }

        public Boolean verificarRepeticao(int[] indices,int num)
        {
            for(int i = 0;i < indices.Count(); i++)
            {
                if (indices[i] == num)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public void inicializarVetor(int[] vetor)
        {
            for(int i = 0;i < vetor.Count(); i++)
            {
                vetor[i] = -1;
            }
        }
    }
}
