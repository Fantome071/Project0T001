using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class CartesObjectifs
    {
        public string _nomCarte { get; set; }
        public int _valeurCarte { get; set; }

        // True = Cartes Objectifs Dizaines
        // False = Cartes Objectifs Milliers
        public bool _typeCarte { get; }

        public CartesObjectifs(string nomCarte, int valeurCarte)
        {
            _nomCarte = nomCarte;
            _valeurCarte = valeurCarte;

            if (_valeurCarte < 100)
                _typeCarte = true;
            else
                _typeCarte = false;
        }

        public string GetTypeCarte()
        {
            string type;

            if (_typeCarte == true)
                type = "Dizaines";
            else
                type = "Milliers";

            return type;
        }
    }
}
