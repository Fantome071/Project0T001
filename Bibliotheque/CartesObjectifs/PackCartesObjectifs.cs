using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class PackCartesObjectifs
    {
        public CartesObjectifs[] _cartesObjectifsDizaines { get; }
        public CartesObjectifs[] _cartesObjectifsMilliers { get; }

        public PackCartesObjectifs()
        {
            _cartesObjectifsDizaines = new CartesObjectifs[8];

            for (int i = 0; i < 8; i++)
                _cartesObjectifsDizaines[i] = new CartesObjectifs("Carte Dizaine N" + i.ToString(), 10 * (i + 1));

            _cartesObjectifsMilliers = new CartesObjectifs[8];

            for (int i = 0; i < 8; i++)
                _cartesObjectifsMilliers[i] = new CartesObjectifs("Carte Millier N" + i.ToString(), 1000 * (i + 1));
        }

        public CartesObjectifs GetCarteObjectifs(bool typeCarte)
        {
            CartesObjectifs res;

            if (typeCarte == true)
                res = new CartesObjectifs(_cartesObjectifsDizaines[0]._nomCarte, _cartesObjectifsDizaines[0]._valeurCarte);
            else
                res = new CartesObjectifs(_cartesObjectifsMilliers[0]._nomCarte, _cartesObjectifsMilliers[0]._valeurCarte);

            return res;
        }
    }
}
