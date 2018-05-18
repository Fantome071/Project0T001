using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Couleur
    {
        // Couleur : 1 = Bleu | 2 = Rouge | 3 = Blanc | 4 = Vert
        public int _couleur { get; }

        public Couleur(int numCouleur)
        {
            _couleur = numCouleur;
        }

        public string GetNomCouleur()
        {
            string couleur = "Error";

            switch (_couleur)
            {
                case 1:
                    couleur = "Bleu";
                    break;
                case 2:
                    couleur = "Rouge";
                    break;
                case 3:
                    couleur = "Blanc";
                    break;
                case 4:
                    couleur = "Vert";
                    break;
            }

            return couleur;
        }
    }
}
