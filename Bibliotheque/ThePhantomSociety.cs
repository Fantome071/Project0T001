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

        public void PlacerPiece(TuilePiece piece)
        {
            piece._placer = true;
            _plateauJeu._plateau[piece._emplacement._coordonnee._x, piece._emplacement._coordonnee._y] = piece;
        }

        public void PlacerLesFantomes()
        {
            for (int i = 0; i < 4; i++)
            {
                if (_plateauJeu._tuileFantome[i]._placer == false)
                {
                    _plateauJeu._plateau[_plateauJeu._tuileFantome[i]._emplacement._coordonnee._x, _plateauJeu._tuileFantome[i]._emplacement._coordonnee._y]._emplacement._tuileFantome = true;
                    _plateauJeu._tuileFantome[i]._placer = true;
                }
            }
        }

        public bool DevasterPiece(int x, int y)
        {
            bool codeRetour = false;

            if (_plateauJeu._plateau[x, y]._devaste == false)
            {
                if (_plateauJeu._plateau[x, y]._emplacement._tuileFantome == false)
                {
                    _plateauJeu._plateau[x, y]._devaste = true;
                    _resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._degatsActuels = _resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._degatsActuels + _plateauJeu._plateau[x, y]._valeur;
                    FinJeu();
                    codeRetour = true;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (_plateauJeu._tuileFantome[i]._emplacement._coordonnee == _plateauJeu._plateau[x, y]._emplacement._coordonnee)
                        {
                            _plateauJeu._tuileFantome[i]._etat = false;
                            UpdateStatsFantome();
                            FinJeu();
                            codeRetour = true;
                        }
                    }
                }
            }

            return codeRetour;
        }

        public void UpdateStatsFantome()
        {
            int compteurFantome = 0;

            for (int i = 0; i < 4; i++)
            {
                if (_plateauJeu._tuileFantome[i]._etat == false)
                {
                    compteurFantome = compteurFantome - 1;
                    _resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._fantomeRestant[i] = _plateauJeu._tuileFantome[i];
                }
            }

            _resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._nbFantomeRestant = compteurFantome;
        }

        public void UpdateStatsDegats()
        {
            int compteurDegats = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (_plateauJeu._plateau[i, j]._devaste == true)
                        compteurDegats = compteurDegats + _plateauJeu._plateau[i, j]._valeur;
                }
            }

            _resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._degatsActuels = compteurDegats;
        }

        public void FinJeu()
        {
            if (_resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._degatsActuels >= _resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._objectif)
            {
                _resultatJeu._Victoires[_resultatJeu._nbPartieJoue - 1] = true;
                
                for (int i = 0; i < _nbJoueurs; i++)
                {
                    if (_JoueursJeu[i]._role == false)
                        _JoueursJeu[i]._partieGagner = _JoueursJeu[i]._partieGagner + 1;
                }
            }

            if (_resultatJeu._PartieStats[_resultatJeu._nbPartieJoue - 1]._nbFantomeRestant == 0)
            {
                _resultatJeu._Victoires[_resultatJeu._nbPartieJoue - 1] = false;

                for (int i = 0; i < _nbJoueurs; i++)
                {
                    if (_JoueursJeu[i]._role == true)
                        _JoueursJeu[i]._partieGagner = _JoueursJeu[i]._partieGagner + 1;
                }
            }
        }

        public void ResetJeu()
        {
            _resultatJeu._nbPartieJoue = _resultatJeu._nbPartieJoue + 1;
            _plateauJeu = new Plateau();
        }
    }
}
