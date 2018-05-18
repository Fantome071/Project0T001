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

        public Tuile(Couleur couleur)
        {
            _couleur = couleur;
            _emplacement._coordonnee.SetNull();
        }
    }
}
