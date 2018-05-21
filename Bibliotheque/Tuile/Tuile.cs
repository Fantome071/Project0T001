using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Tuile
    {
        public Couleur _couleur { get; }
        public Emplacement _emplacement { get; set; }
        public bool _placer { get; set; }

        public Tuile(Couleur couleur)
        {
            _couleur = new Couleur(couleur._couleur);
            _emplacement = new Emplacement();
            _placer = false;
        }
    }
}
