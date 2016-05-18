using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class CartaObjetivo
    {
        public string descricao { get; }

        public CartaObjetivo() { }
        public CartaObjetivo(string descricao)
        {
            this.descricao = descricao;
        }
    }

    


}
