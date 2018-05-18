using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class ThePhantomSociety
    {
        public int _nbJoueurs { get; set; }
        public Joueur _tabJoueurs { get; set; }

        public Plateau _plateauJeu { get; set; }
        public Resultat _resultatJeu { get; set; }

        public bool _modeComplet { get; }
        public PackCarteObjectifs _packCarteObjectifs { get; set; }

        public Regles _regles { get; set; }

        public ThePhantomSociety(int nbJoueur, bool modeComplet)
        {
            _nbJoueurs = nbJoueur;
            _modeComplet = modeComplet;
        }
    }
}
