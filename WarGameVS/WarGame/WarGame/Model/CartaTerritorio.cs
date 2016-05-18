using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class CartaTerritorio
    {
        public Territorio terr    { get; }
        public string     simbolo { get; }

        public CartaTerritorio(Territorio terr, string simbolo)
        {
            this.terr = terr;
            this.simbolo = simbolo;
        }
    }
}
