using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Regles
    {
        public string _livreDesRegles { get; }

        public Regles(bool modeComplet)
        {
            if (modeComplet == true)
            {
                _livreDesRegles = "Listes des règles (avec règles pour mode complet) :";
            }
            else
            {
                _livreDesRegles = "Listes des règles :";
            }
        }
    }
}
