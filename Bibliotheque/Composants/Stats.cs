using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Stats
    {
        public int _objectif { get; }

        public int _degatsActuels { get; set; }

        public TuileFantome[] _fantomeRestant { get; set; }
        public int _nbFantomeRestant { get; set; }

        public Stats(int objectif)
        {
            _degatsActuels = 0;
            _objectif = objectif;
            _fantomeRestant = new TuileFantome[4];
            _nbFantomeRestant = 4;
        }

        public void MajStatsFantome(TuileFantome tuileFantome01, TuileFantome tuileFantome02, TuileFantome tuileFantome03, TuileFantome tuileFantome04)
        {
            _fantomeRestant[0] = tuileFantome01;
            _fantomeRestant[1] = tuileFantome02;
            _fantomeRestant[2] = tuileFantome03;
            _fantomeRestant[3] = tuileFantome04;

            int compteurFantomeRestant = 0;

            for (int i = 0; i < 4; i++)
            {
                if (_fantomeRestant[i]._etat == true)
                    compteurFantomeRestant++;
            }

            _nbFantomeRestant = compteurFantomeRestant;
        }

        public void MajStatsDegats(Plateau plateau01)
        {
            int compteurDegats = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (plateau01._plateau[i, j]._devaste)
                        compteurDegats = compteurDegats + plateau01._plateau[i, j]._valeur;
                }
            }

            _degatsActuels = compteurDegats;
        }
    }
}
