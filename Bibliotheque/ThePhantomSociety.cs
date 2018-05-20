using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class ThePhantomSociety
    {
        public int _nbJoueurs { get; }
        public Joueur[] _JoueursJeu { get; set; }

        public Plateau _plateauJeu { get; set; }
        public Resultat _resultatJeu { get; set; }

        public bool _modeComplet { get; }
        public PackCartesObjectifs _packCartesObjectifs { get; }

        public Regles _regles { get; set; }

        public ThePhantomSociety(int nbJoueur, int nbManches, bool modeComplet)
        {
            _nbJoueurs = nbJoueur;
            _modeComplet = modeComplet;

            _JoueursJeu = new Joueur[nbJoueur];

            _plateauJeu = new Plateau();

            _resultatJeu = new Resultat(nbManches);

            if (modeComplet == true)
                _packCartesObjectifs = new PackCartesObjectifs();

            _regles = new Regles(_modeComplet);
        }

        public void DefinitionDesJoueurs(string[] nom, bool[] role)
        {
            for (int i = 0; i < _nbJoueurs; i++)
            {
                _JoueursJeu[i] = new Joueur(nom[i], _nbJoueurs, role[i]);
            }
        }

        public void GetRoleAleatoire(bool[] role)
        {
            Random Aleatoire = new Random();
            int nombreAleatoire;

            if (_nbJoueurs == 2)
            {
                nombreAleatoire = Aleatoire.Next(1);
                if (nombreAleatoire == 1)
                {
                    role[0] = true;
                    role[1] = false;
                }
                else
                {
                    role[0] = false;
                    role[1] = true;
                }
            }

            if (_nbJoueurs == 4 || _nbJoueurs == 3)
            {
                for (int i = 0; i < _nbJoueurs; i++)
                    role[i] = false;

                int temp = _nbJoueurs;
                for (int i = 0; i < 2; i++)
                {
                    nombreAleatoire = Aleatoire.Next(0, _nbJoueurs - 1);
                    while (nombreAleatoire == temp)
                        nombreAleatoire = Aleatoire.Next(0, _nbJoueurs - 1);
                    temp = nombreAleatoire;
                    role[nombreAleatoire] = true;
                }
            }
        }

        public bool DevasterPiece(int x, int y, bool fantome)
        {
            bool codeRetour = false;

            if (_plateauJeu._plateau[x, y]._devaste == false)
            {
                if (fantome == false)
                {
                    _plateauJeu._plateau[x, y]._devaste = true;
                    codeRetour = true;
                }
                else
                {
                    bool devasterPossible = false;

                    if (devasterPossible == true)
                    {
                        _plateauJeu._plateau[x, y]._devaste = true;
                        codeRetour = true;
                    }
                }

                if (_plateauJeu._plateau[x, y]._emplacement._tuileFantome == true)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (_plateauJeu._tuileFantome[i]._emplacement == _plateauJeu._plateau[x, y]._emplacement)
                            _plateauJeu._tuileFantome[i]._etat = false;
                    }
                }
            }

            return codeRetour;
        }

        public void ResetJeu()
        {
            _resultatJeu._nbPartieJoue = _resultatJeu._nbPartieJoue + 1;
        }
    }
}
