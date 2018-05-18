using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Stats
    {
        public int _degatactu { get; }
        public bool _fantomeRestant { get; }

        public Stats()
        {
            _degatactu = 0;

            Couleur temp = new Couleur(1);

            TuileFantome[] fantome = new TuileFantome[4];

            for ( int i = 0; i < 4; i++)
            {
                temp._couleur = i + 1;
                fantome[i] = new TuileFantome(temp);
            }
        }

        /*
        public int Degat()
        {
            int degat = 45000;
            return degat;
        }

        public int Degat(int cartenum,int cartedecim)
        {
            int degat;
            degat = cartenum * 10000 + cartedecim;
            return degat;
        }
        */

        public void DegatActu(TuilePiece actu)
        {
            _degatactu += actu._valeur;
        }
    }
}
