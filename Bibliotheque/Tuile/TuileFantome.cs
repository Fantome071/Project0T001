using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class TuileFantome : Tuile
    {
        public bool _etat { get; set; }

        public TuileFantome(Couleur couleur) : base(couleur)
        {
            _etat = true;
        }
    }
}
