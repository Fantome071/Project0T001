using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Emplacement
    {
        public Coordonnee _coordonnee { get; set; }

        public bool _tuileFantome { get; set; }

        public bool _tuilePiece { get; set; }

        public Emplacement()
        {
            _coordonnee = new Coordonnee(0, 0);

            _tuileFantome = false;
            _tuilePiece = false;
        }
    }
}
