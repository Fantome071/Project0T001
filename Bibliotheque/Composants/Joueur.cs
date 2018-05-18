using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Joueur
    {
        public int _partieGagner { get; set; }
        public string _nom { get; }

        // Role : Fantome = True | Chasseur = False
        public bool _role { get; set; }

        public TuileFantome[] _tuileFantomeJoueur { get; set; }

        public Joueur(string nom, int nbJoueur, bool role)
        {
            _partieGagner = 0;
            _nom = nom;
            _role = role;

            if (_role == true)
            {
                if (nbJoueur == 2)
                    _tuileFantomeJoueur = new TuileFantome[4];
                else
                    _tuileFantomeJoueur = new TuileFantome[2];
            }
        }

        public void TransformationFantome(int nbJoueur)
        {
            _role = true;

            if (nbJoueur == 2)
                _tuileFantomeJoueur = new TuileFantome[4];
            else
                _tuileFantomeJoueur = new TuileFantome[2];
        }

        public void TransformationChasseur()
        {
            _role = false;
        }
    }
}
