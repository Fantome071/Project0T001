using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class TuilePiece : Tuile
    {
        public int _valeur { get; }
        public bool _devaste { get; set; }

        public TuilePiece(Couleur couleur, int valeur) : base(couleur)
        {
            _valeur = valeur;
            _devaste = false;
        }
    }
}
