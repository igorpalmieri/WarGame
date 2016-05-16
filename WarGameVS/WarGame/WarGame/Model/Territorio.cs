using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Model
{
    public class Territorio
    {
        private string nome { get; set; }
        private List<Territorio> fronteiras;
        private List<Exercito> exercitos;
    }
}