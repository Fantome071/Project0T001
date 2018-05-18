using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Resultat
    {
        public int _nbPartie { get; }
        public int _nbPartieJoue { get; set; }
        public Stats[] _PartieStats { get; set; }
        public bool[] _Victoires { get; set; }

        public Resultat()
        {

        }
    }
}
